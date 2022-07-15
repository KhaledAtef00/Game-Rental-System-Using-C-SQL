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
    public partial class Filter : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public Filter()
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
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }
        private void button8_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalSystemDataSet1.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.rentalSystemDataSet1.Game);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT GameID, GameName, GameYear, Categories,VendorName FROM Game WHERE VendorName = '" + textBox1.Text + "' ",con);
            dt = new DataTable();
            sda.Fill(dt);
            gameDataGridView.DataSource = dt;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT GameID, GameName, GameYear, Categories,VendorName FROM Game WHERE GameYear = '" + textBox2.Text + "' ", con);
            dt = new DataTable();
            sda.Fill(dt);
            gameDataGridView.DataSource = dt;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BEESPEF\\MSSQLSERVER01;Initial Catalog=RentalSystem;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT GameID, GameName, GameYear, Categories,VendorName FROM Game WHERE Categories = '" + textBox3.Text + "' ", con);
            dt = new DataTable();
            sda.Fill(dt);
            gameDataGridView.DataSource = dt;
        }
    }
}
