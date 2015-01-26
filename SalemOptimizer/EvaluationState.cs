using System;
using System.Collections.Generic;
using System.Text;

namespace SalemOptimizer
{
    public class EvaluationState
    {
        private int[] proficiencies = new int[15];
        private int[] inspirationalUses = new int[InspirationalDatabase.Inspirationals.Count];

        public void AddProficiency(ProficiencyKind kind, int value, double weight)
        {
            proficiencies[(int)kind] += value;

            Inspiration += (int)(value * weight);
        }

        public void AddInspirational(Inspirational inspirational)
        {
            var uses = inspirationalUses[inspirational.Id]++;

            foreach (var prof in inspirational.Proficiencies)
            {
                AddProficiency(prof.Key, prof.Value, Math.Min(4d, 1d + uses * 0.5d));
            }
        }
        
        public int GetValue(ProficiencyKind kind)
        {
            return proficiencies[(int)kind];
        }

        public int Inspiration { get; set; }
    }
}
