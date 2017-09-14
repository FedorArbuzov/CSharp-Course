using System;
using System.Security.Cryptography.X509Certificates;

namespace RobotGame
{
    public class Robot
    {
        
        private int ID;
        public int X, Y;
        private string MoveList;
        
        
        
        public Robot(int id, int x, int y, string moveList)
        {
            X = x;
            Y = y;
            ID = id;
            MoveList = moveList;
        }

        public bool hasNextMove()
        {
            return (MoveList != string.Empty);
        }

        public string Move()
        {
            string currentMove = Convert.ToString(MoveList[0]);
            MoveList = MoveList.Remove(0, 1);
            return currentMove;
        }

        public int getId()
        {
            return ID;
        }
        
        public void  killRobot(int id)
        {
            if (id == ID)
            {
                Console.WriteLine($"We crashed robot with ID : {ID}");
                Console.WriteLine("Now we must stop application");
            }
            // business-logic for robot killing
            
        }

    }
}