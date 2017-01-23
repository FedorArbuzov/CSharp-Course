using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void Steps(); // делегат-тип

    public class Robot
    {
            // класс для представления робота     
        int x, y; // положение робота на плоскости  

        public void Right() { x++; }      // направо     
        public void Left() { x--; }      // налево     
        public void Forward() { y++; }  // вперед     
        public void Backward() { y--; }  // назад 
 
        public string Position() {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);     
        }
    }
}
