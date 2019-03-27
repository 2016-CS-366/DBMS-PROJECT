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

namespace ProjectA
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=dbo.ProjectA;Persist Security Info=True;User ID=sa;Password=Canser99");
        public int Std_Id{ get; set; }
        private void StudentDetail()
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from Person", con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Person Values (@FirstName,@LastName,@Email,@Contact,@DateOfBirth,@Gender)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtlastname.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                cmd.Parameters.AddWithValue("@Contact", txtcontact.Text);                
                cmd.Parameters.AddWithValue("@DateOfBirth", dtpDOB.Value);
                int gender;
                if (radioButton1.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }

                cmd.Parameters.AddWithValue("@Gender", gender);
               
                SqlCommand command = new SqlCommand("select IDENT_CURRENT('Person')", con);
                int s = Convert.ToInt32(command.ExecuteScalar());

                SqlCommand command1 = new SqlCommand("Insert into Student Values (@Id,@RegistrationNo)", con);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@Id", s);
                command1.Parameters.AddWithValue("@RegistrationNo", txtregno.Text);
                //cd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Added Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StudentDetail();
                FillGridView();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Std_Id > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete Person where Id=@ID ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.Std_Id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StudentDetail();

            }
            else
            {
                MessageBox.Show("Select a Student to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Std_Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtfirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtlastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtemail.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtcontact.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();            
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
        void FillGridView()
        {


            DataGridViewButtonColumn buttonColView = new DataGridViewButtonColumn();
            buttonColView.Name = "View";
            buttonColView.Text = "View";
            buttonColView.UseColumnTextForButtonValue = true;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                foreach (DataRow item in dtbl.Rows)
                {
                    


                    dataGridView1.Columns.Add(buttonColView);




                }

                con.Close();
                dataGridView1.DataSource = dtbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
