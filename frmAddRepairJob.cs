using MobileFixVS2015;
using MobileFixVS2015.AppCode;
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
    public partial class frmAddRepairJob : Form
    {
        frmRepairJob frmListRepair;
        public frmAddRepairJob(frmRepairJob frmRep, clsRepair repair)
        {
            InitializeComponent();
            frmListRepair = frmRep;
            if (repair != null)
            {
                txtID.Text = Convert.ToString(repair.ID);
                txtCustomerName.Text = repair.CustomerName;
                txtCustomerPhoneNo.Text = repair.CustomerPhoneNo;
                dateTime.Value = repair.Date;
                txtSerialNo_IMEI.Text = repair.SerialNo_IMEI;
                txtFault.Text = repair.Fault;
                txtPassword.Text = repair.Password;
                txtCost.Text = repair.Cost.ToString("F");
                txtDeposit.Text = repair.Deposit.ToString("F");
                txtBalance.Text = repair.Balance.ToString("F");
                dateTimePicker1.Value = repair.CollectionDate;
                txtComment.Text = repair.Comment;

                btnAdd.Text = "Edit";

            }
            loadDevices(repair);
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                clsRepair repair = new clsRepair();
                repair.CustomerName = txtCustomerName.Text;
                repair.CustomerPhoneNo = txtCustomerPhoneNo.Text;
                repair.Date = dateTime.Value;
                clsDevice clsDevice = (clsDevice)cmbPhoneModel.SelectedItem;
                if (clsDevice != null)
                {
                    repair.PhoneModel = clsDevice.Model.ToString();
                }
                repair.SerialNo_IMEI = txtSerialNo_IMEI.Text;
                repair.Fault = txtFault.Text;
                repair.Password = txtPassword.Text;
                repair.Cost = Convert.ToDecimal(txtCost.Text);
                repair.Deposit = Convert.ToDecimal(txtDeposit.Text);
                repair.Balance = Convert.ToDecimal(txtBalance.Text);
                repair.CollectionDate = dateTimePicker1.Value;
                repair.Comment = txtComment.Text;

                clsDBRepair fbs = new clsDBRepair();
                Int32 added = 0;
                if (txtID.Text.Length > 0)
                {
                    repair.ID = Convert.ToInt32(txtID.Text);
                    added = fbs.UpdateRepair(repair);
                }
                else
                {
                    added = fbs.InsertRepair(repair);
                }

                if (added > 0)
                {
                    frmListRepair.loadRepairs();
                    Close();
                }
                else
                {
                    txtErrorMessage.Text = "Could not added Repair.";
                    txtErrorMessage.Visible = true;
                }
            }
            else
            {
                txtErrorMessage.Text = "Specify valid values";
                txtErrorMessage.Visible = true;
            }
        }

        public Boolean isValid()
        {
            txtSerialNo_IMEI.BackColor = SystemColors.Control;
            txtCustomerName.BackColor = SystemColors.Control;
            txtCustomerPhoneNo.BackColor = SystemColors.Control;
            cmbPhoneModel.BackColor = SystemColors.Control;
            txtFault.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
            txtCost.BackColor = SystemColors.Control;
            txtDeposit.BackColor = SystemColors.Control;
            txtBalance.BackColor = SystemColors.Control;
            txtComment.BackColor = SystemColors.Control;

            Boolean isValid = true;
            if (txtCustomerName.Text.Length == 0)
            {
                isValid = false;
                txtCustomerName.BackColor = Color.Red;
            }
            if (txtCustomerPhoneNo.Text.Length == 0)
            {
                isValid = false;
                txtCustomerPhoneNo.BackColor = Color.Red;
            }
            if (cmbPhoneModel.Text.Length == 0)
            {
                isValid = false;
                cmbPhoneModel.BackColor = Color.Red;
            }
            if (txtSerialNo_IMEI.Text.Length == 0)
            {
                isValid = false;
                txtSerialNo_IMEI.BackColor = Color.Red;
            }
            if (txtFault.Text.Length == 0)
            {
                isValid = false;
                txtFault.BackColor = Color.Red;
            }
            if (txtPassword.Text.Length == 0)
            {
                isValid = false;
                txtPassword.BackColor = Color.Red;
            }

            if (isValidDecimal(txtCost.Text) == false)
            {
                isValid = false;
                txtCost.BackColor = Color.Red;
            }
            if (isValidDecimal(txtDeposit.Text) == false)
            {
                isValid = false;
                txtDeposit.BackColor = Color.Red;
            }
            if (isValidDecimal(txtBalance.Text) ==false)
            {
                isValid = false;
                txtBalance.BackColor = Color.Red;
            }

            if (txtComment.Text.Length == 0)
            {
                isValid = false;
                txtComment.BackColor = Color.Red;
            }
            return isValid;
        }

        private bool isValidDecimal(string value)
        {
            bool isValid = false;
            try
            {
                decimal number = Convert.ToDecimal(value);
                isValid = true;
            }
            catch (Exception ex)
            {
                isValid = false;
            }
            return isValid;

        }

        public void loadDevices(clsRepair repair)
        {
            clsDBDevice dbDevice = new clsDBDevice();
            List<clsDevice> devices = dbDevice.DeviceList();

            Int32 Index = 0;
            cmbPhoneModel.DisplayMember = "Model";
            cmbPhoneModel.ValueMember = "ID";
            while (Index < devices.Count)
            {
                clsDevice device = devices[Index];
                cmbPhoneModel.Items.Add(device);
                if (repair != null && (repair.PhoneModel == device.Model.ToString()))
                {
                    cmbPhoneModel.SelectedItem = device;
                }
                  Index++; //move the index to the next record
            }
        }

    }
}
