namespace MobileFix
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.lblSale = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lstSale = new System.Windows.Forms.ListView();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.MFPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.MFPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.lblDotLine = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSale.Location = new System.Drawing.Point(297, 9);
            this.lblSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(93, 43);
            this.lblSale.TabIndex = 27;
            this.lblSale.Text = "Sale";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(56, 108);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "Date";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(116, 105);
            this.dateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(313, 26);
            this.dateTime.TabIndex = 0;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(50, 406);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(129, 20);
            this.lblPaymentMethod.TabIndex = 45;
            this.lblPaymentMethod.Text = "Payment method";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(74, 451);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(104, 20);
            this.lblTotalAmount.TabIndex = 46;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(212, 446);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(204, 26);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(430, 537);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(552, 537);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(18, 586);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(149, 19);
            this.lblFooter.TabIndex = 51;
            this.lblFooter.Text = "Ease Tech ® 2017 ";
            // 
            // lstSale
            // 
            this.lstSale.Location = new System.Drawing.Point(60, 155);
            this.lstSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSale.Name = "lstSale";
            this.lstSale.Size = new System.Drawing.Size(620, 178);
            this.lstSale.TabIndex = 52;
            this.lstSale.UseCompatibleStateImageBehavior = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(210, 358);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(204, 26);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(56, 363);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(124, 20);
            this.lblCustomerName.TabIndex = 53;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::MobileFixVS2015.Properties.Resources.print;
            this.btnPrint.Location = new System.Drawing.Point(552, 431);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 60);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Image = global::MobileFixVS2015.Properties.Resources.Print_Preview;
            this.btnPrintPreview.Location = new System.Drawing.Point(552, 358);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(128, 60);
            this.btnPrintPreview.TabIndex = 5;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // MFPrintPreviewDialog
            // 
            this.MFPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.MFPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.MFPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.MFPrintPreviewDialog.Enabled = true;
            this.MFPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("MFPrintPreviewDialog.Icon")));
            this.MFPrintPreviewDialog.Name = "MFPrintPreviewDialog";
            this.MFPrintPreviewDialog.Visible = false;
            // 
            // MFPrintDocument
            // 
            this.MFPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MFPrintDocument_PrintPage);
            // 
            // lblDotLine
            // 
            this.lblDotLine.AutoSize = true;
            this.lblDotLine.Location = new System.Drawing.Point(12, 626);
            this.lblDotLine.Name = "lblDotLine";
            this.lblDotLine.Size = new System.Drawing.Size(693, 20);
            this.lblDotLine.TabIndex = 57;
            this.lblDotLine.Text = "____________________________________________________________________________";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.comboBoxPayment.Location = new System.Drawing.Point(212, 402);
            this.comboBoxPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(204, 28);
            this.comboBoxPayment.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(188, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "£";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(188, 545);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(14, 20);
            this.labelError.TabIndex = 60;
            this.labelError.Text = "-";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(748, 611);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.lblDotLine);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lstSale);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSale);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog MFPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument MFPrintDocument;
        private System.Windows.Forms.Label lblDotLine;
        private System.Windows.Forms.ListView lstSale;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
    }
}