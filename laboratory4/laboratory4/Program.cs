using System;

namespace laboratory4
{
    class Program
    {
        public static int menu;
        public static int l = 0;

        static void var1(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Вариант 1:");
            Console.WriteLine("(1)Вычислить n!:");
            Console.WriteLine("(2)Подсчитать количество нулевых элементов кортежа");
            Console.WriteLine("(3)Определить количество элементов матрицы, значения которых не превышают заданное число.");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("введите n=");
                        double ni = 1; int i, n;
                        n = int.Parse(Console.ReadLine());
                        for (i = 0; i < n; i = i + 1)
                        { ni = ni * (i + 1); }

                        Console.WriteLine("n!={0}", ni);
                        Console.ReadKey();
                        Main(args);
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("какие аргументы вы хотите использовать?");
                        Console.WriteLine("длина кортежа (по умолчанию = random(3-20))");

                        try
                        {
                            l = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            l = rndNum.Next(-10, 10);
                            Console.WriteLine("Великий рандом назначил кортеж c {0} значениями", l);
                        }

                        double[] cortege = new double[l];


                        for (int i = 0; i < l; i++)
                        {
                            Console.WriteLine("введите значения кортежа (по умолчанию = random)");
                            try
                            {
                                cortege[i] = int.Parse(Console.ReadLine());

                            }
                            catch
                            {
                                int x;
                                Random rndNum = new Random();
                                x = rndNum.Next(-10, 10);

                                cortege[i] = x;
                            }

                        }
                        int zero = 0;
                        for (int i = 0; i < l; i++)
                        {

                            Console.Write("{0} ", cortege[i]);
                            if (cortege[i] == 0)
                            {
                                zero = zero + 1;
                            }
                        }
                        Console.WriteLine("в кортеже найдено {0} нулевых значений", zero);
                        Console.ReadKey();
                        Main(args);
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Введите размеры матрицы: ");
                        int str = int.Parse(Console.ReadLine());
                        int slb = int.Parse(Console.ReadLine());
                        var randNum = new Random();
                        int[,] matrix = new int[str, slb];
                        Console.WriteLine();
                        // Заполнение массива случайными числами
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[i, j] = randNum.Next(1, 54);
                                Console.Write("||{0}", matrix[i, j] + "\t");
                            }
                            Console.WriteLine("===========================================================================");
                        }
                        Console.WriteLine();

                        // Поиск максимального значения, составление ногово массива и вывод его на экран

