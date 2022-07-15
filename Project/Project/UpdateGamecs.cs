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
namespace Project
{
    public partial class UpdateGamecs : Form
    {
        public UpdateGamecs()
        {
            InitializeComponent();
        }

        private void UpdateGamecs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalSystemDataSet.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.rentalSystemDataSet.Game);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame f3 = new AddGame();
            f3.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame f3 = new AddGame();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandText = "UPDATE Game  SET GameName = '"+ textBox1.Text + "', GameYear = '" + textBox4.Text + "', Categories = '" + textBox5.Text + "' WHERE GameID = '" + textBox3.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame f3 = new AddGame();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateGamecs f3 = new UpdateGamecs();
            f3.ShowDialog();
            this.Close();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Profile f3 = new Profile();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
