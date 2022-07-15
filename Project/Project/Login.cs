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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp f3 = new SignUp();
            f3.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //for user sign
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sqlconnection.Open();
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
            if(v.Equals(true))
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
        private void button3_Click(object sender, EventArgs e) // for admin sign up
        {
            this.Hide();
            AdminSignUp f3 = new AdminSignUp();
            f3.ShowDialog();
            this.Close();

        }

    }

        
}

