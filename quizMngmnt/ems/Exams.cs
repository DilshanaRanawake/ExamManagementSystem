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
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
            //multirandom();
            CnameLbl.Text = Login.CandName;
            SubjectLbl.Text = Login.SubName;
            Qn = CountQuestions();
            FetchQuestions();
            //SaveHighest();


        }
        int Qn;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\public\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;

        private void Exams_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Reset();
        }
        string[] Ua = new string[10];
        int Chrono = 350;
        int Count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Chrono -= 1;
            Count += 1;
            TimingBar.Value = Count;
            TimeLbl.Text = "" + Chrono;
            if (TimingBar.Value == 350)
            {
                TimingBar.Value = 0;
                timer1.Stop();
                MessageBox.Show("Time Over");
                Login log = new Login();
                this.Hide();

            }
        }

        private int CountQuestions()
        {
            int Qnum;
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from QuestionTbl where QS = '" + SubjectLbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Qnum = Convert.ToInt32(dt.Rows[0][0]);
            Con.Close();
            //MessageBox.Show("" + Qnum);
            return Qnum;
        }

        /*private int GenerateRand()
        {
            Random rd = new Random();
            int x = rd.Next(1, 4);
            int y = rd.Next(1, 4);
            int z = rd.Next(1, 4);
            MessageBox.Show("" + x + "and" + y + "and+z");
            return x;
        }*/

        private void SaveHighest()
        {
            Con.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter("select Max(RScore) from ResultTbl where RCandidate = '" + CnameLbl.Text + "'", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            int BestScore = Convert.ToInt32(dt2.Rows[0][0].ToString())
; try
            {
                //int score = 0;
                //Con.Open();
                SqlCommand cmd = new SqlCommand("Update CandidateTbl set CScore=@Cs where CName=@Cn", Con);
                cmd.Parameters.AddWithValue("@Cn", CnameLbl.Text);
                cmd.Parameters.AddWithValue("@Cs", BestScore);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Candidate Updated");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            Con.Close();
        }

        int[] Keys = new int[10];
        private void multirandom()
        {
            if (Qn < 10)
            {
                throw new InvalidOperationException("Not enough questions available.");
            }

            HashSet<int> numbers = new HashSet<int>();
            var rnd = new Random();
            while (numbers.Count < 10)
            {
                numbers.Add(rnd.Next(1, Qn));
            }
            for (int i = 0; i < 10; i++)
            {
                Keys[i] = numbers.ElementAt(i);
            }
            /*for (int y = 0; y < 5; y++)
            {
                MessageBox.Show("" + Keys[y]);
            }*/
        }
        private void FetchQuestions()
        {
            try
            {
                //int Qnum = GenerateRand();
                multirandom();
                Con.Open();
                string Query = "select * from QuestionTbl where QId=" + Keys[0] + "";
                SqlCommand cmd = new SqlCommand(Query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q1.Text = dr["QDesc"].ToString();
                    Q1O1.Text = dr["Q01"].ToString();
                    Q1O2.Text = dr["Q02"].ToString();
                    Q1O3.Text = dr["Q03"].ToString();
                    Q1O4.Text = dr["Q04"].ToString();
                    a1 = dr["QA"].ToString();

                }
                string Query1 = "select * from QuestionTbl where QId=" + Keys[1] + "";
                cmd = new SqlCommand(Query1, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q2.Text = dr["QDesc"].ToString();
                    Q2O1.Text = dr["Q01"].ToString();
                    Q2O2.Text = dr["Q02"].ToString();
                    Q2O3.Text = dr["Q03"].ToString();
                    Q2O4.Text = dr["Q04"].ToString();
                    a2 = dr["QA"].ToString();

                }
                string Query2 = "select * from QuestionTbl where QId=" + Keys[2] + "";
                cmd = new SqlCommand(Query2, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q3.Text = dr["QDesc"].ToString();
                    Q3O1.Text = dr["Q01"].ToString();
                    Q3O2.Text = dr["Q02"].ToString();
                    Q3O3.Text = dr["Q03"].ToString();
                    Q3O4.Text = dr["Q04"].ToString();
                    a3 = dr["QA"].ToString();

                }
                string Query3 = "select * from QuestionTbl where QId=" + Keys[3] + "";
                cmd = new SqlCommand(Query3, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q4.Text = dr["QDesc"].ToString();
                    Q4O1.Text = dr["Q01"].ToString();
                    Q4O2.Text = dr["Q02"].ToString();
                    Q4O3.Text = dr["Q03"].ToString();
                    Q4O4.Text = dr["Q04"].ToString();
                    a4 = dr["QA"].ToString();

                }
                string Query4 = "select * from QuestionTbl where QId=" + Keys[4] + "";
                cmd = new SqlCommand(Query4, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q5.Text = dr["QDesc"].ToString();
                    Q5O1.Text = dr["Q01"].ToString();
                    Q5O2.Text = dr["Q02"].ToString();
                    Q5O3.Text = dr["Q03"].ToString();
                    Q5O4.Text = dr["Q04"].ToString();
                    a5 = dr["QA"].ToString();

                }
                string Query5 = "select * from QuestionTbl where QId=" + Keys[5] + "";
                cmd = new SqlCommand(Query5, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q6.Text = dr["QDesc"].ToString();
                    Q6O1.Text = dr["Q01"].ToString();
                    Q6O2.Text = dr["Q02"].ToString();
                    Q6O3.Text = dr["Q03"].ToString();
                    Q6O4.Text = dr["Q04"].ToString();
                    a6 = dr["QA"].ToString();

                }
                string Query6 = "select * from QuestionTbl where QId=" + Keys[6] + "";
                cmd = new SqlCommand(Query6, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q7.Text = dr["QDesc"].ToString();
                    Q7O1.Text = dr["Q01"].ToString();
                    Q7O2.Text = dr["Q02"].ToString();
                    Q7O3.Text = dr["Q03"].ToString();
                    Q7O4.Text = dr["Q04"].ToString();
                    a7 = dr["QA"].ToString();

                }
                string Query7 = "select * from QuestionTbl where QId=" + Keys[7] + "";
                cmd = new SqlCommand(Query7, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q8.Text = dr["QDesc"].ToString();
                    Q8O1.Text = dr["Q01"].ToString();
                    Q8O2.Text = dr["Q02"].ToString();
                    Q8O3.Text = dr["Q03"].ToString();
                    Q8O4.Text = dr["Q04"].ToString();
                    a8 = dr["QA"].ToString();

                }
                string Query8 = "select * from QuestionTbl where QId=" + Keys[8] + "";
                cmd = new SqlCommand(Query8, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q9.Text = dr["QDesc"].ToString();
                    Q9O1.Text = dr["Q01"].ToString();
                    Q9O2.Text = dr["Q02"].ToString();
                    Q9O3.Text = dr["Q03"].ToString();
                    Q9O4.Text = dr["Q04"].ToString();
                    a9 = dr["QA"].ToString();

                }
                string Query9 = "select * from QuestionTbl where QId=" + Keys[9] + "";
                cmd = new SqlCommand(Query9, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Q10.Text = dr["QDesc"].ToString();
                    Q10O1.Text = dr["Q01"].ToString();
                    Q10O2.Text = dr["Q02"].ToString();
                    Q10O3.Text = dr["Q03"].ToString();
                    Q10O4.Text = dr["Q04"].ToString();
                    a10 = dr["QA"].ToString();

                }
                Con.Close();
            }
            catch (Exception ex)
            {

            }
        }
        int Score = 0;
        private void checkQ1()
        {
            if (Q1O1.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O1.Text;
            }
            else if (Q1O2.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O2.Text;
            }
            else if (Q1O3.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O3.Text;
            }
            else if (Q1O4.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q1O4.Text;
            }
            if (Ua[0] == a1)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ2()
        {
            if (Q2O1.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O1.Text;
            }
            else if (Q2O2.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O2.Text;
            }
            else if (Q2O3.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O3.Text;
            }
            else if (Q2O4.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q2O4.Text;
            }
            if (Ua[1] == a2)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ3()
        {
            if (Q3O1.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O1.Text;
            }
            else if (Q3O2.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O2.Text;
            }
            else if (Q3O3.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O3.Text;
            }
            else if (Q3O4.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q3O4.Text;
            }
            if (Ua[2] == a3)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ4()
        {
            if (Q4O1.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O1.Text;
            }
            else if (Q4O2.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O2.Text;
            }
            else if (Q4O3.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O3.Text;
            }
            else if (Q4O4.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q4O4.Text;
            }
            if (Ua[3] == a4)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ5()
        {
            if (Q5O1.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O1.Text;
            }
            else if (Q5O2.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O2.Text;
            }
            else if (Q5O3.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O3.Text;
            }
            else if (Q5O4.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q5O4.Text;
            }
            if (Ua[4] == a5)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ6()
        {
            if (Q6O1.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O1.Text;
            }
            else if (Q6O2.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O2.Text;
            }
            else if (Q6O3.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O3.Text;
            }
            else if (Q6O4.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q6O4.Text;
            }
            if (Ua[5] == a6)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ7()
        {
            if (Q7O1.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O1.Text;
            }
            else if (Q7O2.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O2.Text;
            }
            else if (Q7O3.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O3.Text;
            }
            else if (Q7O4.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q7O4.Text;
            }
            if (Ua[6] == a7)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ8()
        {
            if (Q8O1.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O1.Text;
            }
            else if (Q8O2.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O2.Text;
            }
            else if (Q8O3.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O3.Text;
            }
            else if (Q8O4.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q8O4.Text;
            }
            if (Ua[7] == a8)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ9()
        {
            if (Q9O1.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O1.Text;
            }
            else if (Q9O2.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O2.Text;
            }
            else if (Q9O3.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O3.Text;
            }
            else if (Q9O4.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q9O4.Text;
            }
            if (Ua[8] == a9)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }
        private void checkQ10()
        {
            if (Q10O1.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O1.Text;
            }
            else if (Q10O2.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O2.Text;
            }
            else if (Q10O3.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O3.Text;
            }
            else if (Q10O4.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q10O4.Text;
            }
            if (Ua[9] == a10)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void InsertResult()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ResultTbl (RSubject,RCandidate,RDate,RTime,RScore) values (@RS,@RC,@RD,@RT,@RSc)", Con);
                cmd.Parameters.AddWithValue("@RS", SubjectLbl.Text);
                cmd.Parameters.AddWithValue("@RC", CnameLbl.Text);
                cmd.Parameters.AddWithValue("@RD", QDateP.Value.Date);
                cmd.Parameters.AddWithValue("@RT", QTimeP.Text);
                cmd.Parameters.AddWithValue("@RSc", Score);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Results Saved");
                Con.Close();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Reset()
        {
            Q1O1.Checked = false;
            Q1O2.Checked = false;
            Q1O3.Checked = false;
            Q1O4.Checked = false;

            Q2O1.Checked = false;
            Q2O2.Checked = false;
            Q2O3.Checked = false;
            Q2O4.Checked = false;

            Q3O1.Checked = false;
            Q3O2.Checked = false;
            Q3O3.Checked = false;
            Q3O4.Checked = false;

            Q4O1.Checked = false;
            Q4O2.Checked = false;
            Q4O3.Checked = false;
            Q4O4.Checked = false;

            Q5O1.Checked = false;
            Q5O2.Checked = false;
            Q5O3.Checked = false;
            Q5O4.Checked = false;

            Q6O1.Checked = false;
            Q6O2.Checked = false;
            Q6O3.Checked = false;
            Q6O4.Checked = false;

            Q7O1.Checked = false;
            Q7O2.Checked = false;
            Q7O3.Checked = false;
            Q7O4.Checked = false;

            Q8O1.Checked = false;
            Q8O2.Checked = false;
            Q8O3.Checked = false;
            Q8O4.Checked = false;

            Q9O1.Checked = false;
            Q9O2.Checked = false;
            Q9O3.Checked = false;
            Q9O4.Checked = false;

            Q10O1.Checked = false;
            Q10O2.Checked = false;
            Q10O3.Checked = false;
            Q10O4.Checked = false;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Score = 0;
            checkQ1();
            checkQ2();
            checkQ3();
            checkQ4();
            checkQ5();
            checkQ6();
            checkQ7();
            checkQ8();
            checkQ9();
            checkQ10();
            MessageBox.Show("" + Score);
            InsertResult();
            SaveHighest();
            Login log = new Login();
            log.Show();
            this.Hide();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        //private void Q1O1_CheckedChanged(object sender, EventArgs e)
        //{
        //    Ua[0] = Q1O1.Text;
        //    MessageBox.Show("Selcted Answer is " + Ua[0]);
        //}

        //private void Q1O2_CheckedChanged(object sender, EventArgs e)
        //{
        //    Ua[0] = Q1O2.Text;
        //    MessageBox.Show("Selcted Answer is " + Ua[0]);
        //}
    }
}
