using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ems
{
    public partial class Questions : Form
    {
        public Questions()
        {
            InitializeComponent();
            GetSubjects();
            DisplayQuestions();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\public\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void Reset()
        {
            QuestTb.Text = "";
            Op1Tb.Text = "";
            Op2Tb.Text = "";
            Op3Tb.Text = "";
            Op4Tb.Text = "";
            AnswerTb.Text = "";
            SubjectCb.SelectedIndex = 0;
        }
        private void GetSubjects()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SName", typeof(string));
            dt.Load(rdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            Con.Close();
        }
        private void DisplayQuestions()
        {
            Con.Open();
            string Query = "Select * from QuestionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into QuestionTbl (QDesc,Q01,Q02,Q03,Q04,QA,QS) values (@Qd,@O1,@O2,@O3,@O4,@Qan,@Qsu)", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added");
                    Con.Close();
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (QuestTb.Text == "" || Op1Tb.Text == "" || Op2Tb.Text == "" || Op3Tb.Text == "" || Op4Tb.Text == "" || AnswerTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update QuestionTbl set QDesc=@Qd,Q01=@O1,Q02=@O2,Q03=@O3,Q04=@O4, QA=@Qan, QS=@Qsu where QId=@QKey", Con);
                    cmd.Parameters.AddWithValue("@Qd", QuestTb.Text);
                    cmd.Parameters.AddWithValue("@O1", Op1Tb.Text);
                    cmd.Parameters.AddWithValue("@O2", Op2Tb.Text);
                    cmd.Parameters.AddWithValue("@O3", Op3Tb.Text);
                    cmd.Parameters.AddWithValue("@O4", Op4Tb.Text);
                    cmd.Parameters.AddWithValue("@Qan", AnswerTb.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@QKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Updated");
                    Con.Close();
                    Reset();
                    DisplayQuestions();
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

        private void QuestionsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QuestTb.Text = QuestionsDGV.Rows[e.RowIndex].Cells["QDesc"].Value?.ToString();
            Op1Tb.Text = QuestionsDGV.Rows[e.RowIndex].Cells["Q01"].Value?.ToString();
            Op2Tb.Text = QuestionsDGV.Rows[e.RowIndex].Cells["Q02"].Value?.ToString();
            Op3Tb.Text = QuestionsDGV.Rows[e.RowIndex].Cells["Q03"].Value?.ToString();
            Op4Tb.Text = QuestionsDGV.Rows[e.RowIndex].Cells["Q04"].Value?.ToString();
            AnswerTb.Text = QuestionsDGV.Rows[e.RowIndex].Cells["QA"].Value?.ToString();
            SubjectCb.SelectedValue = QuestionsDGV.Rows[e.RowIndex].Cells["QS"].Value?.ToString();

            // Update Key variable
            if (QuestTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(QuestionsDGV.Rows[e.RowIndex].Cells["QId"].Value);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
