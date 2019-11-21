using System;
using System.Text;
using System.Threading;
namespace ConsoleApplication1
{
    internal class Program
    {

       
        static void V1(string[] args)

        {
            Console.Clear();
            Console.WriteLine("Выполнение варианта 1");
            Console.WriteLine("Определить время, через которое встретятся два тела, равноускоренно движущиеся навстречу друг другу,");
            Console.WriteLine("если известны их начальные скорости, ускорения и начальное расстояние между ними.");
            double sp1, sp2, a1, a2, leng, t;
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
            s = ((Math.Pow(a, 2) - Math.Pow(b, 2)) / 2 )* (Math.Tan(c));
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
                p = (a + b + c) / 2;  //полупериметр
                ha = (2 / a) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                hb = (2 / b) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                hc = (2 / c) * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                //=======================================================
                ma = 2 * (Math.Sqrt((b * b + c * c) - a * a));
                mb = 2 * (Math.Sqrt((a * a + c * c) - b * b));
                mc = 2 * (Math.Sqrt((a * a + b * b) - c * c));
                //=======================================================
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                rb = a * b * c / (4 * s);
                rm = s / p;
                sm = pi * (rm * rm);
                sb = pi * (rb * rb);
                Console.WriteLine("длины высот: ha={0} hb={0} hc={0}", ha, hb, hc);
                Console.WriteLine("длины медиан: ma={0} mb={0} mc={0}", ma, mb, mc);
                Console.WriteLine("радиусы вписанной и описанной окружностей: rm={0} rb={0}", rm, rb);
                Console.WriteLine("площади: sm={0} sb={0}", sm, sb);
                Console.ReadKey();
                Main(args); // возврат в главное меню
            }
            else
            {
                Console.WriteLine("Это не треугольник. Продолжить?");
                char ch;
                ch = char.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    V3(args);
                }
                else
                {
                    Main(args);
                }
            }

        }

        static void V8(string[] args)
        {
            Console.Clear();
            Console.WriteLine("вариант 8");
            Console.WriteLine("натуральное число X. вычислить формулу. разрешено использовать только 4 умножения, ваычитания, и сложения");  //это хардовоооо
            Console.WriteLine("значение X = ");
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = (((2 * x - 3) * x + 4) * x - 5) * x + 6; //2x^4-3x^3+4x^2-5x+6
            Console.WriteLine("ответ y={0}", y);
        }

        static void V16(string[] args)
        {
            double x1, x2, x3, rad;
            Console.Clear();
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
        static string[] colors = Enum.GetNames(typeof(ConsoleColor));
        static int indexTx = 0;
        static int indexBg = 15;
        void colored(string[] args)
        {

        }


        static void CallBack(object state)
        {
            Encoding enc = Encoding.GetEncoding(20127);
            Encoding altEnc = Encoding.GetEncoding("ASCII");
            Console.OutputEncoding = Encoding.Unicode;
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
            int rnd1 = rndNum.Next(0, 15);
            indexTx = rnd1;
            int rnd2 = rndNum.Next(0, 15);
            indexBg = rnd2;
            indexBg = rnd2;
            indexTx = (indexTx == colors.Length) ? 0 : indexTx;
            indexBg = (indexBg == colors.Length) ? 0 : indexBg;
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[indexBg]);
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[indexTx]);
            //Очистка экрана
            Console.Clear();
            Console.WriteLine("================================================================================");
            Console.WriteLine("||                                                                            ||");
            Console.WriteLine("||         ███   ████   █  █   ███   ███                                      ||");
            Console.WriteLine("||           █   █  █   █  █   █      █                                       ||");
            Console.WriteLine("||         ███   ████   ████   ███    █                                       ||");
            Console.WriteLine("||           █   █  █      █   █      █   █                                   ||");
            Console.WriteLine("||         ███   █  █      █   ███    █   █                                   ||");
            Console.WriteLine("||                                                                            ||");
            Console.WriteLine("||         ████   ████   █ █ █   ████     ██   ████   ███   ████   █          ||");
            Console.WriteLine("||         █  █   █  █   █████   █  █    █ █   █  █    █    █  █   █          ||");
            Console.WriteLine("||         █  █   █  █    ███    ████   █  █   █       █    ████   █          ||");
            Console.WriteLine("||         █  █   █  █   █████   █  █   █  █   █  █    █    █  █              ||");
            Console.WriteLine("||         █  █   ████   █ █ █   █  █   █  █   ████    █    █  █   █          ||");
            Console.WriteLine("||                                                                            ||");
            Console.WriteLine("================================================================================");

        }
        static void autor(string[] args)
        {

            Console.WriteLine("Работу выполнил студент группы 19хз1");
            Console.WriteLine("");
            Console.WriteLine("мое имя низя называть");
            Console.WriteLine("https://github.com/NecrosPrime/--sharp");
            Console.WriteLine("https://vk.com/0x000000000f");
            Console.WriteLine("нажмите любую кнопку для открытия пасхалочки...");

            Console.ReadKey(true);
            Console.Title = "Зачет пжалста";
            Timer myTimer = new Timer(new TimerCallback(CallBack), null, 0, 400); //таймер для пасхалочки
            Console.ReadLine();
        }


        static void Main(string[] args)
        {

            Console.Title = "Лабораторная работа #2"; //меняем заголовок окна
            Console.ForegroundColor = ConsoleColor.Cyan; //меняем цвет. думаю светло-синий на черном фоне смотрится лучше, чем черно-белый 
            Console.Clear();
            Console.WriteLine("вариант 1");
            Console.WriteLine("вариант 2 ");
            Console.WriteLine("вариант 3");
            Console.WriteLine("вариант 8");
            Console.WriteLine("вариант 16");
            Console.WriteLine();
            Console.WriteLine("Об авторе (0)"); //вызов функции нулем :) не мог оскорбить свое эго и не зафиксировать копирайт)))

            string menu = Console.ReadLine();
            NewMethod1(args, menu);
        }

        private static void NewMethod1(string[] args, string menu)
        {
            switch (menu)
            {
                case "1":           //первые 3 варианта
                    V1(args);
                    break;

                case "2":
                    V2(args);
                    break;

                case "3":
                    V3(args);
                    break;

                case "8":           //мой вариант
                    V8(args);
                    break;

                case "16":          //рандомный вариант
                    V16(args);
                    break;

                case "0":           //вызов функции об авторе
                    autor(args);
                    break;
                    /*case "1337":       //здесь должна быть пасхалочка, но пожалуй не буду.
                        leet(args);
                       break;
                       */

            }
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
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 *  static void leet(string[] args)
          {

              Console.OutputEncoding = System.Text.Encoding.GetEncoding(65001); //Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(" █████████████████████████ ");
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
 */
