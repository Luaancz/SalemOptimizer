using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public class Problem
    {
        public Problem()
        {
            Proficiencies = new Dictionary<ProficiencyKind, int>();
        }

        public Dictionary<ProficiencyKind, int> Proficiencies { get; set; }

        public Problem Add(ProficiencyKind kind, decimal value)
        {
            if (value > 0)
            {
                if (Proficiencies.ContainsKey(kind)) Proficiencies[kind] += (int)value;
                else Proficiencies.Add(kind, (int)value);
            }

            return this;
        }
    }
}
