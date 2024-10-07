using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ems
{
    public partial class Candidates : Form
    {
        public Candidates()
        {
            InitializeComponent();
            DisplayCandidates();
        }

        private void Reset()
        {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            PhoneTb.Text = "";
            AddressTb.Text = "";
            PasswordTb.Text = "";
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\public\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void DisplayCandidates()
        {
            Con.Open();
            string Query = "Select * from CandidateTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CandidatesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CandidateTbl (CName,CAge,CPass,CScore,CAdd,Cphone) values (@Cn,@Ca,@Cp,@Cs,@Cad,@Cph)", Con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cs", score);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Saved");
                    Con.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || CAgeTb.Text == "" || CAgeTb.Text == "Age" || PasswordTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update CandidateTbl set CName=@Cn,CAge=@Ca,CPass=@Cp,CAdd=@Cad,Cphone=@Cph where CId=@CKey", Con);
                    cmd.Parameters.AddWithValue("@Cn", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@Ca", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@Cp", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@Cad", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Candidate Updated");
                    Con.Close();
                    Reset();
                    DisplayCandidates();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void CandidatesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CandidatesDGV.Rows.Count)
            {
                CNameTb.Text = CandidatesDGV.Rows[e.RowIndex].Cells["CName"].Value?.ToString();
                CAgeTb.Text = CandidatesDGV.Rows[e.RowIndex].Cells["CAge"].Value?.ToString();
                PasswordTb.Text = CandidatesDGV.Rows[e.RowIndex].Cells["CPass"].Value?.ToString();
                AddressTb.Text = CandidatesDGV.Rows[e.RowIndex].Cells["CAdd"].Value?.ToString();
                PhoneTb.Text = CandidatesDGV.Rows[e.RowIndex].Cells["CPhone"].Value?.ToString();

                // Update Key variable
                if (CNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(CandidatesDGV.Rows[e.RowIndex].Cells["CId"].Value);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewResults Obj = new ViewResults();
            Obj.Show();
            this.Hide();
        }
    }
}
