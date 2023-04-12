using System;

namespace Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int returnvalue = random.Next(1, 100);

            Console.WriteLine(" Guess a number between 1 to 100 ");
            int response = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<100; i++) 
            {
                if(response > returnvalue) 
                {
                    Console.WriteLine($"No the number is low than {response} try again !");
                    response = Convert.ToInt32(Console.ReadLine());
                }
                else if(response < returnvalue) 
                {
                    Console.WriteLine($"No the number is high than {response} try again !");
                    response = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Good ! Its  {returnvalue}");
                    break;
                }
            }

        }
    }
}