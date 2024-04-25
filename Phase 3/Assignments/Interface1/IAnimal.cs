using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public interface  IAnimal
    {
        //Property: Name, Habitat, Eating Habit
        public string Name { get; set; }
        public string Habitat { get; set; }
        public string EatingHabit { get; set; }
        //Method: DisplayName
        public void DisplayName()
        {
            
        }
    }
}