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

            // 1 ededin 2li yazilisindaki 1lerin sayi
            /* Console.Write("Ededi daxil edin:");
             int number = int.Parse(Console.ReadLine());
             int a,b=0;
             while (number>0)
             {
                 a = number % 2;
                 number= number / 2;
                 if (a==1)
                 { b = b + 1;}
             }
             Console.Write("Birlerin sayi  ");
             Console.WriteLine(b);*/

            // bir password saxla istfadeci give us one if p=up sisteme daaxil olduz else again
            /* string password = "Aytekin";
             Console.WriteLine("password:");
             string user_password = Console.ReadLine();

             while (user_password != password)
             {
                 Console.WriteLine("dogru password daxil edin:");
                 user_password = Console.ReadLine();
                 if (user_password == password)
                 { Console.WriteLine("Sisteme daxil olduz"); }
             }*/

            //ededin faktoriali
            /*Console.Write("Ededi daxil edin:  ");
            int number = int.Parse(Console.ReadLine());
            int b = 1;
            for (int i=1; i<=number; i++)
            {
                b = b * i;
            }
            Console.WriteLine("Ededin faktoriali: " + b);*/


            /*Console.Write("Ededi daxil edin:  ");
            int number = int.Parse(Console.ReadLine());
            int b = 1;
            while(number>0)
            {

                b = b * number;
                number--;
            }
            Console.WriteLine("Ededin faktoriali: " + b);*/




        }


    }
}
