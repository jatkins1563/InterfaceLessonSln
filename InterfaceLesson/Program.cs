using System;

namespace InterfaceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PitBull();
            var ch = new Chihuahua();
            var doge = new ShibaInu();

            var dogs = new IPrint[] { pb, ch, doge };

            foreach (var dog in dogs)
            {
                dog.Print();
            }
        }
    }
}
