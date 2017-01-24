/*
 * Арбузов Федор БПИ151
 * Вариант 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    delegate bool Srav(double user_value, Circle c);
    class Program
    {
        static void Main(string[] args)
        {

            //  ананимный метод для сравнения
            Srav Csrav = delegate (double user_value_new, Circle c) {
                if (c.Sq() > user_value_new)
                {
                    return true;
                }
                else {
                    return false;
                }
            };


            // вывод всех кругов
            Console.WriteLine("все 15");
            Circle[] arr = new Circle[15];
            for (int i = 0; i < 15; i++) {
                Random rd = new Random();
                arr[i] = new Circle(rd.Next(-10, 11), rd.Next(-10, 11), rd.Next(0, 8));
            };
            for (int i = 0; i < 15; i++) {
                Console.WriteLine(arr[i]);
            }
            
            // ввод значения дял отбора
            double user_value = 0;
            do {
                Console.WriteLine("Введите значения для отбора");
            }while(!Double.TryParse(Console.ReadLine(), out user_value));

            // вывод после фильтрации
            Console.WriteLine("после фильтрации ");
            for (int i = 0; i < 15; i++) {
                if (Csrav(user_value, arr[i])){
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
