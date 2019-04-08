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
    public partial class frmSalesRecord : Form
    {
        public frmSalesRecord()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalePrintPreview_Click(object sender, EventArgs e)
        {
            MFPrintPreviewDialog1.Document = MFPrintDocument1;
            MFPrintPreviewDialog1.ShowDialog();
        }

        

      

        private void MFPrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //this code is to draw the layout of the report
            // storing logo into a variable
            Bitmap bmp = MobileFixVS2015.Properties.Resources.MobileFix_logo;
            // Saving the above varable in the Image
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 130, 50, newImage.Width, newImage.Height);

            
            e.Graphics.DrawString("FROM: " + dateTime1.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString("TO: " + dateTime2.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(400, 200));
            // code for displaying data for report goes here

        }

        private void btnSalePrint_Click(object sender, EventArgs e)
        {
            MFPrintDocument1.Print();
        }
    }

}
