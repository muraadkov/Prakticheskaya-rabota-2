using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakticheskaya_rabota_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.    Вычисления значения функции y=7x^2-3x+4  при любом значении x;
            //Console.WriteLine("Введите значение x");
            //int x = int.Parse(Console.ReadLine());
            //int y = (7 * (x * x)) - (3 * x) + 4;
            //Console.WriteLine("y =" + y);
            //Console.ReadLine();
            /////////////////////////////////////////
            //2.	Дан радиус окружности. Найти длину окружности и площадь круга.
            //Console.WriteLine("Введите радиус: ");
            //int R = int.Parse(Console.ReadLine());
            //var C = 2 * R * Math.PI;
            //var S = Math.PI * (R * R);
            //Console.WriteLine("Длина окружности: " + C);
            //Console.Write("Площадь круга: " + S);
            //Console.Read();
            /////////////////////////////////////////
            //3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
            //Console.WriteLine("Введите расстояния в сантиметрах: ");
            //int distance = int.Parse(Console.ReadLine());
            //var metr = distance * 0.01;
            //Console.Write("Полных метров в сантиметрах: " + metr);
            //Console.Read();
            /////////////////////////////////////////
            //4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            //int day = 234;
            //int week = 7;
            //int weekall = day / week;
            //Console.Write("Полных недель в 234 дней: " + weekall);
            //Console.Read();
            /////////////////////////////////////////
            //5.	Дано двузначное число. Найти:
            //a.число десятков в нем;
            //b.число единиц в нем;
            //c.сумму его цифр;
            //d.произведение его цифр

            //Console.WriteLine("Введите двузначное число: ");
            //int num = int.Parse(Console.ReadLine());
            //int desyatki = num / 10;
            //int edinic = num % 10;
            //int sum = desyatki + edinic;
            //int proizv = desyatki * edinic;
            //Console.WriteLine("Число десятков в вашем числе: " + desyatki);
            //Console.WriteLine("Число единиц в вашем числе: " + edinic);
            //Console.WriteLine("Сумма цифр в вашем числе: " + sum);
            //Console.WriteLine("Произведение цифр в вашем числе: " + proizv);
            //Console.Read();
            ////////////////////////////////////////
            //6.	Дано четырехзначное число. Найти:
            //a.сумму его цифр;
            //b.произведение его цифр.

            //Console.WriteLine("Введите четырёхзначное число: ");
            //int num = int.Parse(Console.ReadLine());
            //int tisyachi = num / 1000;
            //int sotni = num % 1000 / 100;
            //int desyatki = num % 100 / 10;
            //int edinic = num % 10;
            //int sum = tisyachi + sotni + desyatki + edinic;
            //int proizv = tisyachi * sotni * desyatki * edinic;
            //Console.WriteLine("Сумма цифр в вашем числе: " + sum);
            //Console.WriteLine("Произведение цифр в вашем числе: " + proizv);
            //Console.Read();
            ////////////////////////////////////////
            //7.	В трехзначном числе x зачеркнули его вторую цифру. 
            //Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, 
            //то получилось число 456. Найти число x.

            //var num = 456;
            //var b = num % 10;
            //var a = num / 100;
            //var c = (num / 10) % 10;
            //num = 100 * a + 10 * b + c;
            //Console.WriteLine("x = " + num);
            //Console.ReadLine();
            ////////////////////////////////////////
            ///8.	Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
            //a.не X и не Y;
            //b.X или(не X и Y);
            //c.  (не X и Y) или Y.

            //var X = false;
            //var Y = true;
            //Console.WriteLine("Сначала сделаем с X - false, Y - true");
            //if(!X && !Y)
            //{
            //    Console.WriteLine("!X && !Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("!X && !Y - False");
            //}
            //if(X || (!X && Y))
            //{
            //    Console.WriteLine("X || (!X && Y) - True");
            //}
            //else
            //{
            //    Console.WriteLine("X || (!X && Y) - False");
            //}
            //if((!X && Y) || Y)
            //{
            //    Console.WriteLine("(!X && Y) || Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("(!X && Y) || Y - False");
            //}
            //X = true;
            //Y = false;
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Сейчас делаем с X - true, Y - false");
            //if (!X && !Y)
            //{
            //    Console.WriteLine("!X && !Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("!X && !Y - False");
            //}
            //if (X || (!X && Y))
            //{
            //    Console.WriteLine("X || (!X ^&& Y) - True");
            //}
            //else
            //{
            //    Console.WriteLine("X || (!X ^&& Y) - False");
            //}
            //if ((!X && Y) || Y)
            //{
            //    Console.WriteLine("(!X && Y) || Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("(!X && Y) || Y - False");
            //}

            //X = true;
            //Y = true;
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Тут с X - true, Y - true");
            //if (!X && !Y)
            //{
            //    Console.WriteLine("!X && !Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("!X && !Y - False");
            //}
            //if (X || (!X && Y))
            //{
            //    Console.WriteLine("X || (!X ^&& Y) - True");
            //}
            //else
            //{
            //    Console.WriteLine("X || (!X ^&& Y) - False");
            //}
            //if ((!X && Y) || Y)
            //{
            //    Console.WriteLine("(!X && Y) || Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("(!X && Y) || Y - False");
            //}
            //X = false;
            //Y = false;
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("A тут с X - false, Y - false");
            //if (!X && !Y)
            //{
            //    Console.WriteLine("!X && !Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("!X && !Y - False");
            //}
            //if (X || (!X && Y))
            //{
            //    Console.WriteLine("X || (!X ^&& Y) - True");
            //}
            //else
            //{
            //    Console.WriteLine("X || (!X ^&& Y) - False");
            //}
            //if ((!X && Y) || Y)
            //{
            //    Console.WriteLine("(!X && Y) || Y - True");
            //}
            //else
            //{
            //    Console.WriteLine("(!X && Y) || Y - False");
            //}
            //Console.Read();
        }
    }
}
