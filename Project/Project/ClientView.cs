using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f3 = new Login();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalSystemDataSet.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.rentalSystemDataSet.Game);

        }

        private void button2_Click_1(object sender, EventArgs e)
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
            Return  f3 = new Return();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile f3 = new Profile();
            f3.ShowDialog();
            this.Close();
        }
    }
}
