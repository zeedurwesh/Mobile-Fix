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
    public partial class frmRepairJob : Form
    {
        public frmRepairJob()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddRepairJob showForm = new frmAddRepairJob(this, null);
            showForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (lstRepairJobs.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstRepairJobs.SelectedItems[0];
                clsRepair repair = (clsRepair)selectedItem.Tag;
                frmAddRepairJob showForm = new frmAddRepairJob(this, repair);
                showForm.Show();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstRepairJobs.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstRepairJobs.SelectedItems[0];
                clsRepair repair = (clsRepair)selectedItem.Tag;
                // Display a message box asking users if they
                // want to delete the selected Repair.
                if (MessageBox.Show("Are you sure to Delete this RepairJob", "Delete Repair",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.Yes)
                {
                    // code for deleting the record goes here
                    clsDBRepair dbRepair = new clsDBRepair();
                    dbRepair.DeleteRepair(repair.ID);
                    loadRepairs();
                }
            }
        }

        private void frmRepairJob_Load(object sender, EventArgs e)
        {
            lstRepairJobs.View = View.Details;
            lstRepairJobs.Columns.Add("Customer Name");
            lstRepairJobs.Columns.Add("Phone Model");
            lstRepairJobs.Columns.Add("SerialNo_IMEI");
            lstRepairJobs.Columns.Add("Fault");
            lstRepairJobs.Columns.Add("Balance");
            lstRepairJobs.Columns.Add("Collection Date");

            loadRepairs();

        }

        public void loadRepairs()
        {

  
            clsDBRepair dbRepair = new clsDBRepair();
            List<clsRepair> repairs = dbRepair.RepairList();

            Int32 Index = 0;
          
            lstRepairJobs.Items.Clear();
            while (Index < repairs.Count)
            {
                clsRepair repair = repairs[Index];
                ListViewItem NewItem = new ListViewItem();
                NewItem.Text = repair.CustomerName;
                NewItem.SubItems.Add(repair.PhoneModel);
                NewItem.SubItems.Add(repair.SerialNo_IMEI);
                NewItem.SubItems.Add(repair.Fault);
                NewItem.SubItems.Add("£" + repair.Balance.ToString("F"));
                NewItem.SubItems.Add(repair.CollectionDate.ToShortDateString());
               
                
                NewItem.Tag = repair;
                lstRepairJobs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstRepairJobs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstRepairJobs.Items.Add(NewItem); //Add the item to ListView


                Index++; //move the index to the next record
            }
        }

     
    }
}
