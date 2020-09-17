using System;
using System.Collections.Generic;
using System.Text;

namespace lớp_Animal_và_interface_Edible
{
    //Implement Edible:
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }
}
