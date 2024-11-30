using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymDesktop
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\programming\C#\project\safe\gym\Database\GymDb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

        // Populate the DataGridView with members
        private void populate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM MemberTbl";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    MemberSDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all fields
            NameTb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            GenderCb.Text = "";
            PhoneTb.Text = "";
            TimingCb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
