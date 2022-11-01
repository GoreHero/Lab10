using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock;
            do
            {
                Console.Write("Часы: ");
                int hour_ = Convert.ToInt32(Console.ReadLine());
                Console.Write("минуты: ");
                int minute_ = Convert.ToInt32(Console.ReadLine());
                Console.Write("Секунды: ");
                int second_ = Convert.ToInt32(Console.ReadLine());

                clock = new Clock(hour_, minute_, second_);
            }
            while (clock.isCorrect == false);

            //Clock clock = new Clock() { hour = hour_,minute=minute_,second=second_}; //Конструктор

            //clock.hour = Convert.ToInt32(Console.ReadLine());
            //clock.minute = Convert.ToInt32(Console.ReadLine());
            //clock.second = Convert.ToInt32(Console.ReadLine());

            int totalSecond = clock.ToSecond();
            Console.Write("Расчет: ");
            Console.WriteLine(totalSecond);
            Console.ReadKey();
        }
       
    }

}
