using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public class Leaderboard
    {
        private int slots = 5;
        private Organism[] organisms;

        private double worst = double.MaxValue;

        public Leaderboard(int slots)
        {
            this.slots = slots;
            this.organisms = new Organism[slots];
        }

        public void AddOrganism(Organism organism)
        {
            if (organism.Solution.CostTotal < worst)
            {
                organisms = 
                    organisms
                    .Union(new [] { organism.Clone() })
                    .GroupBy(i => i == null ? null : i.ToString())
                    .Select(i => i.First())
                    .OrderBy(i => i == null ? double.MaxValue : i.Solution.CostTotal)
                    .Take(slots)
                    .ToArray();

                worst = organisms.Max(i => i == null ? double.MaxValue : i.Solution.CostTotal);
            }
        }

        public Organism[] GetBest()
        {
            return organisms;
        }
    }
}
