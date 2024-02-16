using System;
namespace bang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string[] mening = Console.ReadLine().Split(' ');
            Varannat(mening);
        }

        static void Varannat(string[] mening)
        {
            bool varannat = true; 
            
            foreach (string s in mening)
            {
                if (varannat)
                {
                    Console.Write(s.ToUpper() + " ");
                }
                else
                {
                    Console.Write(s.ToLower() + " ");
                }

                varannat = !varannat;
            }
        }

    }
}