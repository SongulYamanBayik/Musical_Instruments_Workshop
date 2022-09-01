using DataAccesslayer.ProjectContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer.Concrete;

namespace Musical_Instruments_Workshop.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Customers.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerName = txtName.Text;
            customer.CustomerSurname = txtSurname.Text;
            customer.TcNo = txtTc.Text;
            customer.Phone = txtPhone.Text;
            context.Customers.Add(customer);
            context.SaveChanges();
            MessageBox.Show("eklendi.");
        }
    }
}
