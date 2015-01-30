using System;
using System.Collections.Generic;
using System.Text;

namespace SalemOptimizer
{
    public class EvaluationState
    {
        private int[] proficiencies = new int[15];
        private int[] inspirationalUses = new int[InspirationalDatabase.Inspirationals.Count];

        void AddProficiency(int kind, int value, double weight)
        {
            proficiencies[kind] += value;

            Inspiration += (int)(value * weight);
        }

        public void AddInspirational(Inspirational inspirational)
        {
            var uses = inspirationalUses[inspirational.Id]++;
            var modifier = Math.Min(4d, 1d + uses * 0.5d);

            for (var i = 0; i < inspirational.Proficiencies.Length; i++)
            {
                AddProficiency(i, inspirational.Proficiencies[i], modifier);
            }
        }
        
        public int GetValue(ProficiencyKind kind)
        {
            return proficiencies[(int)kind];
        }

        public int Inspiration { get; set; }

        public bool IsSupersetOf(EvaluationState state)
        {
            bool anyBigger = false;

            for (var i = 0; i < inspirationalUses.Length; i++)
            {
                if (inspirationalUses[i] < state.inspirationalUses[i]) return false;
                if (inspirationalUses[i] > state.inspirationalUses[i]) anyBigger = true;
            }

            return anyBigger;
        }
    }
}