                        int[] newArr = new int[str];
                        for (int i = 0; i < matrix.GetLength(1); i++)
                        {
                            int maxNum = 0;
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                if (matrix[i, j] > maxNum)
                                    maxNum = matrix[i, j];
                            }
                            newArr[i] = maxNum;
                            Console.WriteLine(newArr[i] + "\t");
                            Console.WriteLine("-----");
                        }

                        Console.ReadLine();
                        Main(args);
                    }
                    break;
            }
        }
        static void var2(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Вариант 1:");
            Console.WriteLine("(1)Вычислить непонятную формулу:");
            Console.WriteLine("(2)Подсчитать сумму нечетных элементов кортежа");
            Console.WriteLine("(3)Найти минимальный элемент матрицы n x m");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("вычисление с пределами");
                        Console.WriteLine("чему равен верхний предел? (рандом от 3 до 20)");
                        int upper;
                        try
                        {
                            upper = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            upper = rndNum.Next(3, 20);
                            Console.WriteLine("Великий рандом назначил {0} верхним пределом", upper);
                        }
                        Console.WriteLine("чему равно значение Х? (рандом от -100 до 100)");
                        int x=0;
                        try
                        {
                            x = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            x = rndNum.Next(-100, 100);
                            Console.WriteLine("Великий рандом назначил {0} ", x);
                        }
                        finally
                        {
                            double answ = 0, answTmp = 0;
                            for (int lower = 0; lower < upper; lower = lower + 1)
                            {
                                answTmp = lower * x;
                                answ = answTmp + answ;

                            }
                            Console.WriteLine("после долгих размышлений сумма ряда с пределами -1 {0} и формулой ix = {0}", upper, answ);
                            Console.ReadKey();
                            Main(args);
                        }
                    }
                    break;
            }
        }
        static void var3(string[] args)
        {

        }
        static void var4(string[] args)
        {

        }
        static void var5(string[] args)
        {

        }
        static void var6(string[] args)
        {

        }
        static void var7(string[] args)
        {

        }
        static void var8(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Вариант 8:");
            Console.WriteLine("(1)Вычислить непонятную формулу:");
            Console.WriteLine("(2)Подсчитать количество отрицательных и положительных элементов кортежа");
            Console.WriteLine("(3)Сформировать массив В, содержащий сумму элементов каждого столбца матрицы А");
            Console.WriteLine("(4)Выход в главное меню");
            try
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ошибка ввода, попробуйте еще раз");
                Console.ReadKey();
                var16(args);
            }
            switch (menu)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("вычисление с пределами");
                        Console.WriteLine("чему равен верхний предел? (рандом от 3 до 20)");
                        int upper;
                        try
                        {
                            upper = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            upper = rndNum.Next(3, 20);
                            Console.WriteLine("Великий рандом назначил {0} верхним пределом", upper);
                        }
                        Console.WriteLine("чему равно значение Х? (рандом от -100 до 100)");
                        double x;
                        try
                        {
                            x = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            x = rndNum.Next(1, 10);
                            Console.WriteLine("Великий рандом назначил x={0} ", x);
                        }
                        double answ = 1, answTmp = 0;
                        for (int lower = 1; lower <= upper; lower++)
                        {
                            answTmp = lower + x;
                            answ = answTmp * answ;
                        }
                        Console.WriteLine("после размышлений произведение ряда с пределами 1-{0} и формулой i+x = {1}", upper, answ);
                        Console.ReadKey();
                        Main(args);
                    }
            
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("какие аргументы вы хотите использовать?");
                        Console.WriteLine("длина кортежа (по умолчанию = random(3-20))");
                        int l;
                        try
                        {
                            l = int.Parse(Console.ReadLine());
                        }
                        catch
                        {

                            Random rndNum = new Random();
                            l = rndNum.Next(3, 20);
                            Console.WriteLine("Великий рандом назначил кортеж c {0} значениями", l);
                        }
                        double[] cortege = new double[l];
                        
                        int min=0, max=0, zero=0;
                        for (int index = 0; index < cortege.Length; index++)
                        {
                            Console.WriteLine("введите значения кортежа (по умолчанию = random)");
                            try
                            {
                                cortege[index] = int.Parse(Console.ReadLine());
                                if (cortege[index] > 0)
                                {
                                    max++;
                                }
                                if (cortege[index] < 0)
                                {
                                    min++;
                                }
                                if (cortege[index] == 0)
                                {
                                    zero++;
                                }
                            }
                            catch
                            {
                                Random rndNum = new Random((int)DateTime.Now.Ticks);
                                cortege[index] = rndNum.Next(-100, 100);
                                if (cortege[index] > 0)
                                {
                                    max++;
                                }
                                if (cortege[index] < 0)
                                {
                                    min++;
                                }
                                if(cortege[index] == 0)
                                {
                                    zero++;
                                }
                            }
                        }
                        for (int index = 0; index < cortege.Length; index++)
                        {
                            Console.Write("{0} ", cortege[index]);
                        }
                        Console.WriteLine(" \n в кортеже найдено {0} отрицательных, {1} положительных, {2} равных нулю ", min, max, zero);
                        Console.ReadKey();
                        Main(args);

                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Введите размеры массива: ");
                        int str = int.Parse(Console.ReadLine());
                        int slb = int.Parse(Console.ReadLine());
                        var randNum = new Random();
                        int[,] matrix = new int[str, slb];
                        Console.WriteLine();
                        // Заполнение массива случайными числами
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[i, j] = randNum.Next(1, 54);
                                Console.Write("||{0}", matrix[i, j] + "\t");
                            }
                            Console.WriteLine("===========================================================================");
                        }
                        Console.WriteLine();

                        // Поиск максимального значения, составление ногово массива и вывод его на экран

                        int[] newArr = new int[str];
                        for (int i = 0; i < matrix.GetLength(1); i++)
                        {
                            int maxNum = 0;
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                if (matrix[i, j] > maxNum)
                                    maxNum = matrix[i, j];
                            }
                            newArr[i] = maxNum;
                            Console.WriteLine(newArr[i] + "\t");
                            Console.WriteLine("-----");
                        }

                        Console.ReadLine();
                    }
                    break;
                case 4:
                    {
                        Main(args);
                    }
                    break;

            }
        }
        static void var16(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Вариант 16:");
            Console.WriteLine("(1)Вычислить непонятную формулу:");
            Console.WriteLine("(2)Определить номер и значение минимального элемента кортежа");
            Console.WriteLine("(3)Сформировать массив B, содержащий максимальные элементы строк матрицы A");
            Console.WriteLine("(4)Выход в главное меню");
            try
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ошибка ввода, попробуйте еще раз");
                Console.ReadKey();
                var16(args);
            }
            switch (menu)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("вычисление с пределами");
                        Console.WriteLine("чему равен верхний предел? (рандом от 3 до 20)");
                        int upper;
                        try
                        {
                            upper = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            upper = rndNum.Next(3, 20);
                            Console.WriteLine("Великий рандом назначил {0} верхним пределом", upper);
                        }
                        Console.WriteLine("чему равно значение Х? (рандом от -100 до 100)");
                        int x;
                        try
                        {
                            x = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            x = rndNum.Next(-10, 10);
                            Console.WriteLine("Великий рандом назначил x={0} ", x);
                        }
                        double answ = 0, answTmp = 0;
                        for (int lower = 0; lower < upper; lower = lower + 1)
                        {
                            answTmp = lower / (Math.Sqrt((x * x) + 1));
                            answ = answTmp + answ;
                        }
                        Console.WriteLine("после долгих размышлений сумма ряда с пределами -1 {0} и формулой ix = {0}", upper, answ);
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("какие аргументы вы хотите использовать?");
                        Console.WriteLine("длина кортежа (по умолчанию = random(3-20))");
                        int l;
                        try
                        {
                            l = int.Parse(Console.ReadLine());
                        }
                        catch
                        {

                            Random rndNum = new Random();
                            l = rndNum.Next(3, 20);
                            Console.WriteLine("Великий рандом назначил кортеж c {0} значениями", l);
                        }
                        double[] cortege = new double[l];
                        double zero = double.MaxValue;
                        int i = 0;
                        for (int index = 0; index < cortege.Length; index++)
                        {
                            Console.WriteLine("введите значения кортежа (по умолчанию = random)");
                            try
                            {
                                cortege[index] = int.Parse(Console.ReadLine());
                                if (zero > cortege[index])
                                {
                                    zero = cortege[index];
                                }
                            }
                            catch
                            {
                                Random rndNum = new Random((int)DateTime.Now.Ticks);
                                cortege[index] = rndNum.Next(0, 100);
                                if (zero > cortege[index])
                                {
                                    zero = cortege[index];
                                    i = index;
                                }
                            }
                        }
                        for (int index = 0; index < cortege.Length; index++)
                        {
                            Console.Write("{0} ", cortege[index]);
                        }
                        Console.WriteLine(" \n в кортеже найдено минимальное значение {0} с индексом, {1} ", zero, i);
                        Console.ReadKey();
                        Main(args);

                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Введите размеры матрицы: ");
                        int str = int.Parse(Console.ReadLine());
                        int slb = int.Parse(Console.ReadLine());
                        var randNum = new Random();
                        int[,] matrix = new int[str, slb];
                        Console.WriteLine();
                        // Заполнение массива случайными числами
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                matrix[i, j] = randNum.Next(1, 54);
                                Console.Write("||{0}", matrix[i, j] + "\t");
                            }
                            Console.WriteLine("===========================================================================");
                        }
                        Console.WriteLine();

                        // Поиск максимального значения, составление ногово массива и вывод его на экран

                        int[] newArr = new int[str];
                        for (int i = 0; i < matrix.GetLength(1); i++)
                        {
                            int maxNum = 0;
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                if (matrix[i, j] > maxNum)
                                    maxNum = matrix[i, j];
                            }
                            newArr[i] = maxNum;
                            Console.WriteLine(newArr[i] + "\t");
                            Console.WriteLine("-----");
                        }

                        Console.ReadLine();
                    }
                    break;
                case 4:
                    {
                        Main(args);
                    }
                    break;


            }



        }
        static void var13(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Вариант 13:");
            Console.WriteLine("(1)Вычислить сумму ряда:");
            Console.WriteLine("(2)Переставить элементы кортежа в обратном порядке.");
            Console.WriteLine("(3)Вычислить произведение отрицательных элементов матрицы.");
            Console.WriteLine("(4)Выход в главное меню");
            try
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ошибка ввода, попробуйте еще раз");
                Console.ReadKey();
                var16(args);
            }
            switch (menu)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("вычисление с пределами");
                        Console.WriteLine("чему равен верхний предел? (рандом от 3 до 20)");
                        int upper;
                        try
                        {
                            upper = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            upper = rndNum.Next(3, 20);
                            Console.WriteLine("Великий рандом назначил {0} верхним пределом", upper);
                        }
                        Console.WriteLine("чему равно значение Х? (рандом от -100 до 100)");
                        int x;
                        try
                        {
                            x = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Random rndNum = new Random();
                            x = rndNum.Next(-10, 10);
                            Console.WriteLine("Великий рандом назначил x={0} ", x);
                        }
                        double answ = 0, answTmp = 0;
                        for (int lower = 0; lower < upper; lower = lower + 1)
                        {
                            answTmp = Math.Pow(lower, 2) - Math.Pow(x, 2);
                            answ = answTmp + answ;
                        }
                        Console.WriteLine("сумма ряда с пределами -1 {0} и формулой (i^2)-(x^2) = {1}", upper, answ);
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("какие аргументы вы хотите использовать?");
                        Console.WriteLine("длина кортежа (по умолчанию = random(3-20))");
                        int l;
                        try
                        {
                            l = int.Parse(Console.ReadLine());
                        }
                        catch
                        {

                            Random rndNum = new Random();
                            l = rndNum.Next(3, 20);
                            Console.WriteLine("Великий рандом назначил кортеж c {0} значениями", l);
                        }
                        int[] cortege = new int[l];
                        
                        int Min = int.MaxValue, minIndex = -1, Max = int.MinValue, maxIndex = -1;

                        for (int index = 0; index < cortege.Length; index++)
                        {
                            Console.WriteLine("введите значения кортежа (по умолчанию = random)");
                            try
                            {
                                cortege[index] = int.Parse(Console.ReadLine());
                                if (Min < cortege[index])
                                {
                                    Min = cortege[index];
                                    minIndex = index;
                                }
                            }
                            catch
                            {
                                Random rndNum = new Random((int)DateTime.Now.Ticks);
                                cortege[index] = rndNum.Next(0, 100);
                                if (Min > cortege[index])
                                {
                                    Max = cortege[index];
                                    maxIndex = index;
                                }
                            }
                        }
                        for (int i = 0; i < cortege.Length; i++)
                        {
                            try
                            {
                                cortege[i] = int.Parse(Console.ReadLine());
                                if (cortege[i] > Max)
                                {
                                    Max = cortege[i];
                                    maxIndex = i;
                                }
                                if (cortege[i] < Min)
                                {
                                    Min = cortege[i];
                                    minIndex = i;
                                }
                            }
                            catch
                            {
                                Random rndNum = new Random((int)DateTime.Now.Ticks);
                                cortege[i] = rndNum.Next(0, 100);
                                if (cortege[i] > Max)
                                {
                                    Max = cortege[i];
                                    maxIndex = i;
                                }
                                if (cortege[i] < Min)
                                {
                                    Min = cortege[i];
                                    minIndex = i;
                                }
                            }
                        }

                        Console.WriteLine("Исходный массив: \t{0}", string.Join(", ", cortege));

                        int begin = Math.Min(minIndex, maxIndex) + 1, end = Math.Max(minIndex, maxIndex) - 1;
                        for (; begin < end; begin++, end--)
                        {
                            int tmp = cortege[begin];
                            cortege[begin] = cortege[end];
                            cortege[end] = tmp;
                        }
                        Console.WriteLine("Обработанный массив: \t{0}", string.Join(", ", cortege));
                        Console.Read();
                    }
                    break;
                case 3:
                    {

                    }
                    break;
            }
            }
        static void autor(string[] args)
        {

        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Лабораторная работа 4";
            Console.WriteLine("Главное меню:");
            Console.WriteLine("1 Вариант 1");
            Console.WriteLine("2 Вариант 2");
            Console.WriteLine("3 Вариант 3");
            Console.WriteLine("4 Вариант 4");
            Console.WriteLine("5 Вариант 5");
            Console.WriteLine("6 Вариант 6");
            Console.WriteLine("7 Вариант 7");
            Console.WriteLine("8 Вариант 8");
            Console.WriteLine("16 Вариант 16");
            Console.WriteLine("-1 Об Авторе");
            Console.WriteLine("0 выход");

            try
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("что то не так, попробуйте еще раз");
                Console.ReadKey();
                Main(args);
            }
            switch (menu)
            {
                case 1:
                    var1(args);
                    break;
                case 2:
                    var2(args);
                    break;
                case 3:
                    var3(args);
                    break;
                case 4:
                    var4(args);
                    break;
                case 5:
                    var5(args);
                    break;
                case 6:
                    var6(args);
                    break;
                case 7:
                    var7(args);
                    break;
                case 8:
                    var8(args);
                    break;
                case 13:
                    var13(args);
                    break;
                case 16:
                    var16(args);
                    break;

            }


        }

    }
}
