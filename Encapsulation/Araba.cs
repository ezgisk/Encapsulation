using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba // Creating Araba class
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int _kapiSayisi; // Encapsulation

        public int KapiSayisi
        {
            get
            {
                return _kapiSayisi;
            }
            set
            {
                if (value == 2 && value == 4)// Kapi sayisi iki ya da dort ise  dogru degeri donuyor
                {
                    _kapiSayisi = value;
                } 
                else
                {
                    Console.WriteLine("Hatalı kapı sayısı! Kapı sayısı 2 veya 4 olmalıdır. Kapı sayısı -1 olarak atanıyor.");
                    value = -1;
                }
            }
        }
        public Araba(string marka, string model, string renk, int kapiSayisi) // Araba constructor
        {
            Marka = marka;
            Model = model;
            Renk = renk;    
            KapiSayisi = kapiSayisi;


        }
    }

    
}

