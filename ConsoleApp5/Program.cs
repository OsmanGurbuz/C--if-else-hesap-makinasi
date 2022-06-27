using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuç;
            char secim;
            Console.WriteLine("birinci sayıyı gir");
            sayi1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikini sayıyı giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1-Toplama 2-Çarpma 3-Çıkarma 4-Bölme işlemi, seçiminizi giriniz");
            secim = Convert.ToChar(Console.ReadLine());

            if (secim=='1')
            {
                sonuç = sayi1 + sayi2;
                Console.WriteLine("toplama sonucu = {0}", sonuç);
            }
            if (secim=='2')
            {
                sonuç= sayi1 - sayi2;   
                Console.WriteLine("çıkarma sonucu = {0}", sonuç);
            }
            if (secim == '3')
            {
                sonuç = sayi1 * sayi2;
                Console.WriteLine("çarpma sonucu = {0}", sonuç);
            }
            if (secim == '4')
            {
                sonuç= sayi1 / sayi2;   
                Console.WriteLine("bölme sonucu = {0}", sonuç);
            }
            Console.ReadKey();
        }
       
    }
}
