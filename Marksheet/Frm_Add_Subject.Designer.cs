namespace Marksheet
{
    partial class frm_Add_Subjects
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCreditHour = new System.Windows.Forms.ComboBox();
            this.cboHasPractical = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvSubjectDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Code";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectCode.Location = new System.Drawing.Point(217, 66);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(153, 38);
            this.txtSubjectCode.TabIndex = 1;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.Location = new System.Drawing.Point(217, 111);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(255, 38);
            this.txtSubjectName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credit Hour";
            // 
            // cbCreditHour
            // 
            this.cbCreditHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCreditHour.FormattingEnabled = true;
            this.cbCreditHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbCreditHour.Location = new System.Drawing.Point(216, 155);
            this.cbCreditHour.Name = "cbCreditHour";
            this.cbCreditHour.Size = new System.Drawing.Size(48, 39);
            this.cbCreditHour.TabIndex = 6;
            this.cbCreditHour.Text = "2";
            // 
            // cboHasPractical
            // 
            this.cboHasPractical.AutoSize = true;
            this.cboHasPractical.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHasPractical.Location = new System.Drawing.Point(53, 200);
            this.cboHasPractical.Name = "cboHasPractical";
            this.cboHasPractical.Size = new System.Drawing.Size(194, 35);
            this.cboHasPractical.TabIndex = 7;
            this.cboHasPractical.Text = "Has Practical";
            this.cboHasPractical.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(66, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Subject Details";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvSubjectDetails
            // 
            this.dgvSubjectDetails.AllowUserToAddRows = false;
            this.dgvSubjectDetails.AllowUserToDeleteRows = false;
            this.dgvSubjectDetails.AllowUserToOrderColumns = true;
            this.dgvSubjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectDetails.Location = new System.Drawing.Point(497, 12);
            this.dgvSubjectDetails.Name = "dgvSubjectDetails";
            this.dgvSubjectDetails.ReadOnly = true;
            this.dgvSubjectDetails.Size = new System.Drawing.Size(492, 318);
            this.dgvSubjectDetails.TabIndex = 11;
            // 
            // frm_Add_Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 358);
            this.Controls.Add(this.dgvSubjectDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboHasPractical);
            this.Controls.Add(this.cbCreditHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.label1);
            this.Name = "frm_Add_Subjects";
            this.Text = "Marksheet: Enter Subject Details";
            this.Load += new System.EventHandler(this.frm_Add_Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCreditHour;
        private System.Windows.Forms.CheckBox cboHasPractical;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvSubjectDetails;
    }
}