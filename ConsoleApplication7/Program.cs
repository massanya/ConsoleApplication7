using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Massive();
            Console.ReadLine();
            
        }
        public static int[,] Massive()
        {

            int[,] mass = new int[3, 3];
            printMassive(mass);
            MassiveZna4(mass);
            Console.WriteLine();
            printMassive(mass);
            return mass;
        }
        static Random rnd = new Random();
        public static void printMassive(int[,] mass)
        {
           for (int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    Console.Write($"{mass[i, j]} ");
                }
                Console.WriteLine();
                
            } 
              
        }
        public static void MassiveZna4(int[,] mass)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mass[i, j] = rnd.Next(100);
                    
                }
                

            }

        }
    }
}
