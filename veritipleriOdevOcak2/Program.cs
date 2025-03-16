using System;

class Program
{
    static void Main()
    {
        
        double sayi1, sayi2, toplam;

        
        Console.Write("Birinci sayıyı giriniz: ");

        
        while (!double.TryParse(Console.ReadLine(), out sayi1))
        {
            Console.Write("Geçersiz giriş! Lütfen sayısal bir değer giriniz: ");
        }

       
        Console.Write("İkinci sayıyı giriniz: ");

       
        while (!double.TryParse(Console.ReadLine(), out sayi2))
        {
            Console.Write("Geçersiz giriş! Lütfen sayısal bir değer giriniz: ");
        }

        
        toplam = sayi1 + sayi2;

      
        Console.WriteLine($"Girdiğiniz sayıların toplamı: {toplam}");

        Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);
    }
}