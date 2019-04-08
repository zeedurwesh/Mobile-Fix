using MobileFixVS2015;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MobileFix
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        } 

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier showForm = new frmSupplier();
            showForm.Show();
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            frmDevices showDevice = new frmDevices();
            showDevice.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            frmSaleItems sale = new frmSaleItems();
            sale.Show();
        }

        private void btnPhoneStock_Click(object sender, EventArgs e)
        {
            frmProductRecords phoneRecord = new frmProductRecords();
            phoneRecord.Show();
        }

        private void btnRepairJob_Click(object sender, EventArgs e)
        {
            frmRepairJob allRepairJobs = new frmRepairJob();
           allRepairJobs.Show();
        }

        private void btnSalesRecord_Click(object sender, EventArgs e)
        {
            frmSalesRecord SaleRecord = new frmSalesRecord();
            SaleRecord.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.Show();
        }
    }
}
