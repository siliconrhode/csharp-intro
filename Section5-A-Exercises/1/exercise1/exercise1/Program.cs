﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //OneToTen();
            //MaxOfTwo();
            //PortraitOrLandscape();
            SpeedCam();

        }

        public static void OneToTen()
        {
            Console.WriteLine("Please enter a number you can represt using your hands");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput >= 1 && userinput <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void MaxOfTwo()
        {
            Console.WriteLine("Please enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The biggest number is{0}",firstNumber);
            }
            else
            {
                Console.WriteLine("The maximum number is {0}",secondNumber);
            }
        }

        public static void PortraitOrLandscape()
        {
            Console.WriteLine("Please enter your picture Length");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your picture Width");
            int width = Convert.ToInt32(Console.ReadLine());

            if (width > length)
            {
                Console.WriteLine("Landscape");
            }
            else
            {
                Console.WriteLine("Portrait");
            }
        }

        public static void SpeedCam()
        {
            Console.WriteLine("Please Enter the speed limit");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the car speed");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                int demerit = (carSpeed - speedLimit) / 5;
                if (demerit > 12)
                {
                    Console.WriteLine("Your license have been suspended");
                    
                }
                else
                {
                    Console.WriteLine("You've been given {0} demerit points",demerit);
                    
                }
            }
            else
            {
                Console.WriteLine("Ok");
            }

        }
    }
}
