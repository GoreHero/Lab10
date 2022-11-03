using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
//Реализовать класс, в котором указанные значения представлены в виде свойств.
//Для свойств предусмотреть проверку корректности данных.
//Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
//Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool VvodCorrect;
            do
            {
                VvodCorrect = true;
                try
                {
                    Angle angle;
                    do
                    {
                        Console.Write("Градус:  ");
                        int InputGradus = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Минуты:  ");
                        int InputMinute = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Секунды: ");
                        int InputSecond = Convert.ToInt32(Console.ReadLine());

                        angle = new Angle(InputGradus, InputMinute, InputSecond);


                    }
                    while (angle.IsCorrect == false);

                    double TranslatRes = angle.ToRadians();
                    Console.Write("перевод... ");
                    Console.WriteLine("{0:f5}", TranslatRes);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    VvodCorrect = false;
                }
            }
            while (VvodCorrect==false);
            Console.ReadKey();

        }
    }
}
