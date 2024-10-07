using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

             

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int Count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Chrono -= 1;
            Count += 1;
            MyProgress.Value = Count;
            PercentageLbl.Text = "Loading... " + Count + "%" ;
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                //MessageBox.Show("Time Over");
                Login log = new Login();
                log.Show();
                this.Hide();

            }
        }
    }
}
