using System;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void V1(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Выполнение варианта 1");
            Console.WriteLine("Определить время, через которое встретятся два тела, равноускоренно движущиеся навстречу друг другу,");
            Console.WriteLine("если известны их начальные скорости, ускорения и начальное расстояние между ними.");
            double sp1, sp2, a1, a2, leng, t ;
            Console.WriteLine("ожидание ввода скорости первого Sp1=");
            sp1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ожидание ввода ускорения первого а1=");                      //
            a1 = double.Parse(Console.ReadLine());                                          //  ->                                                                              <-
            Console.WriteLine("ожидание ввода скорости второго Sp2=");                      // |0_______________________________________________________________________________0|
            sp2 = double.Parse(Console.ReadLine());                                         // |<--------------------------------------leng------------------------------------->|
            Console.WriteLine("ожидание ввода ускорения второго а2=");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("расстояние  S= ");
            leng = double.Parse(Console.ReadLine());
            t = ((1 - (sp1 + sp2) - 1) + Math.Sqrt((sp1 + sp2) * (sp1 + sp2) + 2 * (a1 + a2) * leng)) / (a1 * a2);
            Console.WriteLine("время, через которое встретятся два тела составляет t={0}", t);
            Console.ReadKey();
            Main(args); // возврат в главное меню
        }
        static void V2(string[] args)
        {
            double a, b, c, s;
            Console.Clear();
            Console.WriteLine("Выполнение варианта 2");
            Console.WriteLine("Найти площадь равнобочной трапеции с основанием a и b и углом с при большем основании a.");
            Console.WriteLine("ожидание ввода большей стороны трапеции a=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("ожидание ввода меньшей стороны трапеции b=");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("ожидание ввода угла при большей стороне (в радианах) c=");
            c = double.Parse(Console.ReadLine());
            s = (Math.Pow(a,2)-Math.Pow(b,2)) / 2 * (Math.Tan(c));
            Console.WriteLine("Площадь  s={0}", s);
            Console.ReadKey();
            Main(args); // возврат в главное меню
        }

        static void V3(string[] args)
        {
            double a, b, c; // стороны треугольника 
            double ha, hb, hc, p; //длины высот с корневой переменной. Для выполнения всех заданий нам потребуется много переменных
            double ma, mb, mc; //медианы каждой из сторон
            double s, sm, sb, rm, rb; //радиусы и площади вписанной и описанной окружности
            const double pi = 3.14159265;
            Console.Clear();
            Console.WriteLine("Выполнение варианта 3");
            Console.WriteLine("Треугольник задан длинами сторон. Найти:");
            Console.WriteLine("а) длины высот;");
            Console.WriteLine("б) длины медиан");
            Console.WriteLine("в) радиусы вписанной и описанной окружностей.2. Вычислить площадь круга");

            Console.WriteLine("ожидание ввода стороны треугольника a=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("ожидание ввода стороны треугольника b=");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("ожидание ввода стороны треугольника c=");
            c = double.Parse(Console.ReadLine());
            if (a < b + c & b < a + c & c < a + b)
            {
                p = (a + b + c) / 2;
                ha = (2 / a) * Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
                hb = (2 / b) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                hc = (2 / c) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //=======================================================
                ma = 2 * (Math.Sqrt((b*b + c*c) - a*a));
                mb = 2 * (Math.Sqrt((a*a + c*c) - b*b));
                mc = 2 * (Math.Sqrt((a*a + b*b) - c*c));
            //=======================================================
                s= Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                rb = a * b * c / (4 * s);
                rm = s / p;
                sm = pi * (rm * rm);
                sb = pi * (rb * rb);
                Console.WriteLine("длины высот: ha={0} hb={0} hc={0}", ha, hb, hc);
                Console.WriteLine("длины медиан: ma={0} mb={0} mc={0}",ma,mb,mc );
                Console.WriteLine("радиусы вписанной и описанной окружностей: rm={0} rb={0}", rm, rb);
                Console.WriteLine("площади: sm={0} sb={0}", sm, sb);
                Console.ReadKey();
                Main(args); // возврат в главное меню
            }
            else
            {
                Console.WriteLine("Это не треугольник. Продолжить?");
            }
            sm = (Math.Pow(a, 2) - Math.Pow(b, 2)) / 2 * (Math.Tan(c));
            Console.WriteLine("Площадь  s={0}", sm);
        }

        static void V8(string[] args)
        {
            Console.WriteLine();
        }

        static void V16(string[] args)
        {
            double x1, x2, x3, rad;
            Console.Write("Введите значение радиуса rad=");
            rad = double.Parse(Console.ReadLine());

            const double pi = 3.1415;
            x1 = 2 * pi * rad;
            x2 = rad * rad * pi;
            x3 = pi * 0.75 * (rad * rad * rad); //можно использовать функцию Math.Pow(rad,3) для возведения в куб, но по заданию сказано низя :( 
            Console.WriteLine("длина окружности x1={0}", x1);
            Console.WriteLine("площадь круга x2={0}", x2);
            Console.WriteLine("объем шара x3={0}", x3);
            Console.Write("Нажмите любую клавишу для продолжения . . . ");
            Console.ReadKey(true);
        }
        static void autor(string[] args)
        {
            double x1, x2, x3, rad;
            Console.Write("Введите значение радиуса rad=");
            rad = double.Parse(Console.ReadLine());

            const double pi = 3.1415;
            x1 = 2 * pi * rad;
            x2 = rad * rad * pi;
            x3 = pi * 0.75 * (rad * rad * rad); //можно использовать функцию Math.Pow(rad,3) для возведения в куб, но по заданию сказано низя :( 
            Console.WriteLine("длина окружности x1={0}", x1);
            Console.WriteLine("площадь круга x2={0}", x2);
            Console.WriteLine("объем шара x3={0}", x3);
            Console.Write("Нажмите любую клавишу для продолжения . . . ");
            Console.ReadKey(true);
        }
        static void leet(string[] args)
        {
            Encoding enc = Encoding.GetEncoding(20127);
            Encoding altEnc = Encoding.GetEncoding("US-ASCII");
            Console.OutputEncoding = Encoding.ASCII;
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⢴⡶⣶⣶⣶⡒⣶⣶⣖⠢⡄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⢠⣿⣋⣿⣿⣉⣿⣿⣯⣧⡰⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⣿⣿⣹⣿⣿⣏⣿⣿⡗⣿⣿⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠟⡛⣉⣭⣭⣭⠌⠛⡻⢿⣿⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⣤⡌⣿⣷⣯⣭⣿⡆⣈⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⢻⣿⣿⣿⣿⣿⣿⣿⣷⢛⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⢻⣷⣽⣿⣿⣿⢿⠃⣼⣧⣀⠄⠄⠄⠄⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣛⣻⣿⠟⣀⡜⣻⢿⣿⣿⣶⣤⡀⠄⠄⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⢠⣤⣀⣨⣥⣾⢟⣧⣿⠸⣿⣿⣿⣿⣿⣤⡀⠄⠄⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⢟⣫⣯⡻⣋⣵⣟⡼⣛⠴⣫⣭⣽⣿⣷⣭⡻⣦⡀⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⢰⣿⣿⣿⢏⣽⣿⢋⣾⡟⢺⣿⣿⣿⣿⣿⣿⣷⢹⣷⠄");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⣿⣿⣿⢣⣿⣿⣿⢸⣿⡇⣾⣿⠏⠉⣿⣿⣿⡇⣿⣿⡆");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⣿⣿⣿⢸⣿⣿⣿⠸⣿⡇⣿⣿⡆⣼⣿⣿⣿⡇⣿⣿⡇");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠘⣿⣿⡘⣿⣿⣷⢀⣿⣷⣿⣿⡿⠿⢿⣿⣿⡇⣩⣿⡇");
            Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⢻⣷⠙⠛⠋⣿⣿⣿⣿⣿⣷⣶⣿⣿⣿⡇⣿⣿⡇");

            Console.WriteLine("");
            Console.WriteLine("┏━━┓┏┓┏┓┏━┓     ┏┓︱┏━┓┏━┓┏━━┓     ┏━━┓┏━━┓┏━━┓┏┳┓");
            Console.WriteLine("┗┓┏┛┃┗┛┃┃┳┛     ┃┃︱┃┳┛┃┳┛┗┓┏┛     ┗┓┏┛┃┏┓┃┃━━┫┃┏┛");
            Console.WriteLine("︱┃┃︱┃┏┓┃┃┻┓     ┃┗┓┃┻┓┃┻┓︱┃┃︱     ︱┃┃︱┃┣┫┃┣━━┃┃┗┓");
            Console.WriteLine("︱┗┛︱┗┛┗┛┗━┛     ┗━┛┗━┛┗━┛︱┗┛︱     ︱┗┛︱┗┛┗┛┗━━┛┗┻┛");
            Console.ReadKey(true);
            Console.OutputEncoding = Encoding.UTF8;
        }
            static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа #2" ;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("вариант 1");
            Console.WriteLine("вариант 2 ");
            Console.WriteLine("вариант 16");
            Console.WriteLine();
            Console.WriteLine("Об авторе"); //вызов функции нулем :) не мог оскорбить свое эго и не зафиксировать копирайт)))

            string menu = Console.ReadLine();
            switch (menu)
           {
                case "1":
                      V1(args);
                    break;

                case "2":
                    V2(args);
                    break;

                case "3":
                    NewMethod(args);
                    break;

                case "8":
                    V8(args);
                    break;

                case "16":
                    V16(args);
                    break;
                
                case "0":
                    autor(args);
                    break;
                case "1337":
                    leet(args);
                    break;
            }
        }

        private static void NewMethod(string[] args)
        {
            V3(args);
        }
    }
}


/*
 * 
 * 
 * Дожили.... Я ворую еду из тарелки хозяина((((
 * зачем я стал программистом???...
 *  
 *  _____
 * |МЯУ!|  ／＞　 フ
 *　---- \| 　_　 _|
 *　 　 　／`ミ _x 彡
 *　　  /　　　 　 |
 *　　 /　 ヽ　　 ﾉ
 * ／￣|　　 |　|　|
 * | (￣ヽ＿_ヽ_)_)
 * ＼二つ
 * 
 * 
 */
