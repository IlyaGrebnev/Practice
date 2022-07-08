using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            try
            {
                TCatalog catalog1 = new TCatalog();
                Console.WriteLine(catalog1.ShowCatalog());
                Console.WriteLine(catalog1.ShowSortCatalog());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
