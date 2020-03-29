using System;

namespace DZZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Задание №1\n" + "Сделано :)");
            }

            {
                Console.WriteLine("Задание №2");
                decimal sum;
                Console.Write("Введите стоимость вашей покупки: ");
                sum = Convert.ToDecimal(Console.ReadLine());
                if (sum>0 && sum<500)
                {
                    Console.WriteLine($"Стоимость вашей покупки -> {sum}");
                }
                else if(sum>=500 && sum<1000)
                {
                    Console.WriteLine($"Стоимость вашей покупки с 3% скидкой -> {sum - ((sum*3)/100)}");
                }
                else if (sum>=1000)
                {
                    Console.WriteLine($"Стоимость вашей покупки с 5% скидкой -> {sum - ((sum*5)/100)}");
                }
                else if(sum<=0)
                {
                    Console.WriteLine("Стоимость не может быть отрецательной или нулевой, введите другое значение!");
                }
            }

            {
                Console.WriteLine("Задача №3");
                decimal a1, a2, a3, a4;
                Console.Write("a1 = ");
                a1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("a2 = ");
                a2 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("a3 = ");
                a3 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("a4 = ");
                a4 = Convert.ToDecimal(Console.ReadLine());
                if (a1<a2 && a2<a3 && a3<a4)
                {
                    Console.WriteLine("Числа расположены по возрастанию");
                }
                else if(a1 == a2 && a2 == a3 && a3 == a4)
                {
                    Console.WriteLine(a1*a2*a3*a4);
                }
                else
                {
                 decimal min;
                 min = a1;
                 if(min>a2) min = a2;
                 if(min>a3) min = a3;
                 if(min>a4) min = a4;
                 Console.WriteLine(min);
              } 
            }
                
            {
                Console.WriteLine("Задача №4");
                decimal a, b, c;
                Console.Write("a = ");
                a = Convert.ToDecimal(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToDecimal(Console.ReadLine());
                Console.Write("c = ");
                c = Convert.ToDecimal(Console.ReadLine());
                if(a>=b && b>=c)
                {
                    Console.WriteLine($"{a} ; {b} ; {c}");
                }
                else
                {
                    if (a>=b && a>=c && c>=b)
                    {
                        b = b + c;
                        c = b - c;
                        b = b - c;
                    }   
                     else if (b>=a && b>=c && a>=c)
                     {
                         a = a + b;
                         b = a - b;
                         a = a - b;
                     }
                     else if (b>=a && b>=c && c>=a)
                     {
                         decimal d; 
                         d = a;
                         a = b;
                         b = c;
                         c = d;

                     }
                     else if (c>=a && c>=b && a>=b)
                     {
                         decimal d;
                         d = a;
                         a = c;
                         c = b;
                         b = d;
                         
                     }
                     else if (c>=a && c>=b && b>=a)
                     {
                         a = c + a;
                         c = a - c;
                         a = a - c;
                     }
                     else if(b>=a && a>=c)
                 {
                     decimal d;
                     d=a;
                     a=b;
                     b=d;
                     
                 }
                 else if(b>=c && c>=a)
                 {
                    decimal d;
                    d=a;
                    a=b;
                    b=c;
                    c=d;
                 }
                Console.WriteLine($"{a} ; {b} ; {c}");
                }
            
           }
        }
    }
}

