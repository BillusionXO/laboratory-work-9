using System;

namespace HomeWorkExercise_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Использование экземпляра класса Human
            Human hm = new Human("Anton", "Chainikov", false);
            hm.Print();

            // 2. Использование экземпляра класса Citizen
            Citizen ct = new Citizen("Nikita", "Frolow", false, "A101ksd1233", "Moscow, Billikova 11");
            Console.WriteLine("------------------------");
            ct.Print(); // вывести значение полей класса

            // 3. Использование экземпляра класса ForeignCitizen
            ForeignCitizen fc = new ForeignCitizen("Alekseev", "Aleksey", false, "0230902ADK", "Omsk, pashakova 3", "023329032JJK",
            Convert.ToDateTime("02.02.2020"), Convert.ToDateTime("03.03.2020"));
            Console.WriteLine("------------------------");
            fc.Print();
        }
    }
}
