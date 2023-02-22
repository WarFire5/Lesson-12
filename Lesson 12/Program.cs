using System;
using System.Security.AccessControl;

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Программа1

                Console.WriteLine("Программа1");

                Console.Write("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                int greatestDivisor = 1;
                int divisor = 1;

                if (number < 0)
                {
                    while (Math.Abs(divisor) <= Math.Abs(number))
                    {
                        if (number % divisor == 0)
                        {
                            greatestDivisor = divisor;
                        }
                        divisor++;
                    }
                }
                else
                {
                    while (divisor < number)
                    {
                        if (number % divisor == 0)
                        {
                            greatestDivisor = divisor;
                        }
                        divisor++;
                    }
                }
                Console.Write("Наибольший делитель введённого числа, не равный самому числу: ");
                Console.WriteLine(greatestDivisor + ".");

                Console.ReadLine();



                // Программа2            

                Console.WriteLine("Программа2");

                Console.WriteLine("Введите число 'A':");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число 'B':");
                int B = Convert.ToInt32(Console.ReadLine());

                if (A == B)
                {
                    Console.WriteLine("Задайте иную комбинацию чисел, где A не равно B.");
                }

                else
                {
                    while (A != 0 && B != 0)
                    {
                        if (Math.Abs(A) > Math.Abs(B))
                        {
                            A %= B;
                        }
                        else
                        {
                            B %= A;
                        }
                    }
                    Console.Write("Наибольший общий делитель введённых чисел: ");
                    Console.WriteLine(Math.Abs(A + B) + ".");
                }

                Console.ReadLine();



                // Программа3

                Console.WriteLine("Программа3");

                Console.WriteLine("Введите число:");
                int N = Convert.ToInt32(Console.ReadLine());
                int Q = 0;

                while (N != 0)
                {
                    int tmp = N % 10;
                    N /= 10;
                    if (tmp % 2 != 0)
                    {
                        Q++;
                    }
                }
                Console.WriteLine("Количество нечетных цифр введённого числа: " + Q + ".");
                Console.ReadLine();



                // Программа4

                Console.WriteLine("Программа4");

                Console.WriteLine("Введите число:");
                int SE = Convert.ToInt32(Console.ReadLine());
                int temp;
                string ESS = "";

                if ((SE < 10) || (SE % 10 == 0))
                {
                    Console.WriteLine("Введите другое число, которое больше 10 и не заканчивается на нуль.");
                }
                else
                {
                    while (SE != 0)
                    {
                        temp = SE % 10;
                        ESS += temp;
                        SE /= 10;
                    }
                    int ES = Convert.ToInt32(ESS);
                    Console.WriteLine("Число, которое является зеркальным отображением последовательности цифр заданного числа: ");
                    Console.WriteLine(ES + ".");
                }

                Console.ReadLine();



                // Программа5

                Console.WriteLine("Программа5");

                Console.Write("Введите целое положительное число (cubN) :" + " ");
                int cubN = Convert.ToInt32(Console.ReadLine());

                if (cubN < 0)
                {
                    Console.Write("Надо ввести положительное число.");
                }
                else
                {
                    double nN = 0; // левая граница интервала nNegative
                    double nP = cubN; // правая граница интервала nPositive
                    double nM; // середина интервала nMiddle
                    double e = 0.00000001; // точность расчётов Epsilon                    
                    while (nP - nN > e)
                    {
                        nM = (nN + nP) / 2;
                        if (nM * nM * nM < cubN)
                        {
                            nN = nM;
                        }
                        else
                        {
                            nP = nM;
                        }
                    }
                    Console.WriteLine("Число 'N', кубом которого является введённое число, равно: " + nP + ".");
                }
                
                Console.WriteLine(" ");
                Console.WriteLine("Конец!");

                Console.ReadLine();
            }
        }
    }
}
