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
    public partial class Q : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Q()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT GameName FROM Game WHERE GameID IN (SELECT TOP 1 GameID FROM Rental GROUP BY GameID ORDER BY Count(GameID) DESC)", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT GameName FROM Game WHERE GameID NOT IN ( SELECT GameID FROM Rental WHERE RMonth =3 )", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT VendorName FROM Game WHERE GameID IN(SELECT TOP 1 GameID FROM Rental WHERE RMonth = 3 GROUP BY GameID ORDER BY Count(GameID) DESC)", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT VendorName FROM Vendor WHERE VendorName NOT IN ( SELECT VendorName FROM Game WHERE GameID IN ( SELECT GameID FROM Rental WHERE RMonth =3))", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT VendorName FROM Vendor WHERE VendorName NOT IN( SELECT VendorName FROM Game WHERE GameYear = 2021)", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT FirstName, LastName FROM SysUser WHERE Email IN (SELECT TOP 1 Email FROM Rental WHERE RMonth = 3 GROUP BY Email ORDER BY Count(Email) DESC)", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
