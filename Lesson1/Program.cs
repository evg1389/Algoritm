using System;
using static System.Console;

/* работу выполнил Удалов Евгений курс разработчик Си #
  

1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела 
по формуле I = m / (h * h), где m – масса тела в килограммах, h – рост в метрах.
2. Найти максимальное из четырёх чисел. Массивы не использовать
10. Дано целое число N > 0. С помощью операций деления нацело и взятия остатка от деления определить,
имеются ли в записи числа N нечётные цифры. Если имеются, то вывести True, если нет – вывести False.
11. С клавиатуры вводятся числа, пока не будет введён 0. Подсчитать
среднее арифметическое всех положительных чётных чисел, оканчивающихся на 8.
12. Написать функцию нахождения максимального из трёх чисел.
13. * Написать функцию, генерирующую случайное число от 1 до 100: 
a. С использованием стандартной функции rand().
b. Без использования стандартной функции rand().

  
  
 
 */
namespace Lesson1
{
    class Program
    {
        /// <summary>
        ///Метод нахождения массы тела для первого дз 
        /// </summary>
        /// <param name="m">масса тела</param>
        /// <param name="h">рост</param>
        /// <returns>индекс массы</returns>
        static double IndexMass(double m,double h)
        {
            return m / (h * h);
        }

        /// <summary>
        /// метод нахождения максимального числа для второго задания
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        static int MaxValue(int x,int y,int z,int j)
        {
            int Max = x;
            if (Max<y)
            {
                Max = y;
            }
            if (Max<z)
            {
                Max = z;
            }
            if (Max<j)
            {
                Max = z;
            }
            return Max;
        }

        
        /// <summary>
        /// метод нахождения четного числа для 10 задания
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        static bool ValueEven(int N)
        {
            bool b;
            if (N%2==0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }


        /// <summary>
        /// метод для 11 задания
        /// </summary>
        /// <param name="K"></param>
        /// <returns></returns>
        static int SumValue(int K)
        {
            int Sum =0;
            if (K%10==8)
            {
                Sum = Sum + K;
            }
            return Sum;
        }


        /// <summary>
        /// метод нахождения макс. из трех чисел для 12 задания
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        static int maxValue(int x,int y, int z)
        {
            int Max;
            if(x<y)
            {
                Max = y;
               if(x<z)
                {
                    Max = z;
                }
            }
            else
            {
                Max = x;
            }
            return Max;
        }


        static void Main(string[] args)
        {
            // 1 задание 
            double m;
            double h;
            Write("Введите массу тела \n");
            m = Convert.ToDouble(ReadLine());
            Write("Введите рост пример 1м 75 см это 1,75 \n");
            h = Convert.ToDouble(ReadLine());
            double I = IndexMass(m, h);
            Write("Ваша масса тела = {0}\n", I);
            //конец 1 задания

            //2 задание
            int x = 8;
            int y = 9;
            int z = 12;
            int j = 2;
            int Max = MaxValue(x, y, z, j);
            Write("Max value={0}\n", Max);
            //конец 2 задания



            //10 задание
            Write("Введите чело число больше 0:\n");

            int N = Convert.ToInt32(ReadLine());
            if (N > 0)
            {
                bool b = ValueEven(N);
                Write("Верно ли что число N={0} являеться четным: {1}\n", N, b);
            }
            else
            {
                Write("Число не являеться положительным или целым\n");

            }

            //конец 10 задания

            //11 задание
            Write("\n");
            Write("\n");
            int J = 1;
            int Sum = 0;
            while (J != 0)
            {
                int K = Convert.ToInt32(ReadLine());
                if (K > 0)
                {
                    Sum = Sum + SumValue(K);

                }
                else
                {
                    Write("Число не являеться положительным!\n");
                }
                J = K;
            }
            Write("Сумма положительных чисел закнчивающихся на 8 ={0}\n", Sum);
            //конец 11задания

            //12 задание
            Write("\n");
            int value1 = 10;
            int value2 = 15;
            int value3 = 5;
            int max = maxValue(value1, value2, value3);
            Write("Максимальное из трех цифр {0}\n", max);
            //конец 12 задания

            //13 задание
            Random rd = new Random();
            int Num = rd.Next(1, 101);
            Write("Число рандомное = {0}\n",Num);

            int X, Y, B, H;
            H = 101;//
            B = 3;
            Y = 2;
            X = 1;

            int moduls =101;
            for(int i=0;i<moduls;i++)
            {
                X = (Y * X + B) % H;
                Write("рандомное число = {0}",X);
            }

            //конец 13 задания

            ReadKey();
        }
    }
}
