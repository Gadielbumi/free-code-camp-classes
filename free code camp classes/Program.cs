 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace free_code_camp_classes
{
    internal class Programle
    {
        static void Main(string[] args)
        {
            string welcomMessage = "Welcome on our App";
            string Devinette = "Try to find a nomber between 0 and 4";
            Console.WriteLine(welcomMessage+'\n'+Devinette);
            while (true)
            {
              
                Console.WriteLine("\n Enter your choice");
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out int Choice))
                {
                    int numbToFind = 1;
                    if (numbToFind == Choice)
                    {
                        Console.WriteLine("Congratulation you have succed");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try aigain ");
                    }
                }
                else
                {
                    Console.WriteLine("error try a number");
                    Console.ReadLine();
                }
            }

        }
    }
}
