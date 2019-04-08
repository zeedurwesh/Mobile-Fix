using MobileFixVS2015;
using MobileFixVS2015.AppCode;
using System;
using System.Collections;
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
    public partial class frmSaleItems : Form
    {
        public frmSaleItems()
        {
            InitializeComponent();
        }

        // on form load
        private void frmSaleItems_Load(object sender, EventArgs e)
        {
            listViewSaleSearch.View = View.Details;
            listViewSaleSearch.Columns.Add("Serial Number/IMEI");
            listViewSaleSearch.Columns.Add("Model");
            listViewSaleSearch.Columns.Add("Price");
            listViewSaleSearch.Columns.Add("Is Returned?");
            listViewSaleSearch.Columns.Add("Date Bought");

            lstViewSaleItems.View = View.Details;
            lstViewSaleItems.Columns.Add("Serial Number/IMEI");
            lstViewSaleItems.Columns.Add("Model");
            lstViewSaleItems.Columns.Add("New Price");
            lstViewSaleItems.Columns.Add("Description");
        }

        // search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SN = txtImeiNo.Text;
            clsDBSaleSearchSP SP = new clsDBSaleSearchSP();
            List<clsSaleSearchSP> SalesList = SP.SearchList(SN);
            Int32 Index = 0;
            ArrayList SalesArray = new ArrayList();

            //lstItemDetails.Items.Clear();
            while (Index < SalesList.Count)
            {
                clsSaleSearchSP Sale = SalesList[Index];
                string IsReturned = "No";
                if (Sale.Returned)
                {
                    IsReturned = "Yes";
                }

                ListViewItem NewItem = new ListViewItem();
                NewItem.Text = Sale.SN;
                NewItem.SubItems.Add(Sale.Model);
                NewItem.SubItems.Add("£" + Sale.Price);
                NewItem.SubItems.Add(IsReturned);
                NewItem.SubItems.Add(Sale.DateBought.ToShortDateString());
                NewItem.Tag = Convert.ToInt32(Sale.ID);
                listViewSaleSearch.Items.Add(NewItem); //Add the item to ListView
                listViewSaleSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewSaleSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                Index++; //move the index to the next record
            }
            // clear data from the price and notes text boxes from any previous searches
            txtPrice.Text = "";
            rtbNote.Text = "";
        }

        //Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listViewSaleSearch.SelectedItems.Count > 0)
            {
                if (txtPrice.Text != "" & IsDigitsOnly(txtPrice.Text))
                {
                    ListViewItem temp = listViewSaleSearch.SelectedItems[0];
                    listViewSaleSearch.Items.Remove(temp);
                    ListViewItem NewItem = new ListViewItem();
                    NewItem.Text = temp.Text;
                    NewItem.SubItems.Add(temp.SubItems[1]);
                    NewItem.SubItems.Add(txtPrice.Text);
                    NewItem.SubItems.Add(rtbNote.Text);
                    NewItem.Tag = temp.Tag;
                    lstViewSaleItems.Items.Add(NewItem); //Add the item to ListView
                    lstViewSaleItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lstViewSaleItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    txtPrice.Text = "";
                    rtbNote.Text = "";

                }
                else
                {
                    labelError.Text = "Please Enter a Valid Price";
                }

            }
            else
            {
                labelError.Text = "Please Select a product form the above list";
            }

        }

        // cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they
            // want to close the Sale Item form.
            if (MessageBox.Show("Do you want to exit?", "Sale Items",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Proceed button
        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (lstViewSaleItems.Items.Count > 0)
            {
                int count = lstViewSaleItems.Items.Count;
                int temp = count * 5;
                string[] Array = new string[temp];               
                int i = 0;
                for (int j = 0; j < count; j++)
                {
                    Array[i] = lstViewSaleItems.Items[j].Tag.ToString();//ID
                    Array[i + 1] = lstViewSaleItems.Items[j].SubItems[0].Text;//SerialNo
                    Array[i + 2] = lstViewSaleItems.Items[j].SubItems[1].Text;//Model
                    Array[i + 3] = lstViewSaleItems.Items[j].SubItems[2].Text;//Price
                    Array[i + 4] = lstViewSaleItems.Items[j].SubItems[3].Text;//Notes
                    i = i+5;
                }
 
                frmSale sale = new frmSale(Array);
                sale.Show();
                this.Close();
            }
            else
            {
                labelFinalError.Text = "Please Add Products to this sale";
            }

        }

        // function to check if string is only digits
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }

        private void listViewSaleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }
    }
}
