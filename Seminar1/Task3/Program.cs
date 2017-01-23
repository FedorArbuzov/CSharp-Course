using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot();    // конкретный робот  
            Steps[] trace = { new Steps(rob.Forward),                            
                                new Steps(rob.Backward),                            
                                new Steps(rob.Left),
                                new Steps(rob.Right)}; // сообщить координаты 
            Char[] code = {
                                'F', 'B', 'L', 'R'
                            };
            Console.WriteLine("Start:" + rob.Position());       
            for (int i = 0; i < trace.Length; i++) {
                Console.WriteLine("Method={0}, Target={1}",     trace[i].Method, trace[i].Target);
                trace[i](); 
            }

            

            Console.WriteLine(rob.Position());     // сообщить координаты
            string path = Console.ReadLine();
            Steps delMain = null;
            for (int i = 0; i < path.Length; i++) {
                delMain += trace[Array.IndexOf(code, path[i])];
            }
            delMain();
            Console.WriteLine(rob.Position());     // сообщить координаты
            Console.ReadKey();
        }
    }
}
