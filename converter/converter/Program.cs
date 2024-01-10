using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of liters");
            int liters = 0;
            int.TryParse(Console.ReadLine(), out liters);
            Console.WriteLine("enter 1 for fl oz \nenter 2 for gi \nenter 3 for pt \nenter 4 for qt \nenter 5 for gal \nenter 6 for tbsp \nenter 7 for tsp \nenter 8 for cup");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);
            //if(num == 1)
            //{
              //  Console.WriteLine(meters * 39 / 12 + "feet");
              //  Console.ReadLine();
            //}               
            //if (num == 2)
            //{
              //  Console.WriteLine(meters * 39 + "yards");
               // Console.ReadLine();
            //}   
            switch (num)
            {
                case 1:
                    Console.WriteLine(liters * 33.814 + "fl oz");
                    break;
                case 2:
                    Console.WriteLine(liters * 8.45351 + "gills");
                    break;
                case 3:
                    Console.WriteLine(liters * 2.113 + "pt");
                    break;
                case 4:
                    Console.WriteLine(liters * 1.057 + "qt");
                    break;
                case 5:
                    Console.WriteLine(liters / 3.785 + "gal");
                    break;
                case 6:
                    Console.WriteLine(liters * 67.628 + "tbsp");
                    break;
                case 7:
                    Console.WriteLine(liters * 202.9 + "tsp");
                    break;
                case 8:
                    Console.WriteLine(liters * 4.167 + "cups");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
