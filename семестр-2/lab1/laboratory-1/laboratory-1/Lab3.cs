using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laboratory_1
{
    class Lab3
    {
        static int x = 85, y = 43;
        Walls wall = new Walls(x, y);
        public void menu()
        {
            Console.Title = "Лабораторная работа №3";
            wall.clear();
            Console.SetWindowSize(x, y);
            Console.SetCursorPosition(32, 20);
            Console.Write("выберите вариант");
            Console.SetCursorPosition(32, 21);
            Console.WriteLine("(1) Точка");
            Console.SetCursorPosition(32, 22);
            Console.WriteLine("(2) Линия");
            Console.SetCursorPosition(32, 23);
            Console.WriteLine("(0) Возврат в главное меню");
            int menuNum;
            Console.SetCursorPosition(2, y - 2);
            Console.Write("Ваш выбор: ");
            menuNum = int.Parse(Console.ReadLine());
            switch (menuNum)
            {
                case 1:
                    this.point();
                    break;
                case 2:
                    this.line();
                    break;
                case 0:
                    Program.Main();
                    break;
            }
        }
        public void point()
        {
            Console.Clear();
            Console.SetWindowSize(x, y);
            wall.Draw();
           
            string t = "";
            Console.SetCursorPosition(2, y - 2);
            Console.Write("Введите координаты точки (через пробел):");
            t = Console.ReadLine();
            wall.clear();
            string[] tv = t.Split(' ').Where(z => z != "").ToArray();
            int AX = int.Parse(tv[0]);
            int AY = int.Parse(tv[1]);
            Point p1 = new Point(AX, AY, '*');
            Console.SetCursorPosition(2, 41);
            Console.Write("Еще раз (через пробел) :");
            t = Console.ReadLine();
            tv = t.Split(' ').Where(z => z != "").ToArray();
            AX = int.Parse(tv[0]);
            AY = int.Parse(tv[1]);
            Point p2 = new Point(AX, AY, '*');
            wall.clear();
            p1.Draw();
            p2.Draw();
            if (p1.IsHit(p2)) { Console.SetCursorPosition(2, y - 2); Console.WriteLine("точки пересекаются"); }
            else {  Console.SetCursorPosition(2, y - 2); Console.WriteLine("точки не пересекаются"); }
            Console.ReadKey();
            Program.Main();
        }
        public void line()
        {
            Console.Clear();
            Console.SetWindowSize(x, y);
            wall.Draw();

            string t = "";
            Console.SetCursorPosition(2, y - 2);
            Console.Write("Введите координаты линии (через пробел):");
            t = Console.ReadLine();
            wall.clear();
            string[] tv = t.Split(' ').Where(z => z != "").ToArray();
            int AX = int.Parse(tv[0]);
            int AY = int.Parse(tv[1]);
            int AZ = int.Parse(tv[2]);
            HorizontalLine L1 = new HorizontalLine(AX, AY, AZ, '═');
            t = "";
            Console.SetCursorPosition(2, 41);
            Console.Write("вертикальная линия (через пробел) :");
            t = Console.ReadLine();
            tv = t.Split(' ').Where(z => z != "").ToArray();
            AX = int.Parse(tv[0]);
            AY = int.Parse(tv[1]);
            AZ = int.Parse(tv[2]);
            VerticalLine L2 = new VerticalLine(AX, AY, AZ, '║');
            wall.clear();
            L1.Draw();
            L2.Draw();
            if (L1.IsHit(L2)) { Console.SetCursorPosition(2, y - 2); Console.Write("Линии пересекаются"); }
            else { Console.SetCursorPosition(2, y - 2); Console.Write("Линии не пересекаются"); }
            Console.ReadKey();
            Program.Main();
        }
    }
}
