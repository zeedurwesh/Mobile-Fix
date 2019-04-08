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
    public partial class frmProductRecords : Form
    {
        public frmProductRecords()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProductRecord showForm = new frmAddProductRecord(this, null);
            showForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstProductRecords.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstProductRecords.SelectedItems[0];
                clsProductRecord productRecord = (clsProductRecord)selectedItem.Tag;

                frmAddProductRecord showForm = new frmAddProductRecord(this, productRecord);
               showForm.Show();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (lstProductRecords.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstProductRecords.SelectedItems[0];
                clsProductRecord productRecord = (clsProductRecord)selectedItem.Tag;

                // Display a message box asking users if they
                // want to delete the selected ProductRecord.
                if (MessageBox.Show("Are you sure to Delete this ProductRecord " , "Delete ProductRecord",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.Yes)
                {
                    // code for deleting the record goes here
                    clsDBProductRecord dbProductRecord = new clsDBProductRecord();
                    dbProductRecord.DeleteProductRecord(productRecord.ID);
                    loadProductRecords();
                }
            }
            
        }

        private void frmProductRecords_Load(object sender, EventArgs e)
        {
            lstProductRecords.View = View.Details;
            lstProductRecords.Columns.Add("Serial Number/IMEI");
            lstProductRecords.Columns.Add("Supplier Name");
            lstProductRecords.Columns.Add("Device Model");
            lstProductRecords.Columns.Add("Price");
            lstProductRecords.Columns.Add("Date Bought");
            lstProductRecords.Columns.Add("Description");
            lstProductRecords.Columns.Add("Status");

            loadProductRecords();
        }

        public void loadProductRecords()
        {

            clsDBProductRecord dbProductRecord = new clsDBProductRecord();
            List<clsProductRecord> productRecords = dbProductRecord.ProductRecordList();

            Int32 Index = 0;
            lstProductRecords.Items.Clear();
            while (Index < productRecords.Count)
            {
                clsProductRecord productRecord = productRecords[Index];

                ListViewItem NewItem = new ListViewItem();
                NewItem.Text = productRecord.SerialNo_IMEI;
                NewItem.SubItems.Add(productRecord.SupplierName);
                NewItem.SubItems.Add(productRecord.DeviceModel);
                NewItem.SubItems.Add("£" + productRecord.Price.ToString("F"));
                NewItem.SubItems.Add(productRecord.DateBought.ToShortDateString());
                NewItem.SubItems.Add(productRecord.Description);
                NewItem.SubItems.Add(productRecord.Status);

                NewItem.Tag = productRecord;
                lstProductRecords.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstProductRecords.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstProductRecords.Items.Add(NewItem); //Add the item to ListView
               
                Index++; //move the index to the next record
            }
        }
    }
}
