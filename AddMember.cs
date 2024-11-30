using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymDesktop
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }


        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    using (SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programming\C#\project\safe\gym\Database\GymDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"))
                    {
                        Con.Open();
                        string query = "INSERT INTO MemberTbl (MName, MPhone, MGen, MAge, MAmount, MTraining) " +
                                       "VALUES (@MName, @MPhone, @MGen, @MAge, @MAmount, @MTraining)";
                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            // Add parameters matching the table columns
                            cmd.Parameters.AddWithValue("@MName", NameTb.Text);
                            cmd.Parameters.AddWithValue("@MPhone", PhoneTb.Text);
                            cmd.Parameters.AddWithValue("@MGen", GenderCb.SelectedItem?.ToString() ?? string.Empty);
                            cmd.Parameters.AddWithValue("@MAge", int.Parse(AgeTb.Text));
                            cmd.Parameters.AddWithValue("@MAmount", int.Parse(AmountTb.Text));
                            cmd.Parameters.AddWithValue("@MTraining", TimingCb.SelectedItem?.ToString() ?? string.Empty);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Member Successfully Added");
                            AmountTb.Text = "";
                            AgeTb.Text = "";
                            NameTb.Text = "";
                            PhoneTb.Text = "";
                            GenderCb.Text = "";
                            TimingCb.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
