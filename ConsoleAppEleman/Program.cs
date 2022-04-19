using System;
using System.Collections;

namespace ConsoleAppEleman
{
    class Program
    {
        static void Main(string[] args) 
        {
            ArrayList elemanlar = new ArrayList();

            string x;
            for(int i = 0; i < 5; i++)
            {
                Console.Write((i + 1) + ".ismi giriniz :");
                x = Console.ReadLine();
                elemanlar.Add(x);

            }
            Console.WriteLine("Elemanlar ekrana yazılıyor");
            for (int i =0;i <5;i++)
            {
                Console.WriteLine((i + 1) + ".isim {0}", elemanlar[i]);
            }
            Console.ReadKey();
        }
    }
}
