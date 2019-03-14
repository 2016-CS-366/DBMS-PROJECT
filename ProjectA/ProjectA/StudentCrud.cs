using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ProjectA
{
    public partial class StudentCrud : Form
    {
        private static StudentCrud l = null;
        public StudentCrud()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=dbo.ProjectA;Persist Security Info=True;User ID=sa;Password=Canser99");
        public int stdID { get; set; }
        public static StudentCrud getInstance()
        {
            if (l == null)
            {
                l = new StudentCrud();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void StudentCrud_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        private void GetStudentRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from Person", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            con.Open();
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into Person Values (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                int gndr;
                if (rdmale.Checked == true)
                {
                    gndr = 1;
                }
                else
                {
                    gndr = 2;
                }
                cmd.Parameters.AddWithValue("@Gender", gndr);


                cmd.ExecuteNonQuery();

                SqlCommand cdd = new SqlCommand("select IDENT_CURRENT('Person')", con);
                int s = Convert.ToInt32(cdd.ExecuteScalar());

                SqlCommand cd = new SqlCommand("Insert into Student Values (@Id,@RegistrationNo)", con);
                cd.CommandType = CommandType.Text;
                cd.Parameters.AddWithValue("@Id", s);
                cd.Parameters.AddWithValue("@RegistrationNo", txtReg.Text);
                cd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
                ClearTextBoxs();
            }
        }
        private void ClearTextBoxs()
        {
            stdID = 0;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }
        private bool IsValid()
        {
            if (txtFirstName.Text == string.Empty)
            {
                MessageBox.Show("Student First Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Student Email is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stdID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtContact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value);
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value) == 1)
            {
                rdmale.Checked = true;
            }
            else
            {
                rdfml.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stdID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update Person SET FirstName= @FirstName,LastName=@LastName,Contact=@Contact,Email=@Email,DateOfBirth=@DateOfBirth,Gender=@Gender where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ID", this.stdID);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                int gndr;
                if (rdmale.Checked == true)
                {
                    gndr = 1;
                }
                else
                {
                    gndr = 2;
                }
                cmd.Parameters.AddWithValue("@Gender", gndr);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select a Student for updation", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (stdID > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete Person where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.stdID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
                ClearTextBoxs();
            }
            else
            {
                MessageBox.Show("Select a Student to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdfml_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtReg_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
