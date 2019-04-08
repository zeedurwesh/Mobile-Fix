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
    public partial class frmSale : Form
    {
        string[] ImportedArray;
        int SaleID;
        public frmSale(string[] array)
        {
            InitializeComponent();
            ImportedArray = array;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they
            // want to close the  Sale form.
            if (MessageBox.Show("Do you want to exit?", "Sale",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            dateTime.Value = DateTime.Today;
            this.dateTime.Enabled = false;

            lstSale.View = View.Details;
            lstSale.Columns.Add("Serial Number/IMEI");
            lstSale.Columns.Add("Model");
            lstSale.Columns.Add("New Price");
            lstSale.Columns.Add("Description");
            //
            //
            int i = 0;
            int TotalAmount = 0;
            while( i < ImportedArray.Count())
            {
                ListViewItem NewItem = new ListViewItem();
                NewItem.Tag = ImportedArray[i];
                i++;
                NewItem.Text = ImportedArray[i].ToString();
                i++;
                NewItem.SubItems.Add(ImportedArray[i].ToString());
                i++;
                int Temp = Convert.ToInt32(ImportedArray[i]);
                TotalAmount = TotalAmount + Temp;
                NewItem.SubItems.Add(Temp.ToString());
                i++;
                NewItem.SubItems.Add(ImportedArray[i].ToString());
                i++;

                lstSale.Items.Add(NewItem); //Add the item to ListView
                lstSale.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstSale.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            txtTotalAmount.Text = TotalAmount.ToString();
            comboBoxPayment.SelectedIndex = 0;
        }

        
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtCustomerName.Text != "")
            {
                if (comboBoxPayment.SelectedIndex != -1)
                {
                    if (IsDigitsOnly(txtTotalAmount.Text))
                    {
                        MobileFixVS2015.AppCode.claDBSale sale = new MobileFixVS2015.AppCode.claDBSale();
                        SaleID = sale.AddSale(dateTime.Value.Date, comboBoxPayment.Text, Convert.ToDouble(txtTotalAmount.Text));
                        if (SaleID > 0)
                        {
                            clsDBSaleLine SaleLine = new clsDBSaleLine();
                            int Result = 0;
                            int count = lstSale.Items.Count;
                            for (int j = 0; j < count; j++)
                            {
                                int ProductID = Convert.ToInt32(lstSale.Items[j].Tag);//ID
                                double Price = Convert.ToDouble(lstSale.Items[j].SubItems[2].Text);//Price
                                string Notes = lstSale.Items[j].SubItems[3].Text;//Notes
                                //to check if all sale lines were added Successfullys
                                Result = Result + SaleLine.AddSaleLine(SaleID, ProductID, Price, Notes);
                            }
                            if (Result == 0)//All Added Successfullys
                            {
                                // Display a message box asking users if they
                                // want to Print a reciept for the added sale.
                                if (MessageBox.Show("Do you want a reciept for this sale?", " Print Reciept",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                      == DialogResult.Yes)
                                {
                                    //this code will show print preview
                                    MFPrintPreviewDialog.Document = MFPrintDocument;
                                    MFPrintPreviewDialog.ShowDialog();
                                    //this will close the sale form
                                    this.Close();
                                }
                                else
                                {
                                    //close the form
                                    this.Close();
                                }
                            }

                        }
                    }
                    else
                    {
                        labelError.Text = "Total Amount is not a valid Number";
                    }
                }
                else
                {
                    labelError.Text = "Please choose a payment Method";
                }
            }
            else
            {
                labelError.Text = "Please Enter a Customer Name";
            }

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            //this code will show print preview
            MFPrintPreviewDialog.Document = MFPrintDocument;
            MFPrintPreviewDialog.ShowDialog();
        } 

        private void MFPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //this code is to draw the layout of the reciept
            // storing logo into a variable
            Bitmap bmp = MobileFixVS2015.Properties.Resources.MobileFix_logo;
            // Saving the above varable in the Image
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 130, 50,newImage.Width,newImage.Height);

            e.Graphics.DrawString("Date: " + dateTime.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Customer Name: " + txtCustomerName.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 240));
            e.Graphics.DrawString("Sale ID: " + SaleID, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString(lblDotLine.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            e.Graphics.DrawString("Item Description", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 290));
            e.Graphics.DrawString("Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 290));
            e.Graphics.DrawString("Notes", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, 290));
            e.Graphics.DrawString(lblDotLine.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));

            // code to show data from list box goes here
            int count = lstSale.Items.Count;
            int inc = 330;
            for (int j = 0; j < count; j++)
            {
                string IMEI = lstSale.Items[j].SubItems[0].Text;//IMEI
                string Model = lstSale.Items[j].SubItems[1].Text;//Model
                e.Graphics.DrawString(IMEI + " / " + Model, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, inc));

                double Price = Convert.ToDouble(lstSale.Items[j].SubItems[2].Text);//Price
                e.Graphics.DrawString(" £ " + Price, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, inc));

                string Notes = lstSale.Items[j].SubItems[3].Text;//Notes
                e.Graphics.DrawString(Notes, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(600, inc));

                inc = inc + 20;
            }
            inc = inc + 250;
            e.Graphics.DrawString(lblDotLine.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, inc));
            inc = inc + 25;
            e.Graphics.DrawString("Total Amount:", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, inc));
            e.Graphics.DrawString("£" + txtTotalAmount.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(135, inc));
            inc = inc + 20;
            e.Graphics.DrawString("Payment Method: " + comboBoxPayment.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, inc));
            inc = inc + 5;
            e.Graphics.DrawString(lblDotLine.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, inc));
            inc = inc + 50;
            e.Graphics.DrawString("Sold by:  ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, inc));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MFPrintDocument.Print();
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

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
        }
    }
}
