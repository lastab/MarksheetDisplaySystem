namespace Marksheet
{
    partial class Frm_Display_Marks
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
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrecentage = new System.Windows.Forms.Label();
            this.cbRollNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarks
            // 
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(47, 118);
            this.dgvMarks.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.Size = new System.Drawing.Size(910, 244);
            this.dgvMarks.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Roll No.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Percentage:";
            // 
            // lblPrecentage
            // 
            this.lblPrecentage.AutoSize = true;
            this.lblPrecentage.Location = new System.Drawing.Point(226, 368);
            this.lblPrecentage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrecentage.Name = "lblPrecentage";
            this.lblPrecentage.Size = new System.Drawing.Size(83, 31);
            this.lblPrecentage.TabIndex = 6;
            this.lblPrecentage.Text = "100%";
            // 
            // cbRollNo
            // 
            this.cbRollNo.FormattingEnabled = true;
            this.cbRollNo.Location = new System.Drawing.Point(145, 22);
            this.cbRollNo.Name = "cbRollNo";
            this.cbRollNo.Size = new System.Drawing.Size(188, 38);
            this.cbRollNo.TabIndex = 7;
            this.cbRollNo.SelectedIndexChanged += new System.EventHandler(this.cbRollNo_SelectedIndexChanged);
            // 
            // Frm_Display_Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 431);
            this.Controls.Add(this.cbRollNo);
            this.Controls.Add(this.lblPrecentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMarks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_Display_Marks";
            this.Text = "Frm_Display_Marks";
            this.Load += new System.EventHandler(this.Frm_Display_Marks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecentage;
        private System.Windows.Forms.ComboBox cbRollNo;
    }
}