using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class ShibaInu : IPrint
    {
        public string Characteristic { get; set; } = "Standoffish";
        public string Type { get; set; } = "Shiba Inu";

        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and it is {Characteristic}.");
        }
    }
}
