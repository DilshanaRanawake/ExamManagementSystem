namespace ems
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            pictureBox2 = new PictureBox();
            label4 = new Label();
            MyProgress = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            PercentageLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(326, 148);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 342);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(65, 114, 159);
            label4.Location = new Point(296, 34);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(402, 38);
            label4.TabIndex = 24;
            label4.Text = "Quiz Management System";
            // 
            // MyProgress
            // 
            MyProgress.Location = new Point(13, 517);
            MyProgress.Margin = new Padding(4);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(970, 16);
            MyProgress.TabIndex = 25;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PercentageLbl
            // 
            PercentageLbl.AutoSize = true;
            PercentageLbl.Font = new Font("Microsoft Yi Baiti", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PercentageLbl.ForeColor = Color.FromArgb(65, 114, 159);
            PercentageLbl.Location = new Point(833, 479);
            PercentageLbl.Margin = new Padding(4, 0, 4, 0);
            PercentageLbl.Name = "PercentageLbl";
            PercentageLbl.Size = new Size(108, 20);
            PercentageLbl.TabIndex = 26;
            PercentageLbl.Text = "Loading... %";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1000, 562);
            Controls.Add(PercentageLbl);
            Controls.Add(MyProgress);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label4;
        private ProgressBar MyProgress;
        private System.Windows.Forms.Timer timer1;
        private Label PercentageLbl;
    }
}