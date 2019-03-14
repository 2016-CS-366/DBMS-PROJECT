namespace ProjectA
{
    partial class HomePage
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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluationIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentCrudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.instructorToolStripMenuItem,
            this.evaluationToolStripMenuItem,
            this.evaluationIndividualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentCrudToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.instructorToolStripMenuItem.Text = "Instructor";
            // 
            // evaluationToolStripMenuItem
            // 
            this.evaluationToolStripMenuItem.Name = "evaluationToolStripMenuItem";
            this.evaluationToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.evaluationToolStripMenuItem.Text = "Evaluation";
            // 
            // evaluationIndividualToolStripMenuItem
            // 
            this.evaluationIndividualToolStripMenuItem.Name = "evaluationIndividualToolStripMenuItem";
            this.evaluationIndividualToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.evaluationIndividualToolStripMenuItem.Text = "Evaluation Individual";
            // 
            // studentCrudToolStripMenuItem
            // 
            this.studentCrudToolStripMenuItem.Name = "studentCrudToolStripMenuItem";
            this.studentCrudToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.studentCrudToolStripMenuItem.Text = "StudentCrud";
            this.studentCrudToolStripMenuItem.Click += new System.EventHandler(this.studentCrudToolStripMenuItem_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluationIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentCrudToolStripMenuItem;
    }
}