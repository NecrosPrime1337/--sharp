using System;

namespace laboratory_1
{
    class Lab2
    {
        static int x = 85, y = 43;
        Walls wall = new Walls(x, y);
        public void run()
        {
            Console.Title = "Лабораторная работа №2";
            Console.Clear();
            wall.Draw();

            HorizontalLine h1 = new HorizontalLine(5, 14, 3, '═');
            HorizontalLine h2 = new HorizontalLine(5, 14, 7, '═');
            h1.Draw();
            h2.Draw();
            VerticalLine h3 = new VerticalLine(4, 7, 5, '*');
            VerticalLine h4 = new VerticalLine(4,  7, 14, '*');
            h3.Draw();
            h4.Draw();
            Console.ReadKey();
            Program.Main();
        }
    }
}
