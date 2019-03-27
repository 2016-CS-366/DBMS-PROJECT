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
using System.Configuration;


namespace ProjectA
{
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=dbo.ProjectA;Persist Security Info=True;User ID=sa;Password=Canser99");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sqlCmd4 = new SqlCommand("select Id from Project where Title='" + textBox2.Text + "'", con);
                int input = Convert.ToInt32(sqlCmd4.ExecuteScalar());
                SqlCommand sqlCmd5 = new SqlCommand("SELECT Id FROM  Lookup WHERE Value ='" + textBox1.Text + "'", con);
                int input1 = Convert.ToInt32(sqlCmd5.ExecuteScalar());
                SqlCommand sqlCmd3 = new SqlCommand("SELECT COUNT(ProjectAdvisor.AdvisorId) FROM  ProjectAdvisor  WHERE  ProjectAdvisor.ProjectId='" + input + "' AND ProjectAdvisor.AdvisorId='" + input1 + "' ", con);
                int count = Convert.ToInt32(sqlCmd3.ExecuteScalar());
                if (comboBox3.Text == "" && textBox2.Text == "" && textBox1.Text == "")
                {
                    label1.Text = "Advisor is required!";
                    label3.Text = "AdvisorRole is required!";
                    label2.Text = "Project is required!";

                }
                else if (count > 0)
                {
                    label1.Text = "Already Assigned!";
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        label1.Text = "Advisor is required!";
                    }
                    if (textBox2.Text == "")
                    {
                        label2.Text = "Project is required!";
                    }
                    if (comboBox3.Text == "")
                    {
                        label3.Text = "AdvisorRole is required!";
                    }

                }
                if (textBox1.Text != "" && textBox2.Text != "" && comboBox3.Text != "" && count == 0)
                {
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO ProjectAdvisor(AdvisorId,ProjectId,AdvisorRole,AssignmentDate) " +
                        "VALUES((SELECT Id From Lookup WHERE  Value ='" + textBox1.Text + "')," +
                        " (SELECT Id From Project WHERE  Title ='" + textBox2.Text + "')," +
                        "(SELECT Id From Lookup WHERE  Lookup.Value ='" + comboBox3.Text + "')," +
                        "'" + Convert.ToDateTime(dtp.Text) + "')", con);

                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Advisor has been Assigned");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Advisor_Load(object sender, EventArgs e)
        {

        }
    }
}
