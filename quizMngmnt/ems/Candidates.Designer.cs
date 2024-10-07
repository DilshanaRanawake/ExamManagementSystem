namespace ems
{
    partial class Candidates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidates));
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ResetBtn = new Button();
            EditBtn = new Button();
            label5 = new Label();
            CandidatesDGV = new DataGridView();
            SaveBtn = new Button();
            comboBox1 = new ComboBox();
            AddressTb = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            CAgeTb = new TextBox();
            CNameTb = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            PhoneTb = new TextBox();
            PasswordTb = new TextBox();
            label4 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CandidatesDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 354);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResetBtn.AutoSize = true;
            ResetBtn.BackColor = Color.White;
            ResetBtn.FlatAppearance.BorderColor = Color.White;
            ResetBtn.FlatAppearance.BorderSize = 3;
            ResetBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            ResetBtn.FlatStyle = FlatStyle.Popup;
            ResetBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetBtn.Location = new Point(1367, 398);
            ResetBtn.Margin = new Padding(0);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(170, 71);
            ResetBtn.TabIndex = 20;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditBtn.AutoSize = true;
            EditBtn.BackColor = Color.White;
            EditBtn.FlatAppearance.BorderColor = Color.White;
            EditBtn.FlatAppearance.BorderSize = 3;
            EditBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            EditBtn.FlatStyle = FlatStyle.Popup;
            EditBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.Location = new Point(726, 398);
            EditBtn.Margin = new Padding(0);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(170, 71);
            EditBtn.TabIndex = 19;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(672, 502);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(242, 38);
            label5.TabIndex = 18;
            label5.Text = "Candidates List";
            label5.Click += label5_Click;
            // 
            // CandidatesDGV
            // 
            CandidatesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CandidatesDGV.BackgroundColor = SystemColors.Control;
            CandidatesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CandidatesDGV.Location = new Point(4, 551);
            CandidatesDGV.Margin = new Padding(4);
            CandidatesDGV.Name = "CandidatesDGV";
            CandidatesDGV.RowHeadersWidth = 51;
            CandidatesDGV.Size = new Size(1566, 392);
            CandidatesDGV.TabIndex = 17;
            CandidatesDGV.CellContentClick += CandidatesDGV_CellContentClick;
            // 
            // SaveBtn
            // 
            SaveBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaveBtn.AutoSize = true;
            SaveBtn.BackColor = Color.White;
            SaveBtn.FlatAppearance.BorderColor = Color.White;
            SaveBtn.FlatAppearance.BorderSize = 3;
            SaveBtn.FlatAppearance.MouseDownBackColor = Color.Black;
            SaveBtn.FlatStyle = FlatStyle.Popup;
            SaveBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(108, 398);
            SaveBtn.Margin = new Padding(0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(170, 71);
            SaveBtn.TabIndex = 14;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1339, 155);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 33);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Subject";
            // 
            // AddressTb
            // 
            AddressTb.BackColor = Color.FromArgb(195, 224, 229);
            AddressTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddressTb.ForeColor = SystemColors.InfoText;
            AddressTb.Location = new Point(1141, 208);
            AddressTb.Margin = new Padding(6);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(386, 46);
            AddressTb.TabIndex = 12;
            AddressTb.Text = "Address";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 555);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(9, 460);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // CAgeTb
            // 
            CAgeTb.BackColor = Color.FromArgb(195, 224, 229);
            CAgeTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CAgeTb.ForeColor = SystemColors.InfoText;
            CAgeTb.Location = new Point(691, 297);
            CAgeTb.Margin = new Padding(6);
            CAgeTb.Multiline = true;
            CAgeTb.Name = "CAgeTb";
            CAgeTb.Size = new Size(253, 46);
            CAgeTb.TabIndex = 7;
            CAgeTb.Text = "Age";
            // 
            // CNameTb
            // 
            CNameTb.BackColor = Color.FromArgb(195, 224, 229);
            CNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CNameTb.ForeColor = SystemColors.InfoText;
            CNameTb.Location = new Point(108, 208);
            CNameTb.Margin = new Padding(6);
            CNameTb.Multiline = true;
            CNameTb.Name = "CNameTb";
            CNameTb.Size = new Size(282, 46);
            CNameTb.TabIndex = 6;
            CNameTb.Text = "Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 68, 114);
            panel4.Location = new Point(824, 128);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 4);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(601, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 3;
            label3.Text = "Subjects";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 38);
            label2.TabIndex = 2;
            label2.Text = "Questions";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 1;
            label1.Text = "Quiz Pro 1.0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 68, 114);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(1578, 10);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(80, 938);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 244);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1673, 956);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.FromArgb(195, 224, 229);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(PhoneTb);
            panel2.Controls.Add(PasswordTb);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CandidatesDGV);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(AddressTb);
            panel2.Controls.Add(CAgeTb);
            panel2.Controls.Add(CNameTb);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1673, 963);
            panel2.TabIndex = 0;
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.FromArgb(195, 224, 229);
            PhoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.ForeColor = SystemColors.InfoText;
            PhoneTb.Location = new Point(1169, 297);
            PhoneTb.Margin = new Padding(6);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(358, 46);
            PhoneTb.TabIndex = 22;
            PhoneTb.Text = "Phone";
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.FromArgb(195, 224, 229);
            PasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.ForeColor = SystemColors.InfoText;
            PasswordTb.Location = new Point(108, 297);
            PasswordTb.Margin = new Padding(6);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(358, 46);
            PasswordTb.TabIndex = 21;
            PasswordTb.Text = "Password";
            PasswordTb.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(817, 86);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(182, 38);
            label4.TabIndex = 4;
            label4.Text = "Candidates";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16.2F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(1098, 94);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 38);
            label6.TabIndex = 23;
            label6.Text = "View Results";
            label6.Click += label6_Click;
            // 
            // Candidates
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1668, 956);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Candidates";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Candidates";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CandidatesDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Button ResetBtn;
        private Button EditBtn;
        private Label label5;
        private DataGridView CandidatesDGV;
        private Button SaveBtn;
        private ComboBox comboBox1;
        private TextBox AddressTb;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private TextBox CAgeTb;
        private TextBox CNameTb;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private TextBox PhoneTb;
        private TextBox PasswordTb;
        private Label label6;
    }
}