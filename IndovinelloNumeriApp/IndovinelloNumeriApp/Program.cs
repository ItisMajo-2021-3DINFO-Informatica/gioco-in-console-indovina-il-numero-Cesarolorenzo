using System;

namespace IndovinelloNumeriApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int n = num.Next(1, 100);
            int numero = 0;
            int tentativi = 0;
            Console.WriteLine($"indovina il numero");
            while (tentativi <= 100)
            {
                tentativi++;
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < n)    
            {
                    Console.WriteLine("il numero inserito è troppo basso");
                
                }
                else if (numero > n)
                {
                    Console.WriteLine("il numero inserito è troppo alto");

                }


                else if (n == numero)
                {
                    Console.WriteLine("hai indovinato");
                    Console.WriteLine($"i tuoi tentativi sono {tentativi}");

                }
            }
           


        }
    }
}
