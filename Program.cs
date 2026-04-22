using System;

namespace GarajPavel
{
    class Program
    {
        static void Main()
        {
            // Variabilele noastre
            string masinaMea = "Nissan GT-R R35";
            int caiPutere = 570;
            double acceleratie = 2.8;
            int pretEuro = 120000;
            string culoarea = "Neagra";

            // Afisarea informatiilor
            Console.WriteLine("=== SISTEM GESTIUNE GARAJ ===");
            Console.WriteLine("Masina curenta: " + masinaMea);
            Console.WriteLine("Putere: " + caiPutere + " HP");
            Console.WriteLine("Viteza 0-100 km/h: " + acceleratie + " sec");
            Console.WriteLine("Pret estimativ: " + pretEuro + " EUR");
            Console.WriteLine("Culoarea: " + culoarea );
            Console.WriteLine("============================");
            
            Console.WriteLine("\nStatus: Masina este gata de drum");
        }
    }
}