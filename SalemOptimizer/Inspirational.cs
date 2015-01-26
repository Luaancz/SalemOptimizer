using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public class Inspirational
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Uses { get; set; }
        public int Amount { get; set; }

        public double Weight { get; set; }

        public Dictionary<ProficiencyKind, int> Proficiencies { get; set; }

        public int Inspiration { get { return Proficiencies.Sum(i => i.Value); } }

        public Inspirational Clone()
        {
            var clone = new Inspirational();

            clone.Name = Name;
            clone.Weight = Weight;

            clone.Proficiencies = Proficiencies.ToDictionary(i => i.Key, i => i.Value);

            return clone;
        }
    }
}
