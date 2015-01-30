using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public class Inspirational
    {
        public Inspirational(string name, int uses, int[] proficiencies)
        {
            this.Name = name;
            this.Uses = uses;
            this.Proficiencies = proficiencies;
            this.Inspiration = proficiencies.Sum();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Uses { get; set; }
        public int Amount { get; set; }

        public double Weight { get; set; }

        public int[] Proficiencies;

        public int Inspiration { get; private set; }
    }
}
