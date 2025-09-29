using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_7
{
    class Student
    {
        public int age;
        public string? group;
        public string? name;
        public Student()
        {
            Console.WriteLine("Создание объекта Студент");
            name = "Неизвестно";
            age = 18;
            group = "Неизвестно";
        }
        
        public Student(string yorName) { name = yorName; name = yorName; age = 18; group = "Неизвестно"; }
        
        public Student(string yorName, int yourAge) { name = yorName; age = yourAge; group = "Неизвестно"; }
        public Student(string name, int yourAge,string yorGroup) { this.name = name; age = yourAge; group = yorGroup; }
        
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, Группа: {group}, Возраст: {age}");
        }
        public bool isAdult()
        {
            return age >= 18;
        }
    }
}
