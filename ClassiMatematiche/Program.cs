using System;
using Matematiche;


namespace ClassiMatematiche
{
    class Program
    {
        static void Main(string[] args)
        {
            int somma = FunzioniMatematiche.Somma(5, 4);
            Console.WriteLine($"la somma intera è: {somma}");
            double sommaDouble = FunzioniMatematiche.SommaDouble(8.0, 10.0);
            Console.WriteLine($"la somma decimale è: {sommaDouble}");
            double moltiplicazione = FunzioniMatematiche.Moltiplicazione(2,4);
            Console.WriteLine($"la moltiplicazione è: {moltiplicazione}");
            double divisione = FunzioniMatematiche.Divisione(5, 4);
            Console.WriteLine($"la divisione è: {divisione}");
            long potenza = FunzioniMatematiche.Potenza(3, 4);
            Console.WriteLine($"la potenza è: {potenza}");
            long molt = FunzioniMatematiche.CalcolaFattoriale(20);
            Console.WriteLine($"il fattoriale è {molt}");
            int min = FunzioniMatematiche.MinorTra(3, 7,5);
            Console.WriteLine($"il minimo è {min}");
            int max = FunzioniMatematiche.MaggioreTra(2, 6, 5);
            Console.WriteLine($"il massimo è {max}");
            double inverso = FunzioniMatematiche.Inverso(4);
            Console.WriteLine($"il numero inverso è {inverso}");
            bool pari = FunzioniMatematiche.IsPari(4);
            Console.WriteLine($"il numero è pari {pari}");
            bool dispari = FunzioniMatematiche.IsDispari(6);
            Console.WriteLine($"il numero è dispari{dispari}");
            bool positivo = FunzioniMatematiche.IsPositivo(8);
            Console.WriteLine($"il numero è positivo: {positivo}");
            bool negativo = FunzioniMatematiche.IsNegativo(6);
            Console.WriteLine($"il numero è positivo: {negativo}");
            bool intero = FunzioniMatematiche.IsIntero(4);
            Console.WriteLine($"il numero è intero: {intero}");

        }
    }
}
