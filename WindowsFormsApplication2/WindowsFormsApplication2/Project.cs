using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=dbo.ProjectA;Persist Security Info=True;User ID=sa;Password=Canser99");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Project(Description,Title) VALUES('" + txtdescription.Text + "','" + txttitle.Text + "')", con);

            command.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Project is Saved Successfully");
            Advisor a = new Advisor();
            a.Show();
            this.Hide();
            
        }
    }
}
