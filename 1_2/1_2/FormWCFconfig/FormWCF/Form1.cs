using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormWCF.ServiceReference1;
using WCFtoDB;
using System.ServiceModel;

namespace FormWCF
{
    public partial class WCF : Form, ServiceReference1.IService1Callback
    {
        public WCF()
        {
            InitializeComponent();
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) GetAllClientsAsync(sender,e);
            else
            {
                InstanceContext instanceContext = new InstanceContext(this);
                Service1Client service = new Service1Client(instanceContext);
                service.GetAllClients();
            }
        }

        private async void GetAllClientsAsync(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            Service1Client service = new Service1Client(instanceContext);
            await service.GetAllClientsAsync();
        }

        private void dgvSelectView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkBox1.Checked) GetOrdersAsync(sender, e);
            else
            {
                Client c = new Client()
                {
                    idClient = int.Parse(dgvSelectView[0, e.RowIndex].Value.ToString())
                };

                InstanceContext instanceContext = new InstanceContext(this);
                Service1Client service = new Service1Client(instanceContext);
                service.GetOrders(c);
            }
        }

        private async void GetOrdersAsync(object sender, DataGridViewCellEventArgs e)
        {
            Client c = new Client()
                {
                    idClient = int.Parse(dgvSelectView[0, e.RowIndex].Value.ToString())
                };
                
            InstanceContext instanceContext = new InstanceContext(this);
            Service1Client service = new Service1Client(instanceContext);
            await service.GetOrdersAsync(c);
        }

        public void Counter(int countOfCalls)
        {
            lblCounter.Text = countOfCalls.ToString() + " вызовов(а)";
        }

        public void ResultClients(Client[] resultClientList)
        {
            dgvSelectView.DataSource = resultClientList;
        }

        public void ResultOrders(Order[] resultOrderList)
        {
            dataGridView1.DataSource = resultOrderList;
        }
    }
}
