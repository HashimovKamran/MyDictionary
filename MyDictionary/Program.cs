using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanici = new Dictionary<int, string>();
            kullanici.Add(0, "Kerem");
            kullanici.Add(1, "Ali");
            kullanici.Add(2, "Furkan");
            kullanici.Add(3, "Emirhan");
            kullanici.Add(4, "Sinan");

            foreach (var k in kullanici)
            {
                Console.WriteLine(k);
            }
        }
    }
}
