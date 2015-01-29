using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public class Leaderboard
    {
        private readonly int slots;
        private readonly bool prune;
        private Organism[] organisms;

        private double worst = double.MaxValue;

        public Leaderboard(int slots, bool prune)
        {
            this.slots = slots;
            this.prune = prune;
            this.organisms = new Organism[0];
        }

        public void AddOrganism(Organism organism)
        {
            if (organism.Solution.CostTotal < worst || organisms.Length < slots)
            {
                var tmp =
                    organisms
                    .Union(new[] { organism.Clone() })
                    .GroupBy(i => i == null ? null : i.ToString())
                    .Select(i => i.First());

                if (prune)
                {
                    var tmp2 = tmp.ToArray();
                    tmp = tmp.Where(j => !tmp2.Any(i => i.Solution.CostTotal < j.Solution.CostTotal && j.IsSupersetOf(i)));
                }

                organisms =
                    tmp
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
