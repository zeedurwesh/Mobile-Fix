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
    public partial class frmAddProductRecord : Form
    {
        frmProductRecords frmListProductRecord;
        public frmAddProductRecord(frmProductRecords frmSup, clsProductRecord productRecord)
        {
            InitializeComponent();
            frmListProductRecord = frmSup;

            if (productRecord != null)
            {
                txtID.Text = Convert.ToString(productRecord.ID);
                txtSerialNo_IMEI.Text = productRecord.SerialNo_IMEI;
                cmbSupplierName.SelectedItem = productRecord.SupplierId;
                cmbDeviceName.SelectedItem = productRecord.DeviceId;
                txtPrice.Text = productRecord.Price.ToString("F");
                dateTimePicker1.Value = productRecord.DateBought;
                txtDescription.Text = productRecord.Description;
                txtStatus.Text = productRecord.Status;
                chkReturned.Checked = productRecord.Returned;
                                               
                btnAdd.Text = "Edit";

            }
            loadDevices(productRecord);
            loadSuppliers(productRecord);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                clsProductRecord productRecord = new clsProductRecord();
                productRecord.SerialNo_IMEI = txtSerialNo_IMEI.Text;
                clsDevice clsDevice = (clsDevice)cmbDeviceName.SelectedItem;
                if (clsDevice != null)
                {
                    productRecord.DeviceId = clsDevice.ID;
                }

                clsSupplier clsSupplier = (clsSupplier)cmbSupplierName.SelectedItem;
                if (clsSupplier != null)
                {
                    productRecord.SupplierId = clsSupplier.ID;
                }

                productRecord.Price = Convert.ToDecimal(txtPrice.Text);
                productRecord.DateBought = dateTimePicker1.Value;
                productRecord.Description = txtDescription.Text;
                productRecord.Status = txtStatus.Text;
                productRecord.Returned = chkReturned.Checked;

                clsDBProductRecord fbs = new clsDBProductRecord();
                Int32 added = 0;
                if (txtID.Text.Length > 0)
                {
                    productRecord.ID = Convert.ToInt32(txtID.Text);
                    added = fbs.UpdateProductRecord(productRecord);
                }
                else
                {
                    added = fbs.InsertProductRecord(productRecord);
                }

                if (added > 0)
                {
                    frmListProductRecord.loadProductRecords();
                    Close();
                }
                else
                {
                    txtErrorMessage.Text = "Could not added ProductRecord.";
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

            txtSerialNo_IMEI.BackColor = SystemColors.Control;
            cmbSupplierName.BackColor = SystemColors.Control;
            cmbDeviceName.BackColor = SystemColors.Control;
            txtPrice.BackColor = SystemColors.Control;
            txtDescription.BackColor = SystemColors.Control;
            txtStatus.BackColor = SystemColors.Control;

            Boolean isValid = true;
            if (txtSerialNo_IMEI.Text.Length == 0)
            {
                isValid = false;
                txtSerialNo_IMEI.BackColor = Color.Red;
            }
            if (cmbSupplierName.Text.Length == 0)
            {
                isValid = false;
                cmbSupplierName.BackColor = Color.Red;
            }
            if (cmbDeviceName.Text.Length == 0)
            {
                isValid = false;
                cmbDeviceName.BackColor = Color.Red;
            }
            if (isValidDecimal(txtPrice.Text) == false)
            {
                isValid = false;
                txtPrice.BackColor = Color.Red;
            }
            if (txtDescription.Text.Length == 0)
            {
                isValid = false;
                txtDescription.BackColor = Color.Red;
            }
            if (IsDigitsOnly(txtStatus.Text) == false)
            {
                isValid = false;
                txtStatus.BackColor = Color.Red;
            }

            return isValid;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
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
        public void loadDevices(clsProductRecord productRecord)
        {
            clsDBDevice dbDevice = new clsDBDevice();
            List<clsDevice> devices = dbDevice.DeviceList();

            Int32 Index = 0;
            cmbDeviceName.DisplayMember = "Model";
            cmbDeviceName.ValueMember = "ID";
            while (Index < devices.Count)
            {
                clsDevice device = devices[Index];
                cmbDeviceName.Items.Add(device);
                if (productRecord != null && (productRecord.DeviceId == device.ID))
                {
                    cmbDeviceName.SelectedItem = device;
                }


                Index++; //move the index to the next record
            }
        }

        public void loadSuppliers(clsProductRecord productRecord)
        {
            clsDBSupplier dbSupplier = new clsDBSupplier();
            List<clsSupplier> suppliers = dbSupplier.SupplierList();

            Int32 Index = 0;
            cmbSupplierName.DisplayMember = "Name";
            cmbSupplierName.ValueMember = "ID";
            cmbSupplierName.Items.Clear();
            while (Index < suppliers.Count)
            {
                clsSupplier supplier = suppliers[Index];
                cmbSupplierName.Items.Add(supplier); //add the supplier to the list
                if (productRecord != null && (productRecord.SupplierId == supplier.ID))
                {
                    cmbSupplierName.SelectedItem = supplier;
                }

                Index++; //move the index to the next record
            }
        }
    }
}
