using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Tahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tahmin yapan kim olsun\n\n1-Bilgisayar\n2-Oyuncu");
            int secim = Convert.ToInt16(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.Clear();    
                    Console.WriteLine("Sayı tahmin oyununa hoşgeldin! Tuttuğun sayıyı tahmin etmek için hazırım.");

                    Random random = new Random();
                    int kucuk = 0;
                    int buyuk = 100;
                    int guess = random.Next(kucuk, buyuk);

                    int deneme1 = 0;


                    while (true)
                    {
                        deneme1++;
                        Console.WriteLine($"Tuttugun sayi {guess} 'den büyük mü küçük mü yoksa eşit mi B/K/E");
                        char harf = Convert.ToChar(Console.ReadLine());

                        if (harf == 'E')
                        {
                            Console.WriteLine($"KAZANDIMMMMM {deneme1} denemede bildim");
                            break;
                        }
                        else if (harf == 'B')
                        {
                            Console.Clear();
                            kucuk = guess;
                            guess = random.Next(kucuk, buyuk);
                        }
                        else if (harf == 'K')
                        {
                            buyuk = guess;
                            guess = random.Next(kucuk, buyuk);
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("YANLIŞ DEĞER GİRİŞİ");
                            break;
                        }
                    }
                    
                   Console.ReadKey();
                    break;
                case 2:
                    Console.Clear() ;   
                    Random rand = new Random();
                    int deger = rand.Next(0, 100);

                    Console.WriteLine("Sayı tahmin oyununa hoşgeldin! Tuttuğum sayıyı tahmin etmek için bir sayi gir.");

                    int tahmin;
                    int deneme = 0;
                    bool bildin = true;

                    while (bildin)
                    {
                        tahmin = Convert.ToInt32(Console.ReadLine());

                        if (tahmin > deger)
                        {
                            Console.Clear();
                            Console.WriteLine(tahmin + "'den küçük bir deger");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(tahmin + "'den büyük bir deger");
                        }
                        
                        if (tahmin == deger)
                            bildin = false;
                        deneme++;
                    }
                    Console.WriteLine($"Tebrikler cevap = {deger}\n\nDoğru cevabı {deneme} denemede buldunuz");
                    break;     
                default:
                    Console.WriteLine("Yanlış değer girişi");
                    break;
            }
            Console.ReadKey();
        }
    }
}
