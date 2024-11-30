namespace GymDesktop
{
    partial class AddMember
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            GenderCb = new ComboBox();
            label8 = new Label();
            TimingCb = new ComboBox();
            label9 = new Label();
            PhoneTb = new MaskedTextBox();
            NameTb = new MaskedTextBox();
            AgeTb = new MaskedTextBox();
            AmountTb = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(1418, 153);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(383, 106);
            label2.TabIndex = 3;
            label2.Text = "BIG GYM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(1246, 241);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(713, 106);
            label1.TabIndex = 4;
            label1.Text = "Add New Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(2922, 131);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 99);
            label3.TabIndex = 5;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(567, 622);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(307, 54);
            label4.TabIndex = 8;
            label4.Text = "Member Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(1453, 622);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(309, 54);
            label5.TabIndex = 10;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(2473, 622);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 54);
            label6.TabIndex = 12;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(645, 952);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(160, 54);
            label7.TabIndex = 14;
            label7.Text = "Gender";
            // 
            // GenderCb
            // 

            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(114, 412);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(224, 28);
            GenderCb.TabIndex = 15;

            //comboBox1.FormattingEnabled = true;
            //comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            //comboBox1.Location = new Point(492, 1034);
            //comboBox1.Margin = new Padding(6);
            //comboBox1.Name = "comboBox1";
            //comboBox1.Size = new Size(472, 49);
            //comboBox1.TabIndex = 15;

            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(1429, 952);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(346, 54);
            label8.TabIndex = 17;
            label8.Text = "Monthly Amount";
            // 
            // TimingCb
            // 

            TimingCb.FormattingEnabled = true;
            TimingCb.Items.AddRange(new object[] { "6Am-8Am", "8Am-10Am", "6Pm-8Pm", "8Pm-10PM" });
            TimingCb.Location = new Point(960, 413);
            TimingCb.Name = "TimingCb";
            TimingCb.Size = new Size(224, 28);
            TimingCb.TabIndex = 19;

            //comboBox2.FormattingEnabled = true;
            //comboBox2.Items.AddRange(new object[] { "6Am-8Am", "8Am-10Am", "6Pm-8Pm", "8Pm-10PM" });
            //comboBox2.Location = new Point(2290, 1036);
            //comboBox2.Margin = new Padding(6);
            //comboBox2.Name = "comboBox2";
            //comboBox2.Size = new Size(472, 49);
            //comboBox2.TabIndex = 19;

            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkOrange;
            label9.Location = new Point(2443, 954);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(154, 54);
            label9.TabIndex = 18;
            label9.Text = "Timing";
            // 
            // PhoneTb
            // 

            PhoneTb.BackColor = Color.DimGray;
            PhoneTb.BorderStyle = BorderStyle.None;
            PhoneTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PhoneTb.ForeColor = Color.DarkOrange;
            PhoneTb.Location = new Point(533, 252);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(224, 24);
            PhoneTb.TabIndex = 20;
//=======
            //maskedTextBox5.BackColor = Color.Black;
            //maskedTextBox5.BorderStyle = BorderStyle.None;
            //maskedTextBox5.Font = new Font("Engravers MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            //maskedTextBox5.ForeColor = Color.DarkOrange;
            //maskedTextBox5.Location = new Point(1383, 706);
            //maskedTextBox5.Margin = new Padding(6);
            //maskedTextBox5.Name = "maskedTextBox5";
            //maskedTextBox5.Size = new Size(476, 47);
            //maskedTextBox5.TabIndex = 20;
            //maskedTextBox5.Text = "___________________________________";
//>>>>>>> sara
            // 
            // NameTb
            // 
//<<<<<<< HEAD
            NameTb.BackColor = Color.DimGray;
            NameTb.BorderStyle = BorderStyle.None;
            NameTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameTb.ForeColor = Color.DarkOrange;
            NameTb.Location = new Point(114, 252);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(224, 24);
            NameTb.TabIndex = 23;
//=======
            //maskedTextBox4.BackColor = Color.Black;
            //maskedTextBox4.BorderStyle = BorderStyle.None;
            //maskedTextBox4.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            //maskedTextBox4.ForeColor = Color.DarkOrange;
            //maskedTextBox4.Location = new Point(492, 706);
            //maskedTextBox4.Margin = new Padding(6);
            //maskedTextBox4.Name = "maskedTextBox4";
            //maskedTextBox4.Size = new Size(476, 47);
            //maskedTextBox4.TabIndex = 23;
            //maskedTextBox4.Text = "___________________________________";
//>>>>>>> sara
            // 
            // AgeTb
            // 
//<<<<<<< HEAD
            AgeTb.BackColor = Color.DimGray;
            AgeTb.BorderStyle = BorderStyle.None;
            AgeTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeTb.ForeColor = Color.DarkOrange;
            AgeTb.Location = new Point(960, 252);
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(224, 24);
            AgeTb.TabIndex = 24;
//=======
            //maskedTextBox1.BackColor = Color.Black;
            //maskedTextBox1.BorderStyle = BorderStyle.None;
            //maskedTextBox1.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            //maskedTextBox1.ForeColor = Color.DarkOrange;
            //maskedTextBox1.Location = new Point(2290, 706);
            //maskedTextBox1.Margin = new Padding(6);
            //maskedTextBox1.Name = "maskedTextBox1";
            //maskedTextBox1.Size = new Size(476, 47);
            //maskedTextBox1.TabIndex = 24;
            //maskedTextBox1.Text = "___________________________________";
//>>>>>>> sara
            // 
            // AmountTb
            // 
//<<<<<<< HEAD
            AmountTb.BackColor = Color.DimGray;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AmountTb.ForeColor = Color.DarkOrange;
            AmountTb.Location = new Point(533, 416);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(224, 24);
            AmountTb.TabIndex = 25;
//=======
            //maskedTextBox2.BackColor = Color.Black;
            //maskedTextBox2.BorderStyle = BorderStyle.None;
            //maskedTextBox2.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            //maskedTextBox2.ForeColor = Color.DarkOrange;
            //maskedTextBox2.Location = new Point(1383, 1042);
            //maskedTextBox2.Margin = new Padding(6);
            //maskedTextBox2.Name = "maskedTextBox2";
            //maskedTextBox2.Size = new Size(476, 47);
            //maskedTextBox2.TabIndex = 25;
            //maskedTextBox2.Text = "___________________________________";
//>>>>>>> sara
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(2033, 1308);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(329, 109);
            button1.TabIndex = 26;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1504, 1308);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(329, 109);
            button2.TabIndex = 27;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(968, 1308);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(329, 109);
            button3.TabIndex = 28;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(3288, 1861);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AmountTb);
            Controls.Add(AgeTb);
            Controls.Add(NameTb);
            Controls.Add(PhoneTb);
            Controls.Add(TimingCb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(GenderCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Cursor = Cursors.AppStarting;
            ForeColor = SystemColors.ButtonHighlight;
//<<<<<<< HEAD
            FormBorderStyle = FormBorderStyle.None;
//=======
            Margin = new Padding(6);
//>>>>>>> sara
            Name = "AddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += AddMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox GenderCb;
        private Label label8;
        private ComboBox TimingCb;
        private Label label9;
        private MaskedTextBox PhoneTb;
        private MaskedTextBox NameTb;
        private MaskedTextBox AgeTb;
        private MaskedTextBox AmountTb;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}