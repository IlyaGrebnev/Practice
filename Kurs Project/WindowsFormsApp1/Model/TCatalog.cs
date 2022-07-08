using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1.Model
{
    class TCatalog : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        string nameCatalog;
        int numBooks;
        TBook[] books;
        public TCatalog()
        {
            SuspendLayout();
            ResumeLayout();
        }


        public void fillData(String path)
        {
            if(!String.IsNullOrEmpty(path) && !String.IsNullOrWhiteSpace(path))
            {
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                string name; int num; string genre; int dayDate; int monthDate; int yearDate;
                nameCatalog = sr.ReadLine();
                numBooks = int.Parse(sr.ReadLine());
                sr.ReadLine();
                books = new TBook[numBooks];
                for (int i = 0; i < numBooks; i++)
                {
                    name = sr.ReadLine();
                    num = int.Parse(sr.ReadLine());
                    genre = sr.ReadLine();
                    dayDate = int.Parse(sr.ReadLine());
                    monthDate = int.Parse(sr.ReadLine());
                    yearDate = int.Parse(sr.ReadLine());
                    DateTime date = new DateTime(yearDate, monthDate, dayDate);
                    books[i] = new TBook(name, num, genre, dayDate, monthDate, yearDate);
                    sr.ReadLine();

                }
            }
        }

        public int ShowOld()
        {
            int y = 0, q = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Age() > y)
                {
                    y = books[i].Age();
                    q++;
                }
            }
            return q;
        }

        public string ShowGenre()
        {
            int hist = 0, novel = 0, thriller = 0, fantasy = 0, adventure = 0, biograph = 0, horrors = 0;
            {
                for (int i = 0; i < books.Length; i++)
                {
                    switch ((books[i].Genre()))
                    {
                        case "History":
                            hist++;
                            break;
                        case "Novel":
                            novel++;
                            break;
                        case "Thriller":
                            thriller++;
                            break;
                        case "Fantasy":
                            fantasy++;
                            break;
                        case "Adventure":
                            adventure++;
                            break;
                        case "Biography":
                            biograph++;
                            break;
                        case "Horror":
                            horrors++;
                            break;
                    }
                }
                return "\nКоличество приключенческих книг: " + adventure + "\nКоличество биографических книг: " + biograph + "\nКоличество исторических книг: " + hist + "\nКоличество романов: " + novel + "\nКоличество триллеров: " + thriller + "\nКоличество фэнтези: " + fantasy + "\nКоличество ужасов: " + horrors; 
              
            }
        }
        public string ShowCatalog()
        {
            string s = $"Список книг в каталоге: {nameCatalog}\n";
            s += "\n";
            for (int i = 0; i < books.Length; i++)
            {
                s += books[i].ShowBook();
                s += "\n";
            }
            s += ("Самая старая книга в каталоге: " + ShowOld());
            Console.WriteLine (ShowGenre());
            Console.Write(ShowSortCatalog());
            return s;
        }
        public string ShowSortCatalog()
        {
            for (int i = 1; i < books.Length; i++)
            {
                for (int j = 0; j < books.Length - 1; j++)
                {
                    if (books[j + 1].SortCatalog() > books[j].SortCatalog())
                    {
                        
                            (books[j], books[j + 1]) = (books[j + 1], books[j]);
                    }
                }
            }
            string s = $"\nОтсортированный список книг в каталоге: {nameCatalog}\n";
            s += "\n";
            for (int y = 0; y < books.Length; y++)
            {
                s += books[y].ShowBook();
                s += "\n";
            }
            return s;
        }
    }
}

