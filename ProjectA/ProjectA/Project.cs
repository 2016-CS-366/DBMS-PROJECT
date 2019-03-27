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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=dbo.ProjectA;Persist Security Info=True;User ID=sa;Password=Canser99");
        void FillGridView()
        {


            DataGridViewButtonColumn buttonColView = new DataGridViewButtonColumn();
            buttonColView.Name = "View";
            buttonColView.Text = "View";
            buttonColView.UseColumnTextForButtonValue = true;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(" SELECT Project.Id,Project.Description,Project.Title FROM Project", con);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                foreach (DataRow item in dtbl.Rows)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.Columns[0].Name = "Id";
                    dataGridView1.Columns[0].HeaderText = "Id";
                    dataGridView1.Columns[0].DataPropertyName = "Id";
                    dataGridView1.Columns[0].Visible = false;

                    dataGridView1.Columns[1].Name = "Description";
                    dataGridView1.Columns[1].HeaderText = "Description";
                    dataGridView1.Columns[1].DataPropertyName = "Description";



                    dataGridView1.Columns[2].Name = "Title";
                    dataGridView1.Columns[2].HeaderText = "Title";
                    dataGridView1.Columns[2].DataPropertyName = "Title";


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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(Project.Id) FROM Project  WHERE  Description='" + comboBox1.Text + "'", con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (textBox1.Text == "" && comboBox1.Text == "" )
                {
                    label1.Text =  "Title is required!";
                    label2.Text = "Description is required!";

                }
                else if (count > 0)
                {
                    label1.Text = "Already Exist!";
                }

                else
                {
                    if (textBox1.Text == "")
                    {
                        label2.Text = "Description is required!";
                    }
                    if (comboBox1.Text == "")
                    {
                        label1.Text = "Title is required!";
                    }

                }
                if (textBox1.Text != "" && comboBox1.Text != "" && count == 0)
                {
                    SqlCommand sqlCmd1 = new SqlCommand("INSERT INTO Project(Description,Title) VALUES('" + textBox1.Text + "','" + comboBox1.Text + "')", con);

                    sqlCmd1.ExecuteNonQuery();
                    MessageBox.Show("Project has been Added");
                    



                }
                con.Close();
                dataGridView1.DataSource = null;
                FillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Project_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                
                if (e.ColumnIndex == 2 && e.RowIndex == index)
                {
                    textBox1.Text = selectedRow.Cells[0].Value.ToString();
                    comboBox1.Text = selectedRow.Cells[1].Value.ToString();
                    


                    label1.Text = "*";
                    label2.Text = "*";
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row);
        }
    }
}
