using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymDesktop
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        // Connection string
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

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
