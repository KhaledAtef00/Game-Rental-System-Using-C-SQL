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
    public partial class AdminView : Form
    {
        public AdminView()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddGame f3 = new AddGame();
            f3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView f3 = new AdminView();
            f3.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalSystemDataSet.Game' table. You can move, or remove it, as needed.
            this.gameTableAdapter.Fill(this.rentalSystemDataSet.Game);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile f3 = new Profile();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Q f3 = new Q();
            f3.ShowDialog();
            this.Close();
        }
    }
}
