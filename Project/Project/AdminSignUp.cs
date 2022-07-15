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
    public partial class AdminSignUp : Form
    {
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sql2Command = new SqlCommand();
            sqlconnection.Open();
            sqlCommand.Connection = sqlconnection;
            sql2Command.Connection = sqlconnection;
            sqlCommand.CommandText = "INSERT INTO SysUser (LastName, FirstName, Email, userpassword, Authority) VALUES ('" + textBox2.Text + "', '" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', 1);";
            sqlCommand.ExecuteNonQuery();   
            sql2Command.CommandText = "INSERT INTO SysAdmin (Email) VALUES ( '"+textBox3.Text+"' )";
            sql2Command.ExecuteNonQuery();
            sqlconnection.Close();
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            this.Close();
        }

        private void AdminSignUp_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
