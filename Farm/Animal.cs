using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
     abstract internal class Animal
     {
        public string sound;
        public int weight;

        public void MakeSound()
        {
            Console.WriteLine(sound);
        }
    }
}
