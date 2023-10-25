using System;

namespace lyckhjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();
            int vinstnummer = slump.Next(1, 11);
            
            Console.WriteLine("Välj en siffra mellan 1 till 10 för en chans att vinna på lyckohjulet");
            int gissning = int.Parse(Console.ReadLine());
            Console.WriteLine("Hjulet stannade på " + vinstnummer);
            if (gissning == vinstnummer)
            {
                Console.WriteLine("Du vann");
            }
            else
            {
                Console.WriteLine("Du vann tyvärr inte");
            }
        }
    }
}
