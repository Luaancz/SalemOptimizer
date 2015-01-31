using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public class Solver
    {
        private readonly Problem problem;
        private readonly Inspirational[] availableInspirationals;
        private readonly CancellationToken cancellationToken;
        private readonly Organism[] includedOrganisms;
        public readonly RandomHelper RandomHelper;

        public Solver(Problem problem, Inspirational[] availableInspirationals, CancellationToken cancellationToken, Organism[] includedOrganisms)
        {
            this.problem = problem;
            this.availableInspirationals = availableInspirationals;
            this.cancellationToken = cancellationToken;
            this.includedOrganisms = includedOrganisms;
            this.RandomHelper = new RandomHelper();
        }

        public Inspirational[] AvailableInspirationals { get { return availableInspirationals; } }

        public Organism[] Solve(bool prune)
        {
            var leaderboard = new Leaderboard(5, prune);

            var organisms = new List<Organism>();
            var generations = 0;

            for (int i = 0; i < 50; i++)
            {
                Organism organism = new Organism(this, problem);
                organisms.Add(organism);
                leaderboard.AddOrganism(organism);
            }

            if (includedOrganisms != null)
            {
                foreach (var organism in includedOrganisms.Select(i => i.Clone(this)))
                {
                    organisms.Add(organism);
                    leaderboard.AddOrganism(organism);
                }
            }

            var best = default(Organism);
            var worst = default(Organism);
            var bestCost = double.MaxValue;
            var worstCost = 0d;

            var newBest = false;

            while (generations < 2000)
            {
                if (cancellationToken.IsCancellationRequested) break;

                generations++;

                newBest = false;

                foreach (var organism in organisms)
                {
                    organism.Tick();

                    leaderboard.AddOrganism(organism);

                    if (organism.Solution.CostTotal < bestCost)
                    {
                        bestCost = organism.Solution.CostTotal;
                        best = organism;

                        newBest = true;
                    }

                    if (organism.Solution.CostTotal > worstCost)
                    {
                        worstCost = organism.Solution.CostTotal;
                        worst = organism;
                    }
                }

                if (RandomHelper.GetShort(10) == 1)
                {
                    organisms.Remove(worst);
                    Organism clone = best.Clone(this);
                    organisms.Add(clone);
                }
                else if (RandomHelper.GetShort(30) == 1)
                {
                    organisms.Remove(worst);

                    var index = RandomHelper.GetShort(organisms.Count);
                    Organism clone = organisms[index].Clone(this);
                    organisms.Add(clone);
                }
                else if (RandomHelper.GetShort(100) == 1)
                {
                    organisms.Remove(worst);

                    int index = RandomHelper.GetShort(organisms.Count);
                    Organism mother = best;
                    Organism father = organisms[index];

                    Organism child = mother.MakeCrossOver(father);
                    organisms.Add(child);
                }

                worst = null;
                worstCost = 0d;

                if (newBest) Console.WriteLine(generations + ": Current (" + bestCost + ", " + best.Solution.IncompletenessPenalty + "): " + best.ToString());
            }

            Console.WriteLine("Done.");

            return leaderboard.GetBest();
        }
    }
}
