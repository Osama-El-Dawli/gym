//Payment 

namespace GymDesktop
{
    partial class Payment
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Peru;
            label3.Location = new Point(2976, 64);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 99);
            label3.TabIndex = 8;
            label3.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(1478, 164);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(467, 116);
            label1.TabIndex = 7;
            label1.Text = "PAYMENTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(1525, 64);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(383, 106);
            label2.TabIndex = 6;
            label2.Text = "BIG GYM";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.BackColor = Color.Black;
            maskedTextBox4.BorderStyle = BorderStyle.None;
            maskedTextBox4.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maskedTextBox4.ForeColor = Color.DarkOrange;
            maskedTextBox4.Location = new Point(286, 972);
            maskedTextBox4.Margin = new Padding(6);
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(476, 47);
            maskedTextBox4.TabIndex = 45;
            maskedTextBox4.Text = "___________________________________";
            maskedTextBox4.MaskInputRejected += maskedTextBox4_MaskInputRejected;
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.BackColor = Color.Black;
            maskedTextBox5.BorderStyle = BorderStyle.None;
            maskedTextBox5.Font = new Font("Engravers MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            maskedTextBox5.ForeColor = Color.DarkOrange;
            maskedTextBox5.Location = new Point(286, 1226);
            maskedTextBox5.Margin = new Padding(6);
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(476, 47);
            maskedTextBox5.TabIndex = 44;
            maskedTextBox5.Text = "___________________________________";
            maskedTextBox5.MaskInputRejected += maskedTextBox5_MaskInputRejected;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(286, 1114);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 54);
            label5.TabIndex = 43;
            label5.Text = "Amount";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(286, 868);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(307, 54);
            label4.TabIndex = 42;
            label4.Text = "Member Name";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.PeachPuff;
            dateTimePicker1.CalendarTitleBackColor = Color.Linen;
            dateTimePicker1.Location = new Point(286, 722);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(500, 47);
            dateTimePicker1.TabIndex = 46;
            dateTimePicker1.Value = new DateTime(2024, 11, 30, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(286, 585);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(327, 54);
            label6.TabIndex = 47;
            label6.Text = "Payment Month";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Peru;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(282, 1437);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(232, 109);
            button3.TabIndex = 49;
            button3.Text = "Pay";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Peru;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(547, 1437);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(215, 109);
            button2.TabIndex = 48;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(1658, 305);
            pictureBox2.Margin = new Padding(6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Peru;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(282, 1609);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(480, 109);
            button4.TabIndex = 53;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Linen;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(907, 495);
            dataGridView2.Margin = new Padding(6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(2170, 1324);
            dataGridView2.TabIndex = 54;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(3288, 1861);
            Controls.Add(dataGridView2);
            Controls.Add(button4);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox2;
        private Button button4;
        private DataGridView dataGridView2;
    }
}