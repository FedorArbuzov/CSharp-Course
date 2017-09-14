using System;
using System.Collections.Generic;

namespace RobotGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Field field = new Field(4, 4, "/home/fedor/robots.txt");
            field.startMoving();
            
        }
    }
}