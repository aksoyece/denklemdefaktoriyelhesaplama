using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikmis2.sorudenklemmm
{
    internal class Program
    {
        static double faktoriyel(uint sayi)
        {
            double sonuc = 1;
            for (uint i = 2; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Denklemi girin (örn: 3x^2+1x^2+5x^2+2x^2=1):");
            string ifade = Console.ReadLine();

            string[] denklemParcalari = ifade.Split('=');
            string terimlerStr=denklemParcalari[0];
            uint c = uint.Parse(denklemParcalari[1]);

            string[] terimler = terimlerStr.Split('+');

            double toplam = 0;

            foreach (string terim in terimler)
            {
                string[] parca = terim.Split(new string[] { "x^" }, StringSplitOptions.None);
                uint a=uint.Parse(parca[0]);
                uint n=uint.Parse(parca[1]);

                double aFaktoriyel = faktoriyel(a);
                double nFaktoriyel = faktoriyel(n);

                double toplamFaktoriyel = aFaktoriyel + nFaktoriyel;

                double sonuc = Math.Pow((double)toplamFaktoriyel, c);
                toplam += sonuc;
            }
            Console.WriteLine("Sonuc: " + toplam);
            Console.ReadKey();
        }
    }
}
