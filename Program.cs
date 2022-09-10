using System;
using System.Text.RegularExpressions;

namespace Koleksiyonlar_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liste = new int[20];
            for(int i = 0; i < 20; i++)
            {
                devam:
                Console.WriteLine("{0}. elemanı giriniz", i + 1);
                string girilen = Console.ReadLine();
                if (Sayimi(girilen))
                {
                    liste[i] = Convert.ToInt32(girilen);
                }
                else
                {
                    Console.WriteLine("Lütfen sayi giriniz");
                    goto devam;
                }
            }

         siralaveyazdir(liste);

        }
        public static void siralaveyazdir(int[] liste)
        {
            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    if (liste[i] > liste[j])
                    {
                        int temp = liste[j];
                        liste[j] = liste[i];
                        liste[i] = temp;
                    }
                }
            }
            Console.WriteLine("En büyük 3 sayi={0},{1},{2}  Ortalaması={3}", liste[0], liste[1], liste[2], (liste[0] + liste[1] + liste[2])/3);
            Console.WriteLine("En kucuk 3 sayi={0},{1},{2}  Ortalaması={3}", liste[17], liste[18], liste[19], (liste[17] + liste[18] + liste[19]) / 3);
            Console.WriteLine("Ortalama toplamları={0}", (liste[0] + liste[1] + liste[2]) / 3 + (liste[17] + liste[18] + liste[19]) / 3);
        }
        public static bool Sayimi(string girilen)
        {
            if (String.IsNullOrEmpty(girilen) == true)
            {
                return false;
            }
            else
            {
            Regex reg = new Regex("^[0-9]*$");
                return reg.IsMatch(girilen);
            }
        }
    }
}
