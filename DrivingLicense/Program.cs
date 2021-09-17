using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sünniaastat
            Console.WriteLine("Mis on teie sünniaasta?");

            //programm arvutab kasutaja vanuse
            int aasta = Convert.ToInt32(Console.ReadLine());
            int vanus = 2021 - aasta;
            int vanus2 = 18 - vanus;

            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis "oled liiga noor, et juhiload saada";
            if(vanus < 18)
            {
                Console.WriteLine($"Oled {vanus} aastat vana ning kahjuks ei saa veel juhilube omada, pead veel ootama {vanus2} aastat.");
            }

            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis "oled piisavalt vana, et juhiload saada";
            else if(vanus > 18)
            {
                Console.WriteLine($"Palju õnne! Oled {vanus} aastat vana ning võid juhilube omada.");
            }

            //kui kasutaja on 18, siis programm kuvab konsoolis "Palju õnne, nüüd sa saad juhiloa taotleda";
            else
            {
                Console.WriteLine("Palju õnne oled täpselt 18 aastat vana ning võid juhilube omada.");
            }
        }
    }
}
