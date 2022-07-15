using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sql2Command = new SqlCommand();
            sql2Command.Connection = sqlconnection;
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "INSERT INTO SysUser (LastName, FirstName, Email, userpassword, Authority) VALUES ('" + textBox2.Text + "', '" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', 0);";
            sqlCommand.ExecuteNonQuery();
            sql2Command.CommandText = "INSERT INTO Client (Email) VALUES ( '" + textBox3.Text + "' )";
            sql2Command.ExecuteNonQuery();
            sqlconnection.Close();

            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
