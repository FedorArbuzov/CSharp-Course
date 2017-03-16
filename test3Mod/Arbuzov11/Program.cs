// Арбузов Федор 11

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LibraryForCylinder;

namespace Arbuzov11
{
    class Program
    {

        private static List<Cylinder>  lCyl = new List<Cylinder>();


        public  static void Command1() {

            try{
            StreamReader sr = new StreamReader(@"C:\Users\student\Desktop\Файл_1.txt");


            String s = sr.ReadToEnd();


            //Console.WriteLine(s);

            Char[] forSp = new Char[1] { '\n' };

            String[] arr = s.Split(forSp);

           

            for (int i = 0; i < arr.Length; i++)
            {

                    //Console.WriteLine(arr[i]);

                    Char[] forSpStr = new Char[1] { ' ' };
                    String[] twoN = arr[i].Split(forSpStr);

                    lCyl.Add(new Cylinder(double.Parse(twoN[0]), double.Parse(twoN[1])));
                


            }
            for (int i = 0; i < lCyl.Count; i++)
            {
                Console.WriteLine(lCyl[i]);
            }

            Console.ReadKey();
        }
            catch (Exception e)
            {
                Console.WriteLine("Были даны плохие данные");
                Console.ReadKey();
            }

        }

        public static void Command2() {
            double H = 0;
            double R = 0;
            do
            {

                Console.WriteLine("Введите H");

            } while (!double.TryParse(Console.ReadLine(), out H));

            do
            {

                Console.WriteLine("Введите R");

            } while (!double.TryParse(Console.ReadLine(), out R));

            lCyl.Add(new Cylinder(H, R));
            for (int i = 0; i < lCyl.Count; i++)
            {
                Console.WriteLine(lCyl[i]);
            }

            Console.ReadKey();
        }

        public static void Command3() {
            StreamWriter sw = new StreamWriter(@"C:\Users\student\Desktop\Файл_2.txt");

            for (int i = 0; i < lCyl.Count; i++) {
                sw.WriteLine(lCyl[i].forFile());
            }

            sw.Close();
        }

        public static void Command4() {

            int fileI = 0;
            do
            {

                Console.WriteLine("Введите 1 или 2 для выбора файла ");

            } while (!Int32.TryParse(Console.ReadLine(), out fileI) || (fileI > 2) || (fileI < 1));

            string fileName = @"C:\Users\student\Desktop\Файл_" + Convert.ToString(fileI)+ ".txt";

            StreamReader sr = new StreamReader(fileName);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);

        }

        public static void Command5() {
            for (int i = 0; i < lCyl.Count; i++)
            {
                Console.WriteLine(lCyl[i]);
            }
        }

        public static void Command6() {

            Console.WriteLine("Тут должна быть сортировка");

        }



        static void Main(string[] args)
        {
            try
            {
                int userRes = 0;

                do
                {
                    do
                    {

                        Console.WriteLine("Выберете любое число от 1 до 6 или 7 для выхода ");

                    } while (!Int32.TryParse(Console.ReadLine(), out userRes) || (userRes > 7) || (userRes < 1));

                    Console.WriteLine("Вы выбрали " + userRes);

                    if (userRes == 1) { Command1(); }
                    else
                        if (userRes == 2) { Command2(); }
                        else
                            if (userRes == 3) { Command3(); }
                            else
                                if (userRes == 4) { Command4(); }
                                else
                                    if (userRes == 5) { Command5(); }
                                    else
                                        if (userRes == 6) { Command6(); }
                }
                while (userRes != 7);
            }
            catch (Exception ex) {
                Console.WriteLine("Были введены плохие данные ");
            }
            Console.WriteLine("Вы закончили выполнение программы, нажмите любую клавишу");
            Console.ReadKey();



        }
    }
}
