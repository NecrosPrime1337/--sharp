using System;

namespace laboratory_1
{
    
    class Program
    {
        private static readonly int x = 85;
        private static readonly int y = 43;
       
        
        static public void Menu() 
        {
            Console.Title = "Главное меню";
            Console.Clear();
            Console.SetWindowSize(x, y);
            Walls wall = new Walls(x, y);
            wall.Draw();
            Console.SetCursorPosition(32, 20);
            int menuNum;
            Console.WriteLine("выберите вариант");
            for (int menu = 1; menu <= 6; menu++)
            {
                Console.SetCursorPosition(32, menu + 20);
                Console.WriteLine(" ({1}) Лабораторная работа № {0}", menu, menu); // мне лень расписывать все варианты 

            }
            Console.SetCursorPosition(32, 28);
            Console.WriteLine("Об авторе");
            Console.SetCursorPosition(2, y - 2);
            Console.Write("Ваш выбор: ");
            menuNum = int.Parse(Console.ReadLine());
            switch (menuNum)
            {
                case 1:
                    Lab1 lab1 = new Lab1();
                    lab1.menu();
                    break;
                case 2:
                    Lab2 lab2 = new Lab2();
                    lab2.run();
                    break;
                case 3:
                    Lab3 lab3 = new Lab3();
                    lab3.menu();
                    break;
                case 4:
                    Lab4 lab4 = new Lab4();
                    lab4.run();
                    break;
                case 5:
                    Snake lab5 = new Snake(Snake.p, 4, Direction.RIGHT);
                    lab5.Run();
                    break;
                case 7:
                    //author.func not avaliable
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }

        }

        static public void Main()
        {
            Menu();

        }
    }
}
