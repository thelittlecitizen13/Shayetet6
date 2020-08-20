using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace Shayetet6
{
    class UserInputValidator
    {
        public static int ReadIntParser()
        {
            int choice = 0;
            while (0 >= choice)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input, please try again:");
                }
                if (choice < 0)
                    Console.WriteLine("Wrong input, please try again:");
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
            //Console.WriteLine(output);
            //Console.WriteLine("[" + String.Join(" / " , Enum.GetNames(typeof(MissileTypes))) + "]");
            int count = 1;
            Dictionary<int, string> missileTypes = new Dictionary<int, string>();
            foreach (string mtype in Enum.GetNames(typeof(MissileTypes)))
            {
                missileTypes.Add(count, mtype);
                count++;
            }
            LauncherMenuRunner.PrintMenuFromDict<int, string>(missileTypes, output);
            return UserInputValidator.GetChoiceOfDictionary<int, string>(missileTypes);
           
        }
        public static T GetChoiceOfDictionary<K, T>(Dictionary<int, T> dict)
        {
            int choice;
            bool contain;
            do
            {
                choice = ReadIntParser();
                contain = dict.ContainsKey(choice);
                if (!contain)
                    Console.WriteLine("Choice doesnt exist, please try again:");
            }
            while (!contain);
            return dict[choice];
        }
        public static int CalculateDistance(int maxDistance, string TargetMissile = "war")
        {
            Console.WriteLine($"Please enter the target`s distance for missile {TargetMissile} (1-{maxDistance}):");
            int distance = UserInputValidator.ReadIntParser();

            while (distance > 1500)
            {
                Console.WriteLine($"Distance cannot be above {maxDistance}km. Please try again:");
                distance = UserInputValidator.ReadIntParser();
            }
            return distance;
        }
        
    }
}
