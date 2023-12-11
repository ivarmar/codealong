using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codealong
{
    internal class animals
    {
        private string Sound { get; set; }

        private string Name { get; set; }

        public animals(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetSound()
        {
            return Sound;
        }

        public void AnimalGreet()
        {
            Console.WriteLine($"{Sound}");
        }

        public void AnimalName()
        {
            Console.WriteLine($"{Name}");
        }

    }
}
