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
    public partial class frmAddSupplier : Form
    {
        frmSupplier frmListSupplier;
        public frmAddSupplier(frmSupplier frmSup, clsSupplier supplier)
        {
            InitializeComponent();
            frmListSupplier = frmSup;

            if (supplier != null)
            {
                txtID.Text = Convert.ToString(supplier.ID);
                txtSupplierName.Text = supplier.Name;
                txtAddress.Text = supplier.Address;
                txtTown.Text = supplier.Town;
                txtPostCode.Text = supplier.Postcode;
                txtContactName.Text= supplier.ContactName;
                txtContactNo.Text= supplier.ContactNumber;

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
                clsSupplier supplier = new clsSupplier();
                supplier.Name = txtSupplierName.Text;
                supplier.Address = txtAddress.Text;
                supplier.Town = txtTown.Text;
                supplier.Postcode = txtPostCode.Text;
                supplier.ContactName = txtContactName.Text;
                supplier.ContactNumber = txtContactNo.Text;

                clsDBSupplier fbs = new clsDBSupplier();
                Int32 added = 0;
                if (txtID.Text.Length > 0)
                {
                    supplier.ID = Convert.ToInt32(txtID.Text);
                    added = fbs.UpdateSupplier(supplier);
                }
                else
                {
                    added = fbs.InsertSupplier(supplier);
                }

                if (added > 0)
                {
                    frmListSupplier.loadSuppliers();
                    Close();
                }
                else
                {
                    txtErrorMessage.Text = "Could not added Supplier.";
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
            txtSupplierName.BackColor = SystemColors.Control;
            txtAddress.BackColor = SystemColors.Control;
            txtTown.BackColor = SystemColors.Control;
            txtPostCode.BackColor = SystemColors.Control;
            txtContactName.BackColor = SystemColors.Control;
            txtContactNo.BackColor = SystemColors.Control;
          
            Boolean isValid = true;
            if (txtSupplierName.Text.Length == 0)
            {
                isValid = false;
                txtSupplierName.BackColor = Color.Red;
            }
            if (txtAddress.Text.Length == 0)
            {
                isValid = false;
                txtAddress.BackColor = Color.Red;
            }
            if (txtTown.Text.Length == 0)
            {
                isValid = false;
                txtTown.BackColor = Color.Red;
            }
            if (txtPostCode.Text.Length == 0)
            {
                isValid = false;
                txtPostCode.BackColor = Color.Red;
            }
            if (txtContactName.Text.Length == 0)
            {
                isValid = false;
                txtContactName.BackColor = Color.Red;
            }
            if (txtContactNo.Text.Length == 0)
            {
                isValid = false;
                txtContactNo.BackColor = Color.Red;
            }
         
            return isValid;
        }
        private void frmAddSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
