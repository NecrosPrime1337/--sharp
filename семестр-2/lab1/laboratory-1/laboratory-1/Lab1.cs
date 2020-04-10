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
            //wall.Draw();
            Console.SetWindowSize(x, y);
            Walls wall = new Walls(x, y);
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
            menuNum = int.Parse(Console.ReadLine());
            string[] args ; 
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
            }
        }
        void var1()
        {
            
            Console.Clear();
            //попробуем нарисовать первый вариант, используя банальный for
            /*   это что? танк DENDY 8-бит? nostalgy
             *      ----
             *       ##--
             *      ----
             */

            int count;
            for (count = 1; count <= 4; count++)
            {
                p.pointer(count, 1, '-');
            }
            p.pointer(1, 2, ' ');
            for (count = 1; count <= 2; count++)
            {
                p.pointer(1 + count, 2, '#');
            }
            for (count = 1; count <= 2; count++)
            {
                p.pointer(3 + count, 2, '-');
            }
            for (count = 1; count <= 4; count++)
            {
                p.pointer(count, 3, '-');
            }
            //genius
            Console.ReadKey();
            Console.Clear();
        }
         void var2()
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
            Console.WriteLine();
            Console.WriteLine("любой тык для продолжения"); // ам сори, джаст фан
            Console.ReadKey();
        }
        void var3()
        {
            Console.Clear();
            /*   рисуем чтото
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
        
            
            Console.WriteLine();
            Console.WriteLine("любой тык для продолжения"); // ам сори, джаст фан
            Console.ReadKey();
            
        }
    }
}
