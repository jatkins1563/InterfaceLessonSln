using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class PitBull : IPrint
    {
        public string HeadSize { get; set; }
        public string Type { get; set; } = "PitBull:";

        public void Print()
        {
            Console.WriteLine($"This dog is a {Type}.");
        }
    }
}
