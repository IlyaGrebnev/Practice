using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label_start_MouseHover(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Underline | FontStyle.Bold); ;
        }

        private void label_start_MouseLeave(object sender, EventArgs e)
        {
            label_start.Font = new Font(label_start.Font, FontStyle.Bold);
        }

        private void label_information_MouseHover(object sender, EventArgs e)
        {
            label_information.Font = new Font(label_information.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_information_MouseLeave(object sender, EventArgs e)
        {
            label_information.Font = new Font(label_information.Font, FontStyle.Bold);
        }

        private void label_exit_MouseHover(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Bold);
        }

        private void label_start_Click(object sender, EventArgs e)
        {
            Form1 result = new Form1();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label_information_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
