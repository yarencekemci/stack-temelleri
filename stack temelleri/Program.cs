using System;
using System.Collections.Generic;

namespace stack_temelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();


            while (sayi>0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }
            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x " + 
                    $"{Math.Pow(10,n-i),7} = " + 
                    $" {s*Math.Pow(10,n-i),7}");
                i++;
            }




            Console.ReadKey();
        }

        private static void karakteryiginornegi()
        {
            var karakteryigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakteryigini.Push((char)i);
                Console.WriteLine($"{karakteryigini.Peek()} yığına eklendi");
                Console.WriteLine($"yığındaki eleman sayisi: {karakteryigini.Count}");
            }
            Console.WriteLine("yığından çıkartma işlemi için bir tuşa basın.");
            Console.ReadKey();

            while (karakteryigini.Count > 0)
            {
                Console.WriteLine($"{karakteryigini.Pop()} yığından çıkartıldı.");
                Console.WriteLine($"yığındaki eleman sayisi: {karakteryigini.Count}");
            }
        }

        private static void yiginornegi()
        {
            //stack tanımlama
            var karakteryigini = new Stack<char>();

            //ekleme
            karakteryigini.Push('Y');
            Console.WriteLine(karakteryigini.Peek());
            karakteryigini.Push('R');
            Console.WriteLine(karakteryigini.Peek());
            karakteryigini.Push('N');
            Console.WriteLine(karakteryigini.Peek());

            //cıkarma
            Console.WriteLine(karakteryigini.Pop() + " yığında çıkartıldı. ");
            Console.WriteLine(karakteryigini.Pop() + " yığında çıkartıldı. ");
            Console.WriteLine(karakteryigini.Pop() + " yığında çıkartıldı. ");


            Console.ReadKey();
        }
    }
}
