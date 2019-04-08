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
    public partial class frmAddDevice : Form
    {

        frmDevices frmDevices;
        public frmAddDevice(frmDevices frmSup, clsDevice device)
        {
            InitializeComponent();
            frmDevices = frmSup;

            if (device != null)
            {
                txtID.Text = Convert.ToString(device.ID);
                txtManufacture.Text = device.Manufacture;
                txtModel.Text = device.Model;

                btnAdd.Text = "Edit";
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                clsDevice device = new clsDevice();
                device.Manufacture = txtManufacture.Text;
                device.Model = txtModel.Text;

                clsDBDevice fbs = new clsDBDevice();
                Int32 added = 0;
                if (txtID.Text.Length > 0)
                {
                    device.ID = Convert.ToInt32(txtID.Text);
                    added = fbs.UpdateDevice(device);
                }
                else
                {
                    added = fbs.InsertDevice(device);
                }

                if (added > 0)
                {
                    frmDevices.loadDevices();
                    Close();
                }
                else
                {
                    txtErrorMessage.Text = "Could not added Device.";
                    txtErrorMessage.Visible = true;
                }
            }
            else
            {
                txtErrorMessage.Text = "Specify valid values";
                txtErrorMessage.Visible = true;
            }
            }

        private Boolean isValid()
        {
            txtManufacture.BackColor = SystemColors.Control;
            txtModel.BackColor = SystemColors.Control;

            Boolean isValid = true;
            if (txtManufacture.Text.Length == 0)
            {
                isValid = false;
                txtManufacture.BackColor = Color.Red;
            }
            if (txtModel.Text.Length == 0)
            {
                isValid = false;
                txtModel.BackColor = Color.Red;
            }
            return isValid;
        }
    }
    }

