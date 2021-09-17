using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            Console.WriteLine("Kui vana Te olete?");

            //programm arvutab kasutaja sünniaasta;
            int vanus = Convert.ToInt32(Console.ReadLine());
            int aasta = 2021 - vanus;

            //programm kuvab sünniaasta konsoolis; 
            Console.WriteLine($"Teie sünniaasta on {aasta}.");
            
        }
    }
}
