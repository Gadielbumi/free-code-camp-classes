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
            Console.WriteLine(welcomMessage+Devinette);
            while (true)
            {
              
                Console.WriteLine("\n Enter your choice");
                string choice = Console.ReadLine();
                int Choice = Convert.ToInt32(choice);
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

        }
    }
}
