using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Text;

namespace HomeWorkExercise_2_
{
    // Класс Human - описывает человека
    internal class Human
    {
    //1. Внутренние поля класса
    protected string name; // Имя
    protected string surname; // Фамилия
    protected bool sex; // Пол: true - мужской ; false - женский

        // 2. Конструктор с 3 параметрами
        public Human(string name, string surname, bool sex)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }

        // 3. Свойства для доступа к внутренним полям класса
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        { 
            get { return surname; }
            set { surname = value; } 
        }
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        // 4. Метод Print() - выводит имена полей класса на экран
        public void Print()
        {
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("surname:{0}", surname);
            if (sex)
                Console.WriteLine("sex: Female");
            else
                Console.WriteLine("sex: Male");
        }
    }
}
