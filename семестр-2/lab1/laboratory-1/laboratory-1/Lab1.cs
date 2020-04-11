using System;
using System.Collections.Generic;
using System.Text;

namespace laboratory_1
{
    class Lab1
    {
        static int x = 85, y = 43;
        Walls wall = new Walls(x, y);
        Point p = new Point(0, 0, ' ');
       
        public void menu()
        {
            Console.Title = "Лабораторная работа №1";
            Console.Clear();
            Console.SetWindowSize(x, y);
            wall.Draw();
            Console.SetCursorPosition(32, 20);
            Console.WriteLine("выберите вариант");
            for (int menu = 1; menu <= 6; menu++)
            {
                Console.SetCursorPosition(32, menu + 20);
                Console.WriteLine(" ({1}) Вариант № {0}", menu, menu); // мне лень расписывать все варианты 
            }
            Console.SetCursorPosition(32, 28);
            Console.WriteLine("(0) возврат в главное меню");
            int menuNum;
            Console.SetCursorPosition(2, y - 2);
            Console.Write("Ваш выбор: ");
            menuNum = int.Parse(Console.ReadLine());
            switch (menuNum)
            {
                case 1:
                    var1();
                    Program.Main();
                    break;
                case 2:
                    var2();
                    Program.Main();
                    break;
                case 3:
                    var3();
                    Program.Main();
                    break;
                case 4:
                    var4();
                    Program.Main();
                    break;
                case 5:
                    var5();
                    Program.Main();
                    break;
                case 6:
                    var6();
                    Program.Main();
                    break;
                case 0:
                    Program.Main();
                    break;
            }
        }
        void var1()
        {

            Console.Clear();
            wall.Draw();
            /*   это что? танк DENDY 8-бит? nostalgy
             *      ----
             *       ##--
             *      ----
             */

            int count;
            for (count = 2; count <= 5; count++)
            {
                p.pointer(count, 2, '-');
            }
            p.pointer(2, 3, ' ');
            for (count = 2; count <= 3; count++)
            {
                p.pointer(1 + count, 3, '#');
            }
            for (count = 2; count <= 3; count++)
            {
                p.pointer(3 + count, 3, '-');
            }
            for (count = 2; count <= 5; count++)
            {
                p.pointer(count, 4, '-');
            }
           
            Console.ReadKey();
            Console.Clear();
        }
         void var2()
        {
            Console.Clear();
            wall.Draw();
            
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
            int tmp = 0;
            for (count = 1; count <= 3; count++)
            {
                
                p.pointer(count+tmp, 2, '*');
                tmp+=1;
                p.pointer(1 + count+tmp, 2, ' ');
            }
            tmp = 0;
            for (count = 1; count <= 3; count++)
            {
                p.pointer(count+tmp, 3, '|');
                tmp += 1;
                p.pointer(1 + count+tmp, 3, ' ');
            }
         
            Console.ReadKey();
            Console.Clear();
        }
        void var3()
        {
            Console.Clear();
            wall.Draw();
            /*   рисуем что-то
             *   ()()
             *    /\
             *      
             */

            int count;
            int tmp=1;
            for (count = 1; count <= 2; count++)
            {
                
                p.pointer(count+tmp, 1, '(');
                tmp++;
                p.pointer(count+tmp, 1, ')');
                
            }
            p.pointer(3, 2, '/');      
            p.pointer(4, 2, '\\');
            Console.ReadKey();
            
        }
        void var4()
        {
            Console.Clear();
            wall.Draw();
            /*   рисуем пиццу
             *   *---*
             *    * *
             *     *
             */

            int count;
            p.pointer(2, 2, '*');
            for (count = 3; count <= 5; count++)
            {
                p.pointer(count, 2, '-');
            }
            p.pointer(6, 2, '*');
            p.pointer(3, 3, '*');
            p.pointer(4, 3, ' ');
            p.pointer(5, 3, '*');
            p.pointer(4, 4, '*');

            Console.ReadKey();

        }
        void var5()
        {
            Console.Clear();
            wall.Draw();
            /*   рисуем P
             *   |++
             *   |  +
             *   |++
             *   |
             *   |
             */

            int count;
            //p.pointer(2, 2, '*');
            for (count = 3; count <= 7; count++)
            {
                p.pointer(3, count, '|');
            }
            p.pointer(4, 3, '+');
            p.pointer(5, 3, '+');
            p.pointer(6, 4, '+');
            p.pointer(4, 5, '+');
            p.pointer(5, 5, '+');

            Console.ReadKey();

        }
        void var6()
        {
            Console.Clear();
            wall.Draw();
            /*   рисуем man
             *   ()
             *   ||
             *   /\
             */

            
            p.pointer(3, 3, '(');
            p.pointer(4, 3, ')');
            p.pointer(3, 4, '|');
            p.pointer(4, 4, '|');
            p.pointer(3, 5, '/');
            p.pointer(4, 5, '\\');

            Console.ReadKey();

        }
    }
}
