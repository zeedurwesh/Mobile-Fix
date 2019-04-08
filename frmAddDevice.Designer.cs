namespace MobileFix
{
    partial class frmAddDevice
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
            this.lblManufacture = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtManufacture = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblManufacture
            // 
            this.lblManufacture.AutoSize = true;
            this.lblManufacture.Location = new System.Drawing.Point(18, 72);
            this.lblManufacture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufacture.Name = "lblManufacture";
            this.lblManufacture.Size = new System.Drawing.Size(99, 20);
            this.lblManufacture.TabIndex = 0;
            this.lblManufacture.Text = "Manufacture";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(18, 137);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // txtManufacture
            // 
            this.txtManufacture.Location = new System.Drawing.Point(128, 68);
            this.txtManufacture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtManufacture.Name = "txtManufacture";
            this.txtManufacture.Size = new System.Drawing.Size(148, 26);
            this.txtManufacture.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(123, 132);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(148, 26);
            this.txtModel.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 349);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 349);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(18, 403);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(149, 19);
            this.lblFooter.TabIndex = 7;
            this.lblFooter.Text = "Ease Tech ® 2017 ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(138, 203);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 26);
            this.txtID.TabIndex = 17;
            this.txtID.Visible = false;
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.AutoSize = true;
            this.txtErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.txtErrorMessage.Location = new System.Drawing.Point(72, 280);
            this.txtErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.txtErrorMessage.TabIndex = 18;
            this.txtErrorMessage.Visible = false;
            // 
            // frmAddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 438);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacture);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblManufacture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddDevice";
            this.Text = "Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManufacture;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtManufacture;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtErrorMessage;
    }
}