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
    public partial class frmDevices : Form
    {
        public frmDevices()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddDevice showForm = new frmAddDevice(this, null);
            showForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (lstDevices.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstDevices.SelectedItems[0];
                clsDevice device = (clsDevice)selectedItem.Tag;

                frmAddDevice showForm = new frmAddDevice(this, device);
                showForm.Show();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstDevices.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstDevices.SelectedItems[0];
                clsDevice device = (clsDevice)selectedItem.Tag;

                // Display a message box asking users if they
                // want to delete the selected Device.
                if (MessageBox.Show("Are you sure to Delete this Device " + device.Model + "?", "Delete Device",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.Yes)
                {
                    // code for deleting the record goes here
                    clsDBDevice dbDevice = new clsDBDevice();
                    dbDevice.DeleteDevice(device.ID);
                    loadDevices();
                }
            }
        }

        private void frmDevices_Load(object sender, EventArgs e)
        {
            lstDevices.View = View.Details;
            lstDevices.Columns.Add("Manufacturer");
            lstDevices.Columns.Add("Phone Model");

            loadDevices();
        }

        public void loadDevices()
        {
            clsDBDevice dbDevice = new clsDBDevice();
            List<clsDevice> devices = dbDevice.DeviceList();

            Int32 Index = 0;
           
            lstDevices.Items.Clear();
            while (Index < devices.Count)
            {
                clsDevice device = devices[Index];
                ListViewItem NewItem = new ListViewItem();
                NewItem.Text = device.Manufacture;
                NewItem.SubItems.Add(device.Model);
               
                NewItem.Tag = device;
                lstDevices.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstDevices.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstDevices.Items.Add(NewItem); //Add the item to ListView

                Index++; //move the index to the next record
            }
        }
    }
}
