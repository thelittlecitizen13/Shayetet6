using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shayetet6
{
    class UserInputValidator
    {
        public static int ReadIntParser()
        {
            int choice = 0;
            while (choice == 0)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input, please try again:");
                }
            }
            return choice;
        }

        public static double ReadDoubleParser()
        {
            double choice = 0;
            while (choice == 0)
            {
                try
                {
                    choice = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input, please try again:");
                }
            }
            return choice;
        }
        public static string ReadMissileTypeName(string output)
        {
            Console.WriteLine(output);
            Console.WriteLine("[" + String.Join(" / " , Enum.GetNames(typeof(MissileTypes))) + "]");
            string type= "";
            bool correct = false;
            while (!correct)
            {
                type = Console.ReadLine();
                if (!(Enum.GetNames(typeof(MissileTypes)).Contains(type)))
                    Console.WriteLine("Type not exist. Please try again:");
                else
                    correct = true;
            }
            return type;

        }
        
    }
}
