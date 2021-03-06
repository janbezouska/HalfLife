using System;

namespace Fyzika
{
    class Program
    {
        static void Main(string[] args)
        {
            int jadra = 200; //začínáme s dvěstě jádry
            
            while(jadra > 0) //dokud zbývá alespoň jedno jádro, "házíme" znovu
            {
                jadra = Cycle(jadra);
            }
            Console.Read();
            
        }
        static int Cycle(int _jadra)
        {
            Random rnd = new Random(); //náhodné číslo
            int j;

            for (int i = 0; i < _jadra; i++)
            {
                j = rnd.Next(1, 10); //náhodné číslo z <1, 10>
                if (j < 6) //pokud je číslo menší než 6, pak se jádro přeměnilo
                    _jadra--; //počet nepřeměněných jader se sníží o jedno
            }
            Console.WriteLine("Zbývající jádra: " + _jadra);

            return _jadra;
        }
    }
}
