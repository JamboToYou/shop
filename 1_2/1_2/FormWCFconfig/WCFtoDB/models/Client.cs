using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFtoDB
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int idClient { get; set; }

        [DataMember]
        public string SNP { get; set; }

    }
}
