using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //3.2 - базовый уровень - 8 вариант 
            try
            {             
                int i = 2;
                Console.WriteLine("Введите число:");
                double n = double.Parse(Console.ReadLine());
                Console.Write(" {0} = ", n);
                while (n > 1) 
                {
                    while (n % i == 0)
                    {
                        Console.Write("{0} * ", i);
                        n /= i;
                    }
                    if (i == 2) i++;
                    else i += 2;

                }
               

            }
            catch (Exception)
            { 
            
                Console.WriteLine("Введите корректно переменную");
            }
           
               
            
        }
    }
}