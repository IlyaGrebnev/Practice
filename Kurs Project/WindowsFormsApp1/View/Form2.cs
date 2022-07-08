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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox_information_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_launch_MouseHover(object sender, EventArgs e)
        {
            label_launch.Font = new Font(label_launch.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_launch_MouseLeave(object sender, EventArgs e)
        {
            label_launch.Font = new Font(label_launch.Font, FontStyle.Bold);
        }

        private void panel_main_MouseHover(object sender, EventArgs e)
        {

        }

        private void label_exit_MouseHover(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Bold);
        }

        private void label_launch_Click(object sender, EventArgs e)
        {
            Form1 result = new Form1();
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
