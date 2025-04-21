using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _1.videoc__temelkonular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdrımaKomutları

            //Console.WriteLine("merhaba dunya!");
            //Console.Write("selam"); 

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");

            #endregion YazdırmaKomutları

            #region Değişkenler
            //string alfabetık turde verılerımızı tutabılecegımız degısken turu.
            //altı kırmızı ıse hata yesıl ıse uyarı
            //değişken_türü değişken_adı;

            //string name;
            //name = "İlayda Mayda";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, distrct, city;


            //customerName = "İlayda";
            //customerSurname = "MAYDA";
            //customerPhone = "5427391923";
            //customerEmail = "ilymyda@gmail.com";
            //distrct = "Başakşehir";
            //city = "istanbul";
            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone );
            //Console.WriteLine("Email Adresi: " + customerEmail );
            //Console.WriteLine("Adres: " + distrct + "/" +  city);
            //Console.WriteLine("--------------------------------------------------------");

            //Console.WriteLine();

            //customerName = "İrem";
            //customerSurname = "AYRAN";
            //customerPhone = "5427391924";
            //customerEmail = "iremayrn75@gmail.com";
            //distrct = "Osmangazi";
            //city = "Bursa";
            //Console.WriteLine("--------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + distrct + "/" + city);
            //Console.WriteLine("--------------------------------------------------------");



            #endregion Değişkenler

            #region Int Değişkenler
            //Ctrl+d ile kopyala
            //int tam sayılı değişkenler
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice= 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Kola : " + cokePrice +" TL ");
            Console.WriteLine("-----Hamburger : " + hamburgerPrice + " TL ");
            Console.WriteLine("-----Su : " + waterPrice + " TL ");
            Console.WriteLine("-----Kızartma : " + friesPrice + " TL ");
            Console.WriteLine("-----pizza: " + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata : " + lemonadePrice + " TL ");
          
            Console.WriteLine();

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice ;
            int totalWaterPrice ;
            int totalFriesPrice ;
            int totalPizzaPrice ;
            int totallemonadePrice ;

        


            hamburgerCount = 3;
            cokeCount= 3;
            waterCount= 3;
            friesCount= 1;
            pizzaCount= 0;
            lemonadeCount= 0;




            totalHamburgerPrice  = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totallemonadePrice = lemonadeCount * lemonadePrice;
            


            Console.WriteLine("----------------------------------");
            Console.WriteLine("hamburger tutarı:" +totalHamburgerPrice+ "TL");
            Console.WriteLine("pizza tutarı:" +totalPizzaPrice+ "TL");
            Console.WriteLine("coke tutarı:" +totalCokePrice+ "TL");
            Console.WriteLine("water tutarı:" +totalWaterPrice+ "TL");
            Console.WriteLine("lemonde tutarı:" +totallemonadePrice+ "TL");
            Console.WriteLine("kızartma tutarı: " + totalFriesPrice + "TL");

            int totalPrice= totalCokePrice + totalWaterPrice + totalFriesPrice + totalHamburgerPrice + totalPizzaPrice + totallemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");







            #endregion Int Değişkenler

            Console.Read();
        }
    }
}
//yazdırma komuttları
//bır deger yazar ve ımlecı alt satıra ındırır.(console.wrıtlıne)