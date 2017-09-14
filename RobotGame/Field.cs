using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security;

namespace RobotGame
{
    public class Field
    {
        public delegate void RobotBadMove(int id);

        public event RobotBadMove RobotCrashed;
        
        private readonly int  N, M;

        private bool[,] field;

        private List<Robot> robotList = new List<Robot>();
        
        public Field(int n , int m, string robotListString)
        {
            N = n;
            M = m;
            
            field = new bool[N,M];
            try
            {
                using (StreamReader sr = new StreamReader(robotListString))
                {
                    string line;
                    int id = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] args = line.Split(' ');
                        
                        robotList.Add(new Robot(id, int.Parse(args[0]), int.Parse(args[1]), args[2]));
                        if (!field[int.Parse(args[0]), int.Parse(args[1])])
                        {
                            try
                            {
                                field[int.Parse(args[0]), int.Parse(args[1])] = true;
                                id++;
                            }
                            catch(Exception ex)
                            {
                                throw new Exception("bad start params");
                            }
                        }
                        else
                        {
                            throw new Exception("bad start params");
                        }
                        
                    }

                    foreach (var robot in this.robotList)
                    {
                        RobotCrashed += robot.killRobot;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Could not read the file");
            }
        }

        

        public void startMoving()
        {

           bool allRobotsEndMove = false;
            int robotsEndMoving = 0;
            while (!allRobotsEndMove)
            {
                Console.WriteLine("New move");
                foreach (var robot in robotList)
                {
                    if (robot.hasNextMove())
                    {
                        string currentMove = robot.Move();
                        
                        int X = robot.X;
                        int Y = robot.Y;
                        
                        int new_X = X, new_Y = Y;
                        
                        switch (currentMove)
                        {
                                case "R":
                                    new_X++;
                                    break;
                                case "L":
                                    new_X--;
                                    break;
                                case "U":
                                    new_Y++;
                                    break;
                                case "D":
                                    new_Y--;
                                    break;
                        }

                        if (N <= new_Y || M <= new_X ||
                            field[new_X, new_Y] == true)
                        {
                            Console.WriteLine($" old x : {X} old y {Y} \n new x : {new_X} new y : {new_Y} \n ID : {robot.getId()}");
                            RobotCrashed(robot.getId());
                            return;
                        }
                        
                        field[X, Y] = false;
                        field[new_X, new_Y] = true;
                        
                        Console.WriteLine($" old x : {X} old y {Y} \n new x : {new_X} new y : {new_Y} \n ID : {robot.getId()}");
                        
                        robot.X = new_X;
                        robot.Y = new_Y;
                    }
                    else
                    {
                        robotsEndMoving++;
                    }
                }
                if (robotsEndMoving == robotList.Count)
                {
                    allRobotsEndMove = true;
                }
            }
            Console.WriteLine("All robots finish moves!!");
        }


    }
}