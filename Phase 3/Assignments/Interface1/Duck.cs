using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public class Duck :IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }

        public Duck(string name , string habitat, string eatingHabit)
        {
            Name= name;
            Habitat = habitat;
            EatingHabit = eatingHabit;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Habitat : {Habitat}");
            Console.WriteLine($"EatingHabit : {EatingHabit}");
            
        }
    }
}