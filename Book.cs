using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    internal class Book
    {
        string? Title;
        string? Author;
        int Year;
        bool IsAvailable;

        public Book()
        {
            Title = "Неизвестно";
            Author = "Неизвестен";
            Year = 0;
            IsAvailable = false;
        }
        public Book(string? Title, string? Author, int Year, bool IsAvaiable)
        {
            this.Title = Title; this.Author = Author;
            this.Year = Year; this.IsAvailable = IsAvaiable;
        }
        public void Print()
        {
            Console.WriteLine($"Название: \"{Title}\", Автор: {Author}, Год: {Year}, Доступна: {IsAvailable}");
        }

    }
}
