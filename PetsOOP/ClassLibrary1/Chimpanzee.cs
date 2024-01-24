using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Chimpanzee : Pet
    {
        public Chimpanzee(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + "Hoots at you.");
        }
        public void HideInShell()
        {
            Console.WriteLine(Name + "Throws poop.");
        }

        public void Meet(Cat newFriend)
        {
            Console.WriteLine(Name + "Attacks." + newFriend.Name);
        }
    }
}
