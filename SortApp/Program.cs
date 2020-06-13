using System;

namespace SortApp
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Введите номер дня недели: \n1-понедельник \n2-вторник \n3-среда \n4-четверг \n5-пятница \n6-суббота \n7-воскресеенье");
            int num = Convert.ToInt32 (Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine ("Понедельник. Работа до 17.00. Бег");
                    break;
                case 2:
                    Console.WriteLine ("Втоник. Работа -дом");
                    break;
                case 3:
                    Console.WriteLine ("Среда. Работа-магазин-дом");
                    break;
                case 4:
                    Console.WriteLine ("Четверг. Работа-качалка-дом");
                    break;
                case 5:
                    Console.WriteLine ("Пятница. Работа-качалка-дом");
                    break;
                case 6:
                    Console.WriteLine ("Суббота. Домашние дела, бар");
                    break;
                case 7:
                    Console.WriteLine ("Воскресенье. Жуткое  похмелье, домашние дела");
                    break;
            }
                    Console.ReadKey();
            return;

        }    
    }
}
