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
    public partial class StudentCrud : Form
    {
        int gender;

        public StudentCrud()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=dbo.ProjectA;Persist Security Info=True;User ID=sa;Password=Canser99");
        public int stdID
        {
            get
            {
                return this.stdID;
            }
            set
            {
                this.stdID = value;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student s = new Student();
            s.Show();
            this.Hide();
        }

        private void StudentCrud_Load(object sender, EventArgs e)
        {
            GetStudentRecord();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            con.Open();
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into Person Values (@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@Contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                
                if (radioButton1.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }
                cmd.Parameters.AddWithValue("@Gender", gender);


                //cmd.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("select IDENT_CURRENT('Person')", con);
                int s = Convert.ToInt32(command.ExecuteScalar());

                SqlCommand command1 = new SqlCommand("Insert into Student Values (@Id,@RegistrationNo)", con);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@Id", s);
                command1.Parameters.AddWithValue("@RegistrationNo", txtregno.Text);
                //cd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
                ClearData(); ;



            }
        }
        private void ClearData() 
        {
            stdID = 0;
            txtfirstname.Clear();
            txtlastname.Clear();
            txtcontact.Clear();
            txtemail.Clear();
        }
        private void GetStudentRecord()
        {

            SqlCommand command = new SqlCommand("Select * from Person", con);

            DataTable dt = new DataTable();
            con.Open();

            SqlDataReader rd = command.ExecuteReader();
            dt.Load(rd);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private bool IsValid()
        {
            if (txtfirstname.Text == string.Empty)
            {
                MessageBox.Show("Student First Name is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtemail.Text == string.Empty)
            {
                MessageBox.Show("Student Email is Required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            stdID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtfirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtlastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtcontact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dtpDOB.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value);
            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value) == 1)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (stdID > 0)
            {
                SqlCommand cmd = new SqlCommand("Edit Person SET firstname= @FirstName,lastname=@LastName,contact=@Contact,email=@Email,DOB=@DOB,Gender=@Gender where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@Contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@ID", this.stdID);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);               
                if (radioButton1.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }
                cmd.Parameters.AddWithValue("@Gender", gender);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Record is Edited.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentRecord();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select the Student record you want to Edit.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
               
            }
            else
            {
                MessageBox.Show("Select a Student to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            
            

            
            
        }
    }

