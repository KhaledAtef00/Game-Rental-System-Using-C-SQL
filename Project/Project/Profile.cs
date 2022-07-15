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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandText = "UPDATE SysUser SET LastName = '" + textBox4.Text + "', FirstName = '" + textBox1.Text + "', userpassword = '" + textBox5.Text + "' WHERE Email = '" + textBox3.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            SqlCommand check = new SqlCommand();
            check.Connection = sqlconnection;
            check.CommandText = "SELECT Authority FROM SysUser WHERE Email = '" + textBox3.Text + "' ";
            SqlDataReader myReader = check.ExecuteReader();
            bool v=false;
            if (myReader.Read())
            {
                v = (bool)myReader[0];
            }
            sqlconnection.Close();
            if (v.Equals(true))
            {
                this.Hide();
                AdminView f3 = new AdminView();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                ClientView f3 = new ClientView();
                f3.ShowDialog();
                this.Close();
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile f3 = new Profile();
            f3.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            this.Close();
        }
    }
}
