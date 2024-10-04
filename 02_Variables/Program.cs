using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine("*****FİYAT LİSTESİ*****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potato, tomato;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potato = 9.74;
            tomato = 6.88;

            Console.WriteLine("----Elma Birim Fiyatı:" + applePrice+"tl");
            Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice+"tl");
            Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice+"tl");
            Console.WriteLine("----Patates Birim Fiyatı:" + potato+"tl");
            Console.WriteLine("----Domates Birim Fiyatı:" + tomato+"tl");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;

            Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fİyatı: " + applePrice + "-" +
                "Gramaj:" + appleGram + "Toplam Tutar:" + appleTotalPrice);

            


            

            #endregion


            Console.Read();

        }
    }
}
