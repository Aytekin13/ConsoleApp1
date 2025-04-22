using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  TAPSIRIQ
            /*int gun=int.Parse(Console.ReadLine());
             switch (gun)
             {
                 case 1:
                     Console.WriteLine("Bazar ertesi");
                     break;

                 case 2:
                     Console.WriteLine("cersenbe axsami");
                     break;
                 case 3:
                     Console.WriteLine("Cersenme");
                     break;
                 case 4:
                     Console.WriteLine("Cume axsam");
                     break;
                 case 5:
                     Console.WriteLine("Cume");
                     break;
                 case 6:
                     Console.WriteLine("Sembe");
                     break;
                 case 7:
                     Console.WriteLine("Bazar");
                     break;
                 default:
                     Console.WriteLine("Duzgun eded daxil edin");
                     break;*/
            /* Console.WriteLine("Ayın nomresini daxil edin");
             int ayin_nomresi = int.Parse(Console.ReadLine());
             switch (ayin_nomresi)
             {
                 case 1:
                 case 2:
                 case 12:
                     Console.WriteLine("Winter");
                     break;
                 case 3:
                 case 4:
                 case 5:
                     Console.WriteLine("Spring");
                     break;
                 case 6:
                 case 7:
                 case 8:
                     Console.WriteLine("Summer");
                     break;
                 case 9:
                 case 10:
                 case 11:
                     Console.WriteLine("Autumn");
                     break;

                 default:
                     Console.WriteLine("Duzgun eded daxil edin");
                     break;
               }*/
            #endregion

            Console.Write("Eded1    ");
            float num1=float.Parse(Console.ReadLine());
            Console.Write("Simvol   ");
            char simvol =char.Parse(Console.ReadLine());
            Console.Write("Eded2    ");
            float num2 = float.Parse(Console.ReadLine());   
             switch(simvol)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                case '%':
                    Console.WriteLine(num1 % num2);
                    break;
                default:
                    Console.WriteLine("Duzgun simvolu daxil edin");
                    break;
             }


        }
  
    
    }
}
