namespace MiniThesis
{
    partial class Form1
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
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.rdo_Faculty = new System.Windows.Forms.RadioButton();
            this.rdo_Student = new System.Windows.Forms.RadioButton();
            this.rdo_Admin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(62, 43);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(175, 20);
            this.txt_Username.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(62, 69);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(175, 20);
            this.txt_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(162, 95);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdo_Faculty
            // 
            this.rdo_Faculty.AutoSize = true;
            this.rdo_Faculty.Location = new System.Drawing.Point(9, 12);
            this.rdo_Faculty.Name = "rdo_Faculty";
            this.rdo_Faculty.Size = new System.Drawing.Size(59, 17);
            this.rdo_Faculty.TabIndex = 5;
            this.rdo_Faculty.TabStop = true;
            this.rdo_Faculty.Text = "Faculty";
            this.rdo_Faculty.UseVisualStyleBackColor = true;
            // 
            // rdo_Student
            // 
            this.rdo_Student.AutoSize = true;
            this.rdo_Student.Location = new System.Drawing.Point(134, 12);
            this.rdo_Student.Name = "rdo_Student";
            this.rdo_Student.Size = new System.Drawing.Size(62, 17);
            this.rdo_Student.TabIndex = 6;
            this.rdo_Student.TabStop = true;
            this.rdo_Student.Text = "Student";
            this.rdo_Student.UseVisualStyleBackColor = true;
            // 
            // rdo_Admin
            // 
            this.rdo_Admin.AutoSize = true;
            this.rdo_Admin.Location = new System.Drawing.Point(74, 12);
            this.rdo_Admin.Name = "rdo_Admin";
            this.rdo_Admin.Size = new System.Drawing.Size(54, 17);
            this.rdo_Admin.TabIndex = 7;
            this.rdo_Admin.TabStop = true;
            this.rdo_Admin.Text = "Admin";
            this.rdo_Admin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 124);
            this.Controls.Add(this.rdo_Admin);
            this.Controls.Add(this.rdo_Student);
            this.Controls.Add(this.rdo_Faculty);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.RadioButton rdo_Faculty;
        private System.Windows.Forms.RadioButton rdo_Student;
        private System.Windows.Forms.RadioButton rdo_Admin;
    }
}

