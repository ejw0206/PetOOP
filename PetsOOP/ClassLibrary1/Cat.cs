using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + "meows at you.");
        }

        public void Climb()
        {
            Console.WriteLine(Name + "Climbs the wall.");
        }

        public void Meet(Chimpanzee newFriend)
        {
            Console.WriteLine(Name + "Scratches at" + newFriend.Name);
        }

        public void Meet(Turtle newFriend)
        {
            Console.WriteLine(Name + "Accepts its fate." + newFriend.Name);
        }
    }
}
