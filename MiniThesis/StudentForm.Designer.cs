namespace MiniThesis
{
    partial class StudentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkGradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClassInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeacherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscelleneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loToolStripMenuItem,
            this.studentToolsToolStripMenuItem,
            this.miscelleneousToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loToolStripMenuItem
            // 
            this.loToolStripMenuItem.Name = "loToolStripMenuItem";
            this.loToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loToolStripMenuItem.Text = "File";
            // 
            // studentToolsToolStripMenuItem
            // 
            this.studentToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkGradeToolStripMenuItem,
            this.viewClassInfoToolStripMenuItem,
            this.viewTeacherInfoToolStripMenuItem,
            this.enrollementToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.studentToolsToolStripMenuItem.Name = "studentToolsToolStripMenuItem";
            this.studentToolsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.studentToolsToolStripMenuItem.Text = "Student Tools";
            // 
            // checkGradeToolStripMenuItem
            // 
            this.checkGradeToolStripMenuItem.Name = "checkGradeToolStripMenuItem";
            this.checkGradeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.checkGradeToolStripMenuItem.Text = "Check Grade";
            // 
            // viewClassInfoToolStripMenuItem
            // 
            this.viewClassInfoToolStripMenuItem.Name = "viewClassInfoToolStripMenuItem";
            this.viewClassInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewClassInfoToolStripMenuItem.Text = "View Class Info";
            // 
            // viewTeacherInfoToolStripMenuItem
            // 
            this.viewTeacherInfoToolStripMenuItem.Name = "viewTeacherInfoToolStripMenuItem";
            this.viewTeacherInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewTeacherInfoToolStripMenuItem.Text = "View Teacher Info";
            // 
            // enrollementToolStripMenuItem
            // 
            this.enrollementToolStripMenuItem.Name = "enrollementToolStripMenuItem";
            this.enrollementToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.enrollementToolStripMenuItem.Text = "Enrollement";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // miscelleneousToolStripMenuItem
            // 
            this.miscelleneousToolStripMenuItem.Name = "miscelleneousToolStripMenuItem";
            this.miscelleneousToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.miscelleneousToolStripMenuItem.Text = "Miscelleneous";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 460);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkGradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClassInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTeacherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscelleneousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}