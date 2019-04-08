namespace MobileFix
{
    partial class frmSalesRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesRecord));
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSale = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSalePrintPreview = new System.Windows.Forms.Button();
            this.btnSalePrint = new System.Windows.Forms.Button();
            this.MFPrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.MFPrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(48, 61);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(30, 13);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "From";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(324, 61);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(20, 13);
            this.lblDateTo.TabIndex = 1;
            this.lblDateTo.Text = "To";
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(106, 58);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(200, 20);
            this.dateTime1.TabIndex = 0;
            // 
            // dateTime2
            // 
            this.dateTime2.Location = new System.Drawing.Point(362, 58);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(200, 20);
            this.dateTime2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(62, 104);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(520, 307);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(614, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSale.Location = new System.Drawing.Point(270, 9);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(164, 29);
            this.lblSale.TabIndex = 42;
            this.lblSale.Text = "Sale Records";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(697, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSalePrintPreview
            // 
            this.btnSalePrintPreview.Image = global::MobileFixVS2015.Properties.Resources.Print_Preview;
            this.btnSalePrintPreview.Location = new System.Drawing.Point(687, 187);
            this.btnSalePrintPreview.Name = "btnSalePrintPreview";
            this.btnSalePrintPreview.Size = new System.Drawing.Size(85, 39);
            this.btnSalePrintPreview.TabIndex = 4;
            this.btnSalePrintPreview.Text = "Print Preview";
            this.btnSalePrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalePrintPreview.UseVisualStyleBackColor = true;
            this.btnSalePrintPreview.Click += new System.EventHandler(this.btnSalePrintPreview_Click);
            // 
            // btnSalePrint
            // 
            this.btnSalePrint.Image = global::MobileFixVS2015.Properties.Resources.print;
            this.btnSalePrint.Location = new System.Drawing.Point(687, 251);
            this.btnSalePrint.Name = "btnSalePrint";
            this.btnSalePrint.Size = new System.Drawing.Size(85, 39);
            this.btnSalePrint.TabIndex = 5;
            this.btnSalePrint.Text = "Print";
            this.btnSalePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalePrint.UseVisualStyleBackColor = true;
            this.btnSalePrint.Click += new System.EventHandler(this.btnSalePrint_Click);
            // 
            // MFPrintDocument1
            // 
            this.MFPrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MFPrintDocument1_PrintPage);
            // 
            // MFPrintPreviewDialog1
            // 
            this.MFPrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.MFPrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.MFPrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.MFPrintPreviewDialog1.Enabled = true;
            this.MFPrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("MFPrintPreviewDialog1.Icon")));
            this.MFPrintPreviewDialog1.Name = "printPreviewDialogSaleReport";
            this.MFPrintPreviewDialog1.Visible = false;
            // 
            // frmSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 471);
            this.Controls.Add(this.btnSalePrint);
            this.Controls.Add(this.btnSalePrintPreview);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Name = "frmSalesRecord";
            this.Text = "frmSalesRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSalePrintPreview;
        private System.Windows.Forms.Button btnSalePrint;
        private System.Drawing.Printing.PrintDocument MFPrintDocument1;
        private System.Windows.Forms.PrintPreviewDialog MFPrintPreviewDialog1;
    }
}