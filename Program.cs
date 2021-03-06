using System;

namespace Fyzika
{
    class Program
    {
        static void Main(string[] args)
        {
            int jadra = 1000;           //začínáme s tisíci jádry
            Random rnd = new Random(); //náhodné číslo
            int j;

            while (jadra > 0) //dokud zbývá alespoň jedno jádro, "házíme" znovu
            {
                for (int i = 0; i < jadra; i++)
                {
                    j = rnd.Next(1, 10); //náhodné číslo z <1, 10>
                    if (j < 6)           //pokud je číslo menší než 6, pak se jádro přeměnilo
                        jadra--;         //počet nepřeměněných jader se sníží o jedno
                }
                Console.WriteLine("Zbývající jádra: " + jadra);
            }
            Console.Read();
        }
    }
}
