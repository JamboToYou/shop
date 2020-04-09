using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


using JKang.IpcServiceFramework;
using Microsoft.Extensions.DependencyInjection;
using System.ServiceModel;
using System.Net;

namespace shop_svc
{
	class Program
	{
		static void Main(string[] args)
		{
			// configure DI
			IServiceCollection services = ConfigureServices(new ServiceCollection());

			// build and run service host
			new IpcServiceHostBuilder(services.BuildServiceProvider())
				.AddNamedPipeEndpoint<ICalculatorService>(name: "localhost", pipeName: "pipeName")
				.AddTcpEndpoint<ICalculatorService>(name: "localhost", ipEndpoint: IPAddress.Loopback, port: 45684)
				.Build()
				.Run();
		}

		private static IServiceCollection ConfigureServices(IServiceCollection services)
		{
			return services
				.AddIpc(builder =>
				{
					builder
						.AddNamedPipe(options =>
						{
							options.ThreadCount = 2;
						})
						.AddService<ICalculatorService, CalculatorService>();
				});
		}
	}
}

