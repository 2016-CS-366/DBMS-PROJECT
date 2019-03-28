namespace ProjectA
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advisorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.advisorToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.groupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailToolStripMenuItem,
            this.studentDetailToolStripMenuItem1});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // advisorToolStripMenuItem
            // 
            this.advisorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advisorToolStripMenuItem1});
            this.advisorToolStripMenuItem.Name = "advisorToolStripMenuItem";
            this.advisorToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.advisorToolStripMenuItem.Text = "Advisor";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // studentDetailToolStripMenuItem
            // 
            this.studentDetailToolStripMenuItem.Name = "studentDetailToolStripMenuItem";
            this.studentDetailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentDetailToolStripMenuItem.Text = "AddStudent";
            this.studentDetailToolStripMenuItem.Click += new System.EventHandler(this.studentDetailToolStripMenuItem_Click);
            // 
            // studentDetailToolStripMenuItem1
            // 
            this.studentDetailToolStripMenuItem1.Name = "studentDetailToolStripMenuItem1";
            this.studentDetailToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.studentDetailToolStripMenuItem1.Text = "StudentDetail";
            this.studentDetailToolStripMenuItem1.Click += new System.EventHandler(this.studentDetailToolStripMenuItem1_Click);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addProjectToolStripMenuItem.Text = "AddProject";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // advisorToolStripMenuItem1
            // 
            this.advisorToolStripMenuItem1.Name = "advisorToolStripMenuItem1";
            this.advisorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.advisorToolStripMenuItem1.Text = "Advisor";
            this.advisorToolStripMenuItem1.Click += new System.EventHandler(this.advisorToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 408);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem advisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advisorToolStripMenuItem1;
    }
}

