using System;

namespace Lesson4_03
{
    enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn,
        None,
    }

    class Class1
    {
        // Написать метод по определению времени года. На вход подаётся число
        // – порядковый номер месяца. На выходе — значение из перечисления (enum)
        // — Winter, Spring, Summer, Autumn. Написать метод, принимающий на вход
        // значение из этого перечисления и возвращающий название времени года
        // (зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры
        // номер месяца и вывести название времени года. Если введено некорректное
        // число, вывести в консоль текст «Ошибка: введите число от 1 до 12».


        static void Main(string[] args)
        {

            Console.Write("Введите номер текущего месяца -> ");
            int num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 1 || num > 12)
                {
                    Console.Write("Число должно быть в диапазоне 1..12");
                }
            }
            while (num < 1 || num > 12);
            Season season = GetSeason(num);
            Console.WriteLine("Время года" + GetSeason(season));
            Console.WriteLine();
        }



        static Season GetSeason(int num)
        {
            Season season = Season.None;


            switch (num)
            {
                case 12:
                case 1:
                case 2:
                    season = Season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    season = Season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    season = Season.Autumn;
                    break;
                case 9:
                case 10:
                case 11:
                    season = Season.Spring;
                    break;

            }

        }
    }
}
