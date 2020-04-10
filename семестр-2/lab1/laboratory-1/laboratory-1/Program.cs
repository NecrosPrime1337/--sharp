using System;

namespace laboratory_1
{
    
    class Program
    {
        static int x = 85, y = 43;
        static Point p = new Point(0, 0 , ' ');
        
        static void var2()
        {
            Console.Clear();
            //попробуем нарисовать первый вариант, используя банальный for
            /*   рисуем стяг
             *   -----
             *   * * *
             *   | | |   
             */

            int count;
            for (count = 1; count <= 5; count++)
            {
                p.pointer(count, 1, '-');
            }
            
            for (count = 1; count <= 3; count++)
            {
                p.pointer( count, 2, '*' );
                p.pointer(1 + count, 2, ' ');
            }
            for (count = 1; count <= 3; count++)
            {
                p.pointer(count, 3, '|');
                p.pointer(1 + count, 3, ' ');
            }
            Console.WriteLine("пресс ани кей ту маин мену"); // ам сори, джаст фан
            Console.ReadKey(); 
        }

        static public void Main()
        {
            //string[] args

            Console.SetWindowSize(x, y);
           Walls wall = new Walls(x, y);
            wall.Draw();
            Console.SetCursorPosition(32, 20);
            int menuNum;
            Console.WriteLine("выберите вариант");
            for (int menu = 1; menu <= 6; menu++)
            {
                Console.SetCursorPosition(32, menu+20);
                Console.WriteLine(" ({1}) Лабораторная работа № {0}", menu, menu); // мне лень расписывать все варианты 

            }
            Console.SetCursorPosition(32, 28);
            Console.WriteLine("Об авторе");
            Console.SetCursorPosition(2, y-2);
            menuNum = int.Parse(Console.ReadLine());

            switch (menuNum) {
                case 1:
                    Lab1 lab1 = new Lab1();
                    lab1.menu();
                //Main(args);
                    break;
                case 2:
                    Lab1 lab2 = new Lab1();
                    lab2.menu();
                    //Main(args);
                    break;
            }
           

        }
    }
}
