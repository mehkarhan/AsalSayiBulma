using System;

namespace AsalSayiBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n************Bir sayının Asal olup olmadığını bulma programı************\n");
            byte x = 1;
            while (x!=2)
            {
                Console.WriteLine("\n\n Hangi işlemi yapmak istersiniz?");
                Console.WriteLine(" 1- Asal sayı hesabı yapmak. \n 2- Çıkış\n");
                Console.Write(" Hangi işlemi yapmak istersiniz :");
                x = byte.Parse(Console.ReadLine());
                if (x==1)
                {
                    Console.Write("\n\n Sayıyı Giriniz :");
                    int sayi = int.Parse(Console.ReadLine());
                    int sayac = 0;
                    for (int i= 2; i < sayi; i++)
                    {
                        if (sayi%i==0)
                        {
                            sayac++;
                        }

                    }
                    if (sayac==0)
                    {
                        Console.WriteLine("\n\n Girdiğiniz sayı Asal sayıdır.");
                    }
                    else
                    {
                        Console.WriteLine("\n\n Girilen sayı Asal sayı değildir. ");
                    }
                }
                else
                {
                    Console.WriteLine(" Program sonlandırılıyor");
                }
            }

        }
    }
}
