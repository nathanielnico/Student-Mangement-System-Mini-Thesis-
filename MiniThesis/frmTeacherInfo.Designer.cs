namespace MiniThesis
{
    partial class frmTeacherInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tmname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tlname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tcnumber = new System.Windows.Forms.TextBox();
            this.btn_tEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Info:";
            // 
            // txt
            // 
            this.txt.Enabled = false;
            this.txt.Location = new System.Drawing.Point(146, 36);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(225, 20);
            this.txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Middle Name:";
            // 
            // txt_tmname
            // 
            this.txt_tmname.Enabled = false;
            this.txt_tmname.Location = new System.Drawing.Point(146, 62);
            this.txt_tmname.Name = "txt_tmname";
            this.txt_tmname.Size = new System.Drawing.Size(225, 20);
            this.txt_tmname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_tlname
            // 
            this.txt_tlname.Enabled = false;
            this.txt_tlname.Location = new System.Drawing.Point(146, 88);
            this.txt_tlname.Name = "txt_tlname";
            this.txt_tlname.Size = new System.Drawing.Size(225, 20);
            this.txt_tlname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact #:";
            // 
            // txt_tcnumber
            // 
            this.txt_tcnumber.Enabled = false;
            this.txt_tcnumber.Location = new System.Drawing.Point(146, 114);
            this.txt_tcnumber.Name = "txt_tcnumber";
            this.txt_tcnumber.Size = new System.Drawing.Size(225, 20);
            this.txt_tcnumber.TabIndex = 7;
            // 
            // btn_tEdit
            // 
            this.btn_tEdit.Location = new System.Drawing.Point(296, 140);
            this.btn_tEdit.Name = "btn_tEdit";
            this.btn_tEdit.Size = new System.Drawing.Size(75, 23);
            this.btn_tEdit.TabIndex = 9;
            this.btn_tEdit.Text = "Edit";
            this.btn_tEdit.UseVisualStyleBackColor = true;
            // 
            // frmTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 182);
            this.Controls.Add(this.btn_tEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tcnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tlname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_tmname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Name = "frmTeacherInfo";
            this.Text = "frmTeacherInfo";
            this.Load += new System.EventHandler(this.frmTeacherInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tmname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tlname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tcnumber;
        private System.Windows.Forms.Button btn_tEdit;
    }
}