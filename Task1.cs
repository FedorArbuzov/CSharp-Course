using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class TemperatureConverterImp
    {
        public static double Celcius(double f)
        {
            double c = 5.0 / 9.0 * (f - 32);

            return c;
        }

        public static double Fahrenheit(double c)
        {
            double f = ((9.0 / 5.0) * c) + 32;

            return f;
        }

    }

    public delegate double delegateConvertTemperature(double num);
    public delegate int[] Row(int num); // делегат-тип 
    public delegate void Print(int[] ar); // делегат-тип
    public class Example
    {
        // Метод возвращает массив цифр целого числа-параметра. 
        static public int[] GetDigits(int num)
        {
            int arLen = (int)Math.Log10(num) + 1;
            int[] res = new int[arLen];
            for (int i = arLen - 1; i >= 0; i--)
            {
                res[i] = num % 10;
                num /= 10;
            }
            return res;
        }
        // Вывод значений элементов массива-параметра. 
        static public void Display(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write("{0}\t", ar[i]);
            Console.WriteLine();
        }
    } // end of Example

    class Program
    {
        static public void test(delegateConvertTemperature dCT)
        {

            Row delRow = new Row(Example.GetDigits); // Экземпляр делегата
            Print delPrint = new Print(Example.Display); // Экземпляр делегата


            int[] myAr = delRow(13579); // Вызов метода через делегат 
            delPrint(myAr); // Вызов метода через делегат 
            int[] newAr = { 11, 22, 33, 44, 55, 66 };
            for (int i = 0; i < newAr.Length; i++)
            {
                newAr[i] = (int)dCT(newAr[i]);
            }
            delPrint(newAr); // Вызов метода через делегат
            Example.Display(myAr); // Явное обращение к методу
            Console.WriteLine("delRow casts {0}.", delRow.Method);
            Console.WriteLine("delPrint casts {0}.", delPrint.Method);
            Console.WriteLine("delRow.Target: {0}.", delRow.Target);
            Console.WriteLine("delPrint.Target: {0}.", delPrint.Target);
             
        }


        static void Main(string[] args)
        {
            delegateConvertTemperature dCT = new delegateConvertTemperature(TemperatureConverterImp.Celcius);
            test(dCT);
            dCT = new delegateConvertTemperature(TemperatureConverterImp.Fahrenheit);
            test(dCT);
            Console.ReadKey();
        }
    }
}
