using System;
using System.Collections.Generic;
using System.Text;

namespace SalemOptimizer
{
    public class Organism
    {
        private InspirationalBranch root;
        private Solver solver;
        private Problem problem;

        public SolutionInformation Solution = new SolutionInformation { CostTotal = int.MaxValue };
        private EvaluationState lastEvaluation;

        public Organism(Solver solver, Problem problem)
        {
            this.solver = solver;
            this.problem = problem;

            root = new InspirationalBranch(solver) { LeftNode = new InspirationalBranch(solver), RightNode = new InspirationalBranch(solver) };
            lastEvaluation = new EvaluationState();
            Solution = Evaluate(root, lastEvaluation, problem);
        }
        
        public bool IsSupersetOf(Organism organism)
        {
            if (lastEvaluation == null || organism.lastEvaluation == null) return false;

            return lastEvaluation.IsSupersetOf(organism.lastEvaluation);
        }

        private string cachedNames;
        public override string ToString()
        {
            if (cachedNames != null) return cachedNames;

            return cachedNames = string.Join(", ", root.GetNames());
        }

        public IEnumerable<string> GetNames()
        {
            return root.GetNames();
        }

        private static SolutionInformation Evaluate(InspirationalBranch root, EvaluationState state, Problem problem)
        {
            root.Evaluate(state);

            var cost = new SolutionInformation();

            // Add the total inspiration cost
            cost.InspirationTotal += state.Inspiration;

            // Add extra cost for incomplete solutions
            foreach (var needed in problem.Proficiencies)
            {
                cost.IncompletenessPenalty += Math.Max(0d, needed.Value - state.GetValue(needed.Key)) * 1000;
            }

            cost.CostTotal = cost.InspirationTotal + cost.IncompletenessPenalty;

            return cost;
        }

        public void Tick()
        {
            InspirationalBranch clone = null;

            clone = (InspirationalBranch)root.Clone();
            clone.Mutate();
            
            var stateNew = new EvaluationState();

            var newResult = Evaluate(clone, stateNew, problem);

            if (newResult.CostTotal < Solution.CostTotal || Helper.Mutate(10))
            {
                root = clone;
                Solution = newResult;
                lastEvaluation = stateNew;

                cachedNames = null;
            }
        }

        public Organism Clone()
        {
            Organism clone = new Organism(solver, problem);
            clone.root = this.root.Clone();
            clone.Solution = this.Solution;
            clone.lastEvaluation = lastEvaluation;
            clone.cachedNames = cachedNames;
            return clone;
        }

        public Organism MakeCrossOver(Organism father)
        {
            var child = this.Clone();
            var fatherDna = father.GetRandomNode().Clone();
            var motherDna = child.GetRandomNode();
            motherDna.LeftNode = fatherDna.LeftNode;
            motherDna.RightNode = fatherDna.RightNode;

            var state = new EvaluationState();
            child.Solution = Evaluate(child.root, state, problem);
            child.lastEvaluation = state;
            child.cachedNames = null;
            return child;
        }

        private InspirationalBranch GetRandomNode()
        {
            return root.GetRandomNode();
        }
    }
}
