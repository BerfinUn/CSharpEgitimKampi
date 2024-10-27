﻿using System;
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

            //Console.WriteLine("*****FİYAT LİSTESİ*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı:" + applePrice + "tl");
            //Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice + "tl");
            //Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + "tl");
            //Console.WriteLine("----Patates Birim Fiyatı:" + potatoPrice + "tl");
            //Console.WriteLine("----Domates Birim Fiyatı:" + tomatoPrice + "tl");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram *orangePrice;
            //double strawberryTotalPrice = strawberryGram *strawberryPrice;
            //double potatoTotalPrice = potatoGram *potatoPrice;
            //double tomatoTotalPrice = tomatoGram *tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma -" + "Birim Fİyatı: " + applePrice + "-" +
            //    "Gramaj:" + appleGram + "Toplam Tutar:" + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal -" + "Birim Fİyatı: " + orangePrice + "-" +
            //    "Gramaj:" + orangeGram + "Toplam Tutar:" + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün:Çilek -" + "Birim Fİyatı: " + strawberryPrice + "-" +
            //    "Gramaj:" + strawberryGram + "Toplam Tutar:" + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün:Patates-" + "Birim Fİyatı: " + potatoPrice+ "-" +
            //    "Gramaj:" + potatoGram + "Toplam Tutar:" +potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates -" + "Birim Fİyatı: " + tomatoPrice+ "-" +
            //    "Gramaj:" + tomatoGram + "Toplam Tutar:" + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:"+shoppingTotalPrice+ "tl");


            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("****CSHARP HAVA YOLLARI YOLCU BİLGİSİ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " " +
            //passengerDistrict + "/" + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar:"+totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:" + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;//tek karakter olmak zorunda 
            //Console.Write("Lütfen Cinsiyet Seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " +gender);

            #endregion


            Console.Read();

        }
    }
}
