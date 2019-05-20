using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int h = 0;
            int w = 0;
            int l = 0;

            h = GetData(h, "Height");
            w = GetData(w, "Width");
            l = GetData(l, "Length");


            Dimensions b1 = new Dimensions(h, w, l);
            Console.WriteLine(b1.GetSurfaceArea());
            Console.ReadLine();
        }

        static int GetData(int num, string info)
        {
            bool check = true;
            bool confirm = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the {0} of the box: " , info);
                confirm = int.TryParse(Console.ReadLine(), out num);
                do
                {
                    if (!confirm)
                    {

                        Console.Write("\nError, Enter the {0} of the box: ", info);
                        confirm = int.TryParse(Console.ReadLine(), out num);
                    }

                } while (!confirm);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" {info} Set");
                break;
            } while (check);
            return num;
            
        }
    }

    class Dimensions
    {
        private int Hight { get; set; }
        private int Width { get; set; }
        private int Length { get; set; }

        public Dimensions(int _hight, int _width, int _length)
        {
            Hight = _hight;
            Width = _width;
            Length = _length;
            Console.WriteLine("\nBox Created");
        }

        public string GetSurfaceArea()
        {
            return $"The Total Surface Area is: {2*(Hight*Width) + 2 * (Hight * Width) + 2 * (Hight * Width)}";
        }
    }
}
