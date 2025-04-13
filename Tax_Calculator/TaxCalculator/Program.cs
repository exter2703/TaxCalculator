using System.Runtime.CompilerServices;

namespace TaxCalculator;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) {
        
        Application.SetHighDpiMode(HighDpiMode.SystemAware); // tylko w nowszych wersjach
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
        
        // const double VAT_RATE = 0.23;
        // var products = new List<Produkt>();
        //
        // Console.Write("Ilość produtków: ");
        // var productsCount = int.Parse(Console.ReadLine());
        //
        // for (int i = 0; i < productsCount; i++)
        // {
        //     Console.WriteLine($"\nProdukt: {i+1}");
        //     Console.Write("Nazwa prduktu: ");
        //     var name = Console.ReadLine();
        //     
        //     Console.Write("Ilość sztuk: ");
        //     var pieces = int.Parse(Console.ReadLine());
        //     
        //     products.Add(new Produkt { Name = name, Pieces = pieces });
        // }
        //
        // Console.Write("Zapłacony VAT z SADu: ");
        // var VAT = int.Parse(Console.ReadLine());
        //
        // int piecesSum = 0;
        // foreach (var product in products)
        // {
        //     piecesSum += product.Pieces;
        // }
        //
        // foreach (var product in products)
        // {
        //     double proportion = (double)product.Pieces / piecesSum;
        //     product.Tax = Math.Round(VAT * proportion, 2);
        // }
        //
        // double nettoSum = 0;
        //
        // Console.WriteLine("Wyniki: ");
        //
        // foreach (var product in products)
        // {
        //     double nettoPrice = product.Tax / VAT_RATE;
        //     double onePiecePrice = nettoPrice / product.Pieces;
        //
        //     double mainPrice = Math.Floor(onePiecePrice * 100) / 100;
        //
        //     int mainPieces = product.Pieces - 1;
        //
        //     double rest = nettoPrice - (mainPieces * mainPrice);
        //     double priceLastPiece = Math.Round(rest, 2);
        //     
        //     double sumCheck = mainPieces * mainPrice + priceLastPiece;
        //     nettoSum += sumCheck;
        //     
        //     Console.WriteLine($"Produkt: {product.Name}");
        //     Console.WriteLine($"Sztuki: {product.Pieces} sztuk");
        //     Console.WriteLine($"VAT: {product.Tax} PLN");
        //     Console.WriteLine($"Netto overall: {nettoPrice:F2} PLN");
        //     Console.WriteLine($"Cena jednostkowa dokładna: {onePiecePrice:F6} PLN");
        //     Console.WriteLine($"Cena główna: {mainPrice:F2} PLN");
        //     Console.WriteLine(" - Podział:");
        //     Console.WriteLine($"  - {mainPieces} sztuk po {mainPrice:F2} PLN");
        //     Console.WriteLine($"  - 1 sztuka po {priceLastPiece:F2} PLN");
        //     Console.WriteLine($"Suma: {sumCheck:F2} PLN");
        //     Console.WriteLine();
        // }
        // Console.WriteLine("\n======================================================");
        // Console.WriteLine($"Łączna suma NETTO: {nettoSum:F2} PLN");
    }
}




