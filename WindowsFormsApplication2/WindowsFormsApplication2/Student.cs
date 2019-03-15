using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            StudentCrud p = new StudentCrud();
            p.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Advisor a =new Advisor();
            a.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Project p= new Project();
           p.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();

        }
    }
}
