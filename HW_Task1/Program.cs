using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static double CalcPlus (double a, double b)
        {
            return a + b;
        }
        static double CalcMinus(double a, double b)
        {
            return a - b;
        }
        static double CalcMult(double a, double b)
        {
            return a * b;
        }
        static double CalcDiv(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            Console.WriteLine("напишите выражение из двух чисел(сложение,вычитание,умножение или деление");
            Console.WriteLine("Например 1 + 2, затем нажмите Enter...");
            Console.Write("Ввод: ");
            try
            {
                
                string[] Vvod = Console.ReadLine().Split();
                double Num1 = Convert.ToDouble(Vvod[0]);
                double Num2 = Convert.ToDouble(Vvod[2]);
                if (Vvod.Length != 3)
                {
                    Console.WriteLine("Ошибка, попробуйте написать через пробелы");
                    
                }
                else
                {
                    switch (Vvod[1])
                    {
                        case "+":
                            Console.WriteLine(CalcPlus(Num1, Num2));
                            break;
                        case "-":
                            Console.WriteLine(CalcMinus(Num1, Num2));
                            break;
                        case "*":
                            Console.WriteLine(CalcMult(Num1, Num2));
                            break;
                        case "/":
                            try
                            {
                                Console.WriteLine(CalcDiv(Num1, Num2));
                                break;
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Деление на 0!");
                                break;
                            }
                        default:
                            Console.WriteLine("Упс, я такое не умею");
                            break;
                    }
                }
                

                
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine(" Попробуйте написать с пробелом");

            }

            Console.ReadKey();
        }
    }
}
