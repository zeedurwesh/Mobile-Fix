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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSupplier showForm = new frmAddSupplier(this, null);
            showForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (lstSupplier.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstSupplier.SelectedItems[0];
                clsSupplier supplier = (clsSupplier)selectedItem.Tag;

                frmAddSupplier showForm = new frmAddSupplier(this, supplier);
                showForm.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstSupplier.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstSupplier.SelectedItems[0];
                clsSupplier supplier = (clsSupplier)selectedItem.Tag;
                // Display a message box asking users if they
                // want to delete the selected Supplier.
                if (MessageBox.Show("Are you sure to Delete this Supplier " + supplier.Name + "?", "Delete Supplier",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                      == DialogResult.Yes)
                {
                    // code for deleting the record goes here
                    clsDBSupplier dbSupplier = new clsDBSupplier();
                    dbSupplier.DeleteSupplier(supplier.ID);
                    loadSuppliers();
                }
            }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
    
            lstSupplier.View = View.Details;
            lstSupplier.Columns.Add("Name");
            lstSupplier.Columns.Add("Address");
            lstSupplier.Columns.Add("Town");
            lstSupplier.Columns.Add("Postcode");
            lstSupplier.Columns.Add("Contact Name");
            lstSupplier.Columns.Add("Contact Number");
          
            loadSuppliers();
        }

        public void loadSuppliers()
        {
            clsDBSupplier dbSupplier = new clsDBSupplier();
            List<clsSupplier> suppliers = dbSupplier.SupplierList();

            Int32 Index = 0;
            
            lstSupplier.Items.Clear();
            while (Index < suppliers.Count)
            {
                clsSupplier supplier = suppliers[Index];

                ListViewItem NewItem = new ListViewItem();
                NewItem.Text = supplier.Name;
                NewItem.SubItems.Add(supplier.Address);
                NewItem.SubItems.Add(supplier.Town);
                NewItem.SubItems.Add(supplier.Postcode);
                NewItem.SubItems.Add(supplier.ContactName);
                NewItem.SubItems.Add(supplier.ContactNumber);
              
                NewItem.Tag = supplier;
                lstSupplier.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstSupplier.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                lstSupplier.Items.Add(NewItem); //Add the item to ListView

                Index++; //move the index to the next record
            }
        }
    }
}
