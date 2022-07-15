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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sql2Command = new SqlCommand();
            sqlconnection.Open();
            SqlCommand check = new SqlCommand();
            check.Connection = sqlconnection;
            check.CommandText = "SELECT Email FROM SysUser WHERE Authority=1";
            SqlDataReader myReader = check.ExecuteReader();
            string v = null;
            if (myReader.Read())
            {
                v = myReader["Email"].ToString();
            }
            myReader.Close();
            sqlCommand.Connection = sqlconnection;
            sql2Command.Connection = sqlconnection;
            sql2Command.CommandText = "INSERT INTO Vendor (VendorName) VALUES ('" + textBox5.Text + "')";
            sql2Command.ExecuteNonQuery();
            sqlCommand.CommandText = "INSERT INTO Game (GameID, GameName, GameYear, Categories, Email, VendorName) VALUES ('"+textBox2.Text+ "', '" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "',  '" + v + "' , '" + textBox5.Text + "');";
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }
        private void AddGame_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
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
    }
}
