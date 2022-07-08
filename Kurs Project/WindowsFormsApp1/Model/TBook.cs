using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1.Model
{
    class TBook
    {
        string name;
        int num;
        string genre;
        int dayDate;
        int monthDate;
        int yearDate;
        public TBook(string name, int num, string genre, int dayDate, int monthDate, int yearDate)
        {
            this.name = name;  
            this.num = num;
            this.genre = genre;
            this.dayDate = dayDate;
            this.monthDate = monthDate;
            this.yearDate = yearDate;
        }
        public int Age()
        {
            DateTime date = new DateTime(yearDate, monthDate, dayDate);
            DateTime now = DateTime.Today;
            int age = now.Year - date.Year;
            now = now.AddYears(-age);
            if (date > now) age--;
            return age;
        }
        public string Genre()
        {
            return genre;
        }
        public string ShowBook()
        {
            string s = $"Название: {name}\n";
            s += $"Количество страниц {num}\n";
            s += $"Жанр: {genre}\n";
            s += $"Дата выпуска: {dayDate}.{monthDate}.{yearDate}\n";
            s += $"Возраст книги: { Age()}\n";
            return s;
        }
        public int SortCatalog()
        {
            return num;
        }
        public string Name()
        {
            return name;
        }
    }
}
