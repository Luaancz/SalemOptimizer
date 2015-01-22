using System;
using System.Collections.Generic;
using System.Text;

namespace SalemOptimizer
{
    public class EvaluationState
    {
        private int[] proficiencies = new int[15];

        public void AddProficiency(ProficiencyKind kind, int value, double weight)
        {
            proficiencies[(int)kind] += value;

            Inspiration += (int)(value * weight);
        }
        
        public int GetValue(ProficiencyKind kind)
        {
            return proficiencies[(int)kind];
        }

        public int Inspiration { get; set; }
    }
}
