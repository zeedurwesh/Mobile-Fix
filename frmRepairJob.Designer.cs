namespace MobileFix
{
    partial class frmRepairJob
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAllRepairJobs = new System.Windows.Forms.Label();
            this.lstRepairJobs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.Location = new System.Drawing.Point(8, 443);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(98, 14);
            this.lblFooter.TabIndex = 14;
            this.lblFooter.Text = "Ease Tech ® 2017 ";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnClose.Location = new System.Drawing.Point(546, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(465, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(384, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(303, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAllRepairJobs
            // 
            this.lblAllRepairJobs.AutoSize = true;
            this.lblAllRepairJobs.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllRepairJobs.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAllRepairJobs.Location = new System.Drawing.Point(211, 19);
            this.lblAllRepairJobs.Name = "lblAllRepairJobs";
            this.lblAllRepairJobs.Size = new System.Drawing.Size(150, 29);
            this.lblAllRepairJobs.TabIndex = 8;
            this.lblAllRepairJobs.Text = "Repair Jobs";
            // 
            // lstRepairJobs
            // 
            this.lstRepairJobs.FullRowSelect = true;
            this.lstRepairJobs.Location = new System.Drawing.Point(11, 82);
            this.lstRepairJobs.MultiSelect = false;
            this.lstRepairJobs.Name = "lstRepairJobs";
            this.lstRepairJobs.Size = new System.Drawing.Size(658, 231);
            this.lstRepairJobs.TabIndex = 20;
            this.lstRepairJobs.UseCompatibleStateImageBehavior = false;
           
            // 
            // frmRepairJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 466);
            this.Controls.Add(this.lstRepairJobs);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAllRepairJobs);
            this.Name = "frmRepairJob";
            this.Text = "frmRepairJob";
            this.Load += new System.EventHandler(this.frmRepairJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAllRepairJobs;
        private System.Windows.Forms.ListView lstRepairJobs;
    }
}