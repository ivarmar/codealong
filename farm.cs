using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codealong
{
    internal class farm
    {
        public List<animals> dyr { get; set; }

        public farm ()
        {
            dyr = new List<animals> ();

        }

        public void AddAnimal(animals animal)
        {
            dyr.Add (animal);
        }

        public animals GetAnimal(string animalName)
        {
            var selectedAnimal = dyr.FirstOrDefault(animal => animal.GetName().Equals(animalName, StringComparison.OrdinalIgnoreCase));
            return selectedAnimal;

        }

    }
}
