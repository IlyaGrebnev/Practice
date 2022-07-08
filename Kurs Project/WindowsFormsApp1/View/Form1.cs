using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label_back_MouseHover(object sender, EventArgs e)
        {
            label_back.Font = new Font(label_back.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_back_MouseLeave(object sender, EventArgs e)
        {
            label_back.Font = new Font(label_back.Font, FontStyle.Bold);
        }

        private void label_exit_MouseHover(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.Font = new Font(label_exit.Font, FontStyle.Bold);
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            Form Form1 = Application.OpenForms[0];
            Form1.Show();
            Form1.Location = this.Location;
            this.Hide();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            TCatalog catalog1 = new TCatalog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                catalog1.fillData(openFileDialog1.FileName);
                richTextBox.Text += catalog1.ShowCatalog() + "\n" + catalog1.ShowGenre() + "\n" + catalog1.ShowSortCatalog();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBox.Text);
                streamWriter.Close();
            }
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
