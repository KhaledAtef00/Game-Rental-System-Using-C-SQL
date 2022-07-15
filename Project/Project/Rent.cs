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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientView f3 = new ClientView();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filter f3 = new Filter();
            f3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rent f3 = new Rent();
            f3.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Return f3 = new Return();
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

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sqlconnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlCommand.CommandText = "INSERT INTO Rental (RMonth, GameID, Email) values ('" +textBox1.Text+ "', '" + textBox3.Text + "', '" + textBox2.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            this.Hide();
            ClientView f3 = new ClientView();
            f3.ShowDialog();
            this.Close();
        }

        private void Rent_Load(object sender, EventArgs e)
        {

        }
    }
}
