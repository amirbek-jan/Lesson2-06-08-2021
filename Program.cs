using System;

namespace Lesson2ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // Первое ДЗ
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());

           if (a!=b)
           {
               if(a>b) {
                   Console.WriteLine($"{a} {a}");
               }
               else {
                   Console.WriteLine($"{b} {b}"); 
               }
           }
               else {
                   Console.WriteLine($"0 0");
               }
            

                
               // Второе ДЗ
               int operand1 = int.Parse(Console.ReadLine());
               string sign = Console.ReadLine();
               int operand2 = int.Parse(Console.ReadLine());
               
               switch (sign)
               {
                   case "+" : 
                        Console.WriteLine(operand1 + operand2);
                        break;
                    case "-" : 
                        Console.WriteLine(operand1 - operand2);
                        break;
                    case "*" : 
                        Console.WriteLine(operand1 * operand2);
                        break;
                    default : 
                        break;
               }

                if (sign == "/") {
                    if (operand2 == 0) {
                        Console.WriteLine($"ERROR");
                    }
                    else {
                        Console.WriteLine(operand1 / operand2);
                    }
                }
                */

                
               // Третье ДЗ
               int num = int.Parse(Console.ReadLine());
               if (num >= 0 && num <= 14) {
                   Console.WriteLine($"[0 - 14]");
               } else if (num >= 15 && num <= 35) {
                   Console.WriteLine($"[15 - 35]");
               } else if  (num >= 35 && num <= 50) {
                   Console.WriteLine($"[36 - 50]");
               } else if (num >= 50 && num <= 100) {
                   Console.WriteLine($"[50 - 100]");
               } else {
                   Console.WriteLine($"ERROR");
               }
               
        }
    }
}
