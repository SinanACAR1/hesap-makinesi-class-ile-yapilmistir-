using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class Class1
    {
       // 20 * 3
       public double sayıayrıstır(string textbox)
       {
           //[20][3]
       string[] sayılar = new string[2];//2 TANE SAYI İŞLEMİ OLCAGI İÇİN 2 TANE İNDEX OLUŞTURUYORUZ
       string islem = "";//HANGİ OPERATOR BULUNURSA BURAYA O OPARETORU YAZDIRIR
       int operatorgoruldu = 0;//EĞER OPERATOR GORUNURSE BURAYA SAYI EKLER
       char[] dizi = textbox.ToCharArray();//DİZİ OLUŞTURUYORUZ VE textboxtan gelen değerleri sırala örneğin 15 * 98 değerini [1][5][*][9][8] olarak sıralar
       for (int i = 0; i < dizi.Length; i++)//dizinin boyutu kadar bir döngü kuruyoruz yani döngü dizinin boyutu kadar çalışır 5 karakterden oluşuyorsa dögü 5 defa döner
       { 
          switch(dizi[i].ToString())//dizinin i. değeri aşşagıdakilerden biriyse; örnek 15 * 16 sayısı çarpılcak i = 2 ise 2. index * oldugu için çarpma işlemi yapar.
          {
              case "+"://Eğer + operetorunu görürsen isleme +yı ata operatorgorudu ye de 1 ekle
                  islem = "+";
                  operatorgoruldu += 1;
                  break;
              case "-"://Eğer - operetorunu görürsen isleme -yı ata operatorgorudu ye de 1 ekle
                  islem = "-";
                  operatorgoruldu += 1;
                  break;
              case "*":////Eğer * operetorunu görürsen isleme *yı ata operatorgorudu ye de 1 ekle
                  islem = "*";
                  operatorgoruldu += 1;
                  break;
              case "/"://Eğer / operetorunu görürsen isleme / yı ata operatorgorudu ye de 1 ekle
                  islem = "/";
                  operatorgoruldu += 1;
                  break;
              default:
                  if (operatorgoruldu == 0)
                  {
                      sayılar[0] += dizi[i].ToString();//EĞER HİÇ OPERATOR GÖRÜNMEDİYSE SAYILAR DİZİSİNİN 1. İNDEXİNE SAYIYI EKLE
                  }
                  else
                  {
                      sayılar[1] += dizi[i].ToString(); //EĞER OPERETOR SAYILAR DİZİSİNİN 2. İNDEXİNE EKLE
                  }
                  break;
          
          }
           
       }
       switch (islem)
       { 
           case "+"://EĞER İŞLEM DEĞERİ + İSE ;
               return toplam(double.Parse(sayılar[0]), double.Parse(sayılar[1]));//sayı1 ve sayı2 sayılar[0] ve sayılar[1] oldugunu belirtiyoruz buraki sayılar carpıma gidiyor.
               break;
           case "-":
               return cıkartma(double.Parse(sayılar[0]),double.Parse(sayılar[1]) );
               break;
           case "*":
               return carpım(double.Parse(sayılar[0]), double.Parse(sayılar[1]));
               break;
           case "/":
               return bolme(double.Parse(sayılar[0]), double.Parse(sayılar[1]));
               break;
       }
       return 1.2;//Bu kod sadece hatayı kapatmak için yazılmıştır.
           
       }

       public double carpım(double sayı1 , double sayı2)//Sayı1 ve sayı2 çarpılması için bu kodu yazıyoruz çarpıp çıkan sayıyı gei gönderiyor.
       {
           return sayı1 * sayı2;
       
       }

       public double toplam(double sayı1, double sayı2)
       {
           return sayı1 + sayı2;
       }

       public double cıkartma(double sayı1, double sayı2)
       {
           return sayı1 - sayı2;
       }
       public double bolme(double sayı1, double sayı2)
       {
           return sayı1 / sayı2;
       }

    
    }
}
