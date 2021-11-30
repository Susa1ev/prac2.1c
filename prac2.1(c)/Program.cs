using System;

namespace prac2._1_c_
{
    class Threeug
    {
        private double x = 0;
        private double y = 0;
        public Threeug()
        {
            input();
        }
        public void input()
        {
            Console.Write("Введи x "); 
            if(Double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Введи y ");
                if (Double.TryParse(Console.ReadLine(), out y))
                {
                    sravnenie();
                }
                else
                {
                    Console.WriteLine("Вы ввели что-то не то");
                    input();
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то");
                input();
            }

        }
        public void sravnenie()
        {
            if(x < 0 && x > -23 && y < 0 && y > x)
            {
                Console.Write("\tНаходится внутри функций\n");
                input();
            }
            else if (x == 0 || x == -23 || y == 0)
            {
                Console.Write("\tНаходится на функциях\n");
                input();
            }
            else
            {
                Console.Write("\tНаходится вне функций\n");
                input();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Threeug threeug = new Threeug();
        }
    }
}
