using Encapsulation;

Araba araba = new Araba("Toyota","Rav4","Mavi",4);
Console.WriteLine($"Marka: {araba.Marka}, Model: {araba.Model}, Renk: {araba.Renk}, Kapı Sayısı: {araba.KapiSayisi}");

Console.ReadKey();