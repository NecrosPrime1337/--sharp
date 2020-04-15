using System;
using System.Collections.Generic;
using System.Text;

namespace laboratory_1
{
    
    class Lab4
    {
        static int x = 85, y = 43;
        Walls wall = new Walls(x, y);
        Point p = new Point(0, 0, ' ');
        public void run()
        {
            Console.Title = "Лабораторная работа №4";
            Console.Clear();
            wall.Draw();
            Console.SetCursorPosition(2, y - 2);
            Console.Write("Игровое поле сгенерировано. любая кнопка для возврата в главное меню");
            Console.ReadKey();
            Program.Main();
        }
    }
}
