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
            comboBox1 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            maskedTextBox5 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
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
            label2.Location = new Point(566, 42);
            label2.Name = "label2";
            label2.Size = new Size(191, 54);
            label2.TabIndex = 3;
            label2.Text = "BIG GYM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(485, 85);
            label1.Name = "label1";
            label1.Size = new Size(355, 54);
            label1.TabIndex = 4;
            label1.Text = "Add New Member";
            label1.Click += this.label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(1274, 31);
            label3.Name = "label3";
            label3.Size = new Size(46, 50);
            label3.TabIndex = 5;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(149, 211);
            label4.Name = "label4";
            label4.Size = new Size(153, 28);
            label4.TabIndex = 8;
            label4.Text = "Member Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(566, 211);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 10;
            label5.Text = "Phone Number";
            label5.Click += this.label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(1046, 211);
            label6.Name = "label6";
            label6.Size = new Size(49, 28);
            label6.TabIndex = 12;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(186, 372);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 14;
            label7.Text = "Gender";
            label7.Click += this.label7_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(114, 412);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 28);
            comboBox1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(555, 372);
            label8.Name = "label8";
            label8.Size = new Size(174, 28);
            label8.TabIndex = 17;
            label8.Text = "Monthly Amount";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "6Am-8Am", "8Am-10Am", "6Pm-8Pm", "8Pm-10PM" });
            comboBox2.Location = new Point(960, 413);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 28);
            comboBox2.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkOrange;
            label9.Location = new Point(1032, 373);
            label9.Name = "label9";
            label9.Size = new Size(78, 28);
            label9.TabIndex = 18;
            label9.Text = "Timing";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.BackColor = Color.Black;
            maskedTextBox5.BorderStyle = BorderStyle.None;
            maskedTextBox5.Font = new Font("Engravers MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            maskedTextBox5.ForeColor = Color.DarkOrange;
            maskedTextBox5.Location = new Point(533, 252);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(224, 24);
            maskedTextBox5.TabIndex = 20;
            maskedTextBox5.Text = "___________________________________";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.Black;
            maskedTextBox4.BorderStyle = BorderStyle.None;
            maskedTextBox4.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maskedTextBox4.ForeColor = Color.DarkOrange;
            maskedTextBox4.Location = new Point(114, 252);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(224, 24);
            maskedTextBox4.TabIndex = 23;
            maskedTextBox4.Text = "___________________________________";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Black;
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maskedTextBox1.ForeColor = Color.DarkOrange;
            maskedTextBox1.Location = new Point(960, 252);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(224, 24);
            maskedTextBox1.TabIndex = 24;
            maskedTextBox1.Text = "___________________________________";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BackColor = Color.Black;
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maskedTextBox2.ForeColor = Color.DarkOrange;
            maskedTextBox2.Location = new Point(533, 416);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(224, 24);
            maskedTextBox2.TabIndex = 25;
            maskedTextBox2.Text = "___________________________________";
            // 
            // button1
            // 
            button1.BackColor = Color.Peru;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(839, 546);
            button1.Name = "button1";
            button1.Size = new Size(155, 53);
            button1.TabIndex = 26;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(590, 546);
            button2.Name = "button2";
            button2.Size = new Size(155, 53);
            button2.TabIndex = 27;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(338, 546);
            button3.Name = "button3";
            button3.Size = new Size(155, 53);
            button3.TabIndex = 28;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1344, 755);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox5);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Cursor = Cursors.AppStarting;
            ForeColor = SystemColors.ButtonHighlight;
            Name = "AddMember";
            Text = "Form2";
            Load += this.AddMember_Load;
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
        private ComboBox comboBox1;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private MaskedTextBox maskedTextBox5;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}