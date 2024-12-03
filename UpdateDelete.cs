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

        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\source\gym\gym\Database\GymDb.mdf;Integrated Security=True;Connect Timeout=30";

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
            if (e.RowIndex >= 0 && e.RowIndex < MemberSDGV.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow selectedRow = MemberSDGV.Rows[e.RowIndex];

                // Populate the fields using column names
                NameTb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                PhoneTb.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                GenderCb.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                AgeTb.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                AmountTb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                TimingCb.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
            }
            else
            {
                // If no valid row is selected, show a message
                MessageBox.Show("Please select a valid row.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }
