using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ems
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int Key = 0;
        private void Reset()
        {
            SNameTb.Text = "";
            Key = 0;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\public\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void DisplaySubjects()
        {
            Con.Open();
            string Query = "Select * from SubjectTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTbl (SName) values (@Sn)", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved");
                    Con.Close();
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SubjectsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < SubjectsDGV.Rows.Count)
            {
                SNameTb.Text = SubjectsDGV.Rows[e.RowIndex].Cells["SName"].Value?.ToString();

                // Update Key variable
                if (SNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(SubjectsDGV.Rows[e.RowIndex].Cells["SId"].Value);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update SubjectTbl set SName=@Sn where SId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated");
                    Con.Close();
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }
    }
}
