namespace Marksheet
{
    partial class Frm_Menu
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnEnterMarks = new System.Windows.Forms.Button();
            this.btnSeeMarks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(71, 88);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(132, 53);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Students";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.Location = new System.Drawing.Point(71, 147);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(132, 55);
            this.btnAddSubject.TabIndex = 1;
            this.btnAddSubject.Text = "Add Subjects";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnEnterMarks
            // 
            this.btnEnterMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterMarks.Location = new System.Drawing.Point(71, 208);
            this.btnEnterMarks.Name = "btnEnterMarks";
            this.btnEnterMarks.Size = new System.Drawing.Size(132, 48);
            this.btnEnterMarks.TabIndex = 2;
            this.btnEnterMarks.Text = "Enter Marks";
            this.btnEnterMarks.UseVisualStyleBackColor = true;
            this.btnEnterMarks.Click += new System.EventHandler(this.btnEnterMarks_Click);
            // 
            // btnSeeMarks
            // 
            this.btnSeeMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeMarks.Location = new System.Drawing.Point(71, 262);
            this.btnSeeMarks.Name = "btnSeeMarks";
            this.btnSeeMarks.Size = new System.Drawing.Size(132, 53);
            this.btnSeeMarks.TabIndex = 3;
            this.btnSeeMarks.Text = "See Marks";
            this.btnSeeMarks.UseVisualStyleBackColor = true;
            this.btnSeeMarks.Click += new System.EventHandler(this.btnSeeMarks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeeMarks);
            this.Controls.Add(this.btnEnterMarks);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Frm_Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnEnterMarks;
        private System.Windows.Forms.Button btnSeeMarks;
        private System.Windows.Forms.Label label1;
    }
}

