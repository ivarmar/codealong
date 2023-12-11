namespace codealong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The farm!");

            var farmplace = new farm();

            var ku = new animals("Ku", "MØØØØØ!");
            var sau = new animals("Sau", "BÆÆÆÆ!");
            var hest = new animals("Hest", "vrinsk, vrinsk");
            var rat = new animals("rat", "KREEET, SCREET");
            farmplace.AddAnimal(hest);
            farmplace.AddAnimal(sau);
            farmplace.AddAnimal(ku);
            farmplace.AddAnimal(rat);

            Console.WriteLine($"On the farm you see several mutated animals");
            foreach (var dyr in farmplace.dyr)
            {
                dyr.AnimalName();
            }
            Console.WriteLine("They make horrible sounds! (you hear from the distance) ");

            foreach (var dyr in farmplace.dyr)
            {
                dyr.AnimalGreet();
            }

            while (true)
            {
                Console.WriteLine("Marius 'The Farmer' Welcomes you to his farm");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Say hello to a specific animal");
                Console.WriteLine("2. I need to deliver my own 'animal' for Marius to 'Take care of'");
                Console.WriteLine("3. Leave in a rush!");

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("YOU WANT TO SEE WHAT ANIMAL CLOSER?!");
                        var selectedAnimalName = Console.ReadLine();

                        var selectedAnimal = farmplace.GetAnimal(selectedAnimalName);

                        if (selectedAnimal != null)
                        {
                            Console.WriteLine($"You absolute maniac! The {selectedAnimal.GetName()} comes raging towards you! it screeches!");
                            selectedAnimal.AnimalGreet();
                        }
                        else
                        {
                            Console.WriteLine($"we don' have that kin' o' '{selectedAnimalName}'.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("I see you are bringing your own fierce beast to the farm");
                        Console.WriteLine("What species is it?!?!(Marius 'The Farmer' looks at you with a manic expression)");
                        var animalspecies = Console.ReadLine();
                        Console.WriteLine("What horrid sound does it make?!(Marius 'The Farmer' giggles as hes imagining it)");
                        var animalSound = Console.ReadLine();
                        var newAnimal = new animals(animalspecies, animalSound);
                        farmplace.AddAnimal(newAnimal);
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("I did'nt quite catch that, say again?");
                        break;
                }
            }
        }
    }
}
