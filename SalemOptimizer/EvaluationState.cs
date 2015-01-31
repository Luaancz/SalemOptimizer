using System;
using System.Collections.Generic;
using System.Text;

namespace SalemOptimizer
{
    public class EvaluationState
    {
        private int[] proficiencies = new int[15];
        private int[] inspirationalUses = new int[InspirationalDatabase.Inspirationals.Count];

        public void AddInspirational(Inspirational inspirational)
        {
            var uses = inspirationalUses[inspirational.Id]++;
            var modifier = Math.Min(8, 2 + uses);
            var givenProficiencies = inspirational.Proficiencies;

            var inspiration = 0;

            for (var i = 0; i < givenProficiencies.Length; i++)
            {
                var val = givenProficiencies[i];

                if (val != 0)
                {
                    proficiencies[i] += val;
                    inspiration += val * modifier;
                }
            }

            Inspiration += inspiration / 2;
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
