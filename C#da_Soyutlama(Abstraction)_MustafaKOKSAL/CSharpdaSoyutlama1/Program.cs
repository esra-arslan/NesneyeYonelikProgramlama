﻿using System;

namespace CSharpdaSoyutlama1
{
    abstract class mobilya
    {
        public string renk;
        abstract public void ozellikyaz();
    }
    class kanepe : mobilya
    {
        public string kumas;
        public override void ozellikyaz()
        {
            Console.WriteLine("Kanepenin Özellikleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("Kumaş: {0}", kumas);
        }
    }
    class masa : mobilya
    {
        public string malzeme;
        public override void ozellikyaz()
        {
            Console.WriteLine("Masanın Özellikleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("Malzeme: {0}", malzeme);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            kanepe knp1 = new kanepe();
            masa calisma_masasi = new masa();
            knp1.renk = "Siyah";
            knp1.kumas = "Deri";
            calisma_masasi.renk = "Sarı";
            calisma_masasi.malzeme = "Ahşap";
            knp1.ozellikyaz();
            calisma_masasi.ozellikyaz();
            Console.ReadKey();
        }
    }
}
