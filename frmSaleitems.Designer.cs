namespace MobileFix
{
    partial class frmSaleItems
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
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblImeiNO = new System.Windows.Forms.Label();
            this.txtImeiNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstViewSaleItems = new System.Windows.Forms.ListView();
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblSaleItems = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSaleSearch = new System.Windows.Forms.ListView();
            this.labelFinalError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(18, 631);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(149, 19);
            this.lblFooter.TabIndex = 7;
            this.lblFooter.Text = "Ease Tech ® 2017 ";
            // 
            // lblImeiNO
            // 
            this.lblImeiNO.AutoSize = true;
            this.lblImeiNO.Location = new System.Drawing.Point(74, 66);
            this.lblImeiNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImeiNO.Name = "lblImeiNO";
            this.lblImeiNO.Size = new System.Drawing.Size(75, 20);
            this.lblImeiNO.TabIndex = 8;
            this.lblImeiNO.Text = "IMEI_NO";
            // 
            // txtImeiNo
            // 
            this.txtImeiNo.Location = new System.Drawing.Point(178, 62);
            this.txtImeiNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImeiNo.Name = "txtImeiNo";
            this.txtImeiNo.Size = new System.Drawing.Size(211, 26);
            this.txtImeiNo.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(424, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(74, 413);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(74, 456);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(43, 20);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Note";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(178, 408);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 26);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(178, 451);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(314, 119);
            this.rtbNote.TabIndex = 3;
            this.rtbNote.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(382, 574);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(917, 574);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstViewSaleItems
            // 
            this.lstViewSaleItems.Location = new System.Drawing.Point(643, 102);
            this.lstViewSaleItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstViewSaleItems.MultiSelect = false;
            this.lstViewSaleItems.Name = "lstViewSaleItems";
            this.lstViewSaleItems.Size = new System.Drawing.Size(551, 282);
            this.lstViewSaleItems.TabIndex = 18;
            this.lstViewSaleItems.UseCompatibleStateImageBehavior = false;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(1038, 574);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(152, 35);
            this.btnProceed.TabIndex = 6;
            this.btnProceed.Text = "Proceed Sale";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblSaleItems
            // 
            this.lblSaleItems.AutoSize = true;
            this.lblSaleItems.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleItems.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSaleItems.Location = new System.Drawing.Point(505, 14);
            this.lblSaleItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaleItems.Name = "lblSaleItems";
            this.lblSaleItems.Size = new System.Drawing.Size(196, 43);
            this.lblSaleItems.TabIndex = 28;
            this.lblSaleItems.Text = "Sale Items";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(27, 426);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "£";
            // 
            // listViewSaleSearch
            // 
            this.listViewSaleSearch.FullRowSelect = true;
            this.listViewSaleSearch.HideSelection = false;
            this.listViewSaleSearch.Location = new System.Drawing.Point(27, 102);
            this.listViewSaleSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewSaleSearch.Name = "listViewSaleSearch";
            this.listViewSaleSearch.Size = new System.Drawing.Size(584, 282);
            this.listViewSaleSearch.TabIndex = 31;
            this.listViewSaleSearch.UseCompatibleStateImageBehavior = false;
            this.listViewSaleSearch.SelectedIndexChanged += new System.EventHandler(this.listViewSaleSearch_SelectedIndexChanged);
            // 
            // labelFinalError
            // 
            this.labelFinalError.AutoSize = true;
            this.labelFinalError.Location = new System.Drawing.Point(585, 434);
            this.labelFinalError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFinalError.Name = "labelFinalError";
            this.labelFinalError.Size = new System.Drawing.Size(0, 20);
            this.labelFinalError.TabIndex = 32;
            // 
            // frmSaleItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 657);
            this.Controls.Add(this.labelFinalError);
            this.Controls.Add(this.listViewSaleSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.lblSaleItems);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lstViewSaleItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtbNote);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtImeiNo);
            this.Controls.Add(this.lblImeiNO);
            this.Controls.Add(this.lblFooter);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSaleItems";
            this.Text = "Sale Items";
            this.Load += new System.EventHandler(this.frmSaleItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblImeiNO;
        private System.Windows.Forms.TextBox txtImeiNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lstViewSaleItems;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblSaleItems;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSaleSearch;
        private System.Windows.Forms.Label labelFinalError;
    }
}