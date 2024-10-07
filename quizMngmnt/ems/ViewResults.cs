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

namespace ems
{
    public partial class ViewResults : Form
    {
        public ViewResults()
        {
            InitializeComponent();
            GetSubjects();
            GetCandidate();
            DisplayResults();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\public\Documents\QuizDB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
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

        private void GetCandidate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CName from CandidateTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CName", typeof(string));
            dt.Load(rdr);
            Cbox.ValueMember = "CName";
            Cbox.DataSource = dt;
            Con.Close();
        }

        private void DisplayResults()
        {
            Con.Open();
            string Query = "Select * from ResultTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FilterBySub()
        {
            Con.Open();
            string Query = "Select * from ResultTbl where RSubject='" + SubjectCb.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FilterByCandidate()
        {
            Con.Open();
            string Query = "Select * from ResultTbl where RCandidate='" + Cbox.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ResultsDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            obj.Show();
            this.Hide();
        }

        private void SubjectCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterBySub();
        }

        private void SCbox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCandidate();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Candidates obj = new Candidates();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Questions Obj = new Questions();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Candidates Obj = new Candidates();
            Obj.Show();
            this.Hide();
        }
    }
}
