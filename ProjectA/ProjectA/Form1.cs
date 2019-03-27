using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void studentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent s = new AddStudent();
            s.Show();
            this.Hide();
        }

        private void studentDetailToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Show();
            this.Hide();
        }

        private void advisorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Advisor a = new Advisor();
            a.Show();
            this.Hide();
        }
    }
}
