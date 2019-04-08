namespace MobileFix
{
    partial class frmAddRepairJob
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
            this.lblRepairJob = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNo = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.lblPhoneModel = new System.Windows.Forms.Label();
            this.lblSerialN0_IMEI = new System.Windows.Forms.Label();
            this.txtSerialNo_IMEI = new System.Windows.Forms.TextBox();
            this.txtFault = new System.Windows.Forms.TextBox();
            this.lblFault = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblCollectionDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbPhoneModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(3, 674);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(98, 14);
            this.lblFooter.TabIndex = 25;
            this.lblFooter.Text = "Ease Tech ® 2017 ";
            // 
            // lblRepairJob
            // 
            this.lblRepairJob.AutoSize = true;
            this.lblRepairJob.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairJob.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRepairJob.Location = new System.Drawing.Point(201, 21);
            this.lblRepairJob.Name = "lblRepairJob";
            this.lblRepairJob.Size = new System.Drawing.Size(137, 29);
            this.lblRepairJob.TabIndex = 26;
            this.lblRepairJob.Text = "Repair Job";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(411, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 516);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(83, 75);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 31;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(287, 73);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblCustomerPhoneNo
            // 
            this.lblCustomerPhoneNo.AutoSize = true;
            this.lblCustomerPhoneNo.Location = new System.Drawing.Point(84, 105);
            this.lblCustomerPhoneNo.Name = "lblCustomerPhoneNo";
            this.lblCustomerPhoneNo.Size = new System.Drawing.Size(102, 13);
            this.lblCustomerPhoneNo.TabIndex = 33;
            this.lblCustomerPhoneNo.Text = "Customer Phone No";
            // 
            // txtCustomerPhoneNo
            // 
            this.txtCustomerPhoneNo.Location = new System.Drawing.Point(287, 103);
            this.txtCustomerPhoneNo.Name = "txtCustomerPhoneNo";
            this.txtCustomerPhoneNo.Size = new System.Drawing.Size(121, 20);
            this.txtCustomerPhoneNo.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(83, 137);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 35;
            this.lblDate.Text = "Date";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(287, 133);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(132, 20);
            this.dateTime.TabIndex = 2;
            // 
            // lblPhoneModel
            // 
            this.lblPhoneModel.AutoSize = true;
            this.lblPhoneModel.Location = new System.Drawing.Point(84, 168);
            this.lblPhoneModel.Name = "lblPhoneModel";
            this.lblPhoneModel.Size = new System.Drawing.Size(70, 13);
            this.lblPhoneModel.TabIndex = 37;
            this.lblPhoneModel.Text = "Phone Model";
            // 
            // lblSerialN0_IMEI
            // 
            this.lblSerialN0_IMEI.AutoSize = true;
            this.lblSerialN0_IMEI.Location = new System.Drawing.Point(84, 195);
            this.lblSerialN0_IMEI.Name = "lblSerialN0_IMEI";
            this.lblSerialN0_IMEI.Size = new System.Drawing.Size(75, 13);
            this.lblSerialN0_IMEI.TabIndex = 38;
            this.lblSerialN0_IMEI.Text = "SerialNo_IMEI";
            // 
            // txtSerialNo_IMEI
            // 
            this.txtSerialNo_IMEI.Location = new System.Drawing.Point(287, 189);
            this.txtSerialNo_IMEI.Name = "txtSerialNo_IMEI";
            this.txtSerialNo_IMEI.Size = new System.Drawing.Size(121, 20);
            this.txtSerialNo_IMEI.TabIndex = 4;
            // 
            // txtFault
            // 
            this.txtFault.Location = new System.Drawing.Point(287, 217);
            this.txtFault.Multiline = true;
            this.txtFault.Name = "txtFault";
            this.txtFault.Size = new System.Drawing.Size(121, 36);
            this.txtFault.TabIndex = 5;
            // 
            // lblFault
            // 
            this.lblFault.AutoSize = true;
            this.lblFault.Location = new System.Drawing.Point(83, 239);
            this.lblFault.Name = "lblFault";
            this.lblFault.Size = new System.Drawing.Size(30, 13);
            this.lblFault.TabIndex = 41;
            this.lblFault.Text = "Fault";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(83, 268);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(287, 265);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(83, 295);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 44;
            this.lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(287, 293);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(121, 20);
            this.txtCost.TabIndex = 7;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(285, 325);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(121, 20);
            this.txtDeposit.TabIndex = 8;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(83, 329);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(43, 13);
            this.lblDeposit.TabIndex = 47;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(84, 361);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 48;
            this.lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(283, 357);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(121, 20);
            this.txtBalance.TabIndex = 9;
            // 
            // lblCollectionDate
            // 
            this.lblCollectionDate.AutoSize = true;
            this.lblCollectionDate.Location = new System.Drawing.Point(83, 393);
            this.lblCollectionDate.Name = "lblCollectionDate";
            this.lblCollectionDate.Size = new System.Drawing.Size(79, 13);
            this.lblCollectionDate.TabIndex = 50;
            this.lblCollectionDate.Text = "Collection Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 389);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(84, 437);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 52;
            this.lblComment.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(283, 416);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(127, 56);
            this.txtComment.TabIndex = 11;
            // 
            // cmbPhoneModel
            // 
            this.cmbPhoneModel.FormattingEnabled = true;
            this.cmbPhoneModel.Location = new System.Drawing.Point(287, 162);
            this.cmbPhoneModel.Name = "cmbPhoneModel";
            this.cmbPhoneModel.Size = new System.Drawing.Size(121, 21);
            this.cmbPhoneModel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 55;
            this.label1.Text = "Ease Tech ® 2017 ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(287, 490);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 56;
            this.txtID.Visible = false;
           
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.AutoSize = true;
            this.txtErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.txtErrorMessage.Location = new System.Drawing.Point(83, 490);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.txtErrorMessage.TabIndex = 57;
            this.txtErrorMessage.Visible = false;
            // 
            // frmAddRepairJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 553);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPhoneModel);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblCollectionDate);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblFault);
            this.Controls.Add(this.txtFault);
            this.Controls.Add(this.txtSerialNo_IMEI);
            this.Controls.Add(this.lblSerialN0_IMEI);
            this.Controls.Add(this.lblPhoneModel);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtCustomerPhoneNo);
            this.Controls.Add(this.lblCustomerPhoneNo);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRepairJob);
            this.Controls.Add(this.lblFooter);
            this.Name = "frmAddRepairJob";
            this.Text = "Repair Job";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblRepairJob;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerPhoneNo;
        private System.Windows.Forms.TextBox txtCustomerPhoneNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label lblPhoneModel;
        private System.Windows.Forms.Label lblSerialN0_IMEI;
        private System.Windows.Forms.TextBox txtSerialNo_IMEI;
        private System.Windows.Forms.TextBox txtFault;
        private System.Windows.Forms.Label lblFault;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblCollectionDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbPhoneModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtErrorMessage;
    }
}