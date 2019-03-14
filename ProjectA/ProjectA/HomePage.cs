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
    public partial class HomePage : Form
    {
        private static HomePage l = null;
        public HomePage()
        {
            InitializeComponent();
        }
        public static HomePage getInstance()
        {
            if (l == null)
            {
                l = new HomePage();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void addInstructorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void studentCrudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentCrud l = StudentCrud.getInstance();
            l.Show();
            this.Hide();

        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void studentCrudToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StudentCrud l = StudentCrud.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
