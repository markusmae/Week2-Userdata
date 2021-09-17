using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            Console.WriteLine("Palun, sisesta oma vanus.");
            int userage = Convert.ToInt32(Console.ReadLine());
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib instagrami kasutaja;

            if (userage > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami kontot luua.");
            }

            //kui kasutaja on noorem kui 13, siis ta on liiga noor;
            else if (userage < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            
            else
            {
                Console.WriteLine("Oledki 13 võid endale Instagrami konto teha.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
