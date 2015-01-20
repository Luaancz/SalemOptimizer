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

        public Organism(Solver solver, Problem problem)
        {
            this.solver = solver;
            this.problem = problem;

            root = new InspirationalBranch(solver) { LeftNode = new InspirationalBranch(solver), RightNode = new InspirationalBranch(solver) };
            Solution = Evaluate(root, problem);
        }
        
        public override string ToString()
        {
            return root.GetNames();
        }

        public static SolutionInformation Evaluate(InspirationalBranch root, Problem problem)
        {
            EvaluationState engine = new EvaluationState();
            root.Evaluate(engine);

            var cost = new SolutionInformation();

            // Add the total inspiration cost
            cost.InspirationTotal += engine.Inspiration;

            // Add extra cost for incomplete solutions
            foreach (var needed in problem.Proficiencies)
            {
                cost.IncompletenessPenalty += Math.Max(0d, needed.Value - engine.GetValue(needed.Key)) * 1000;
            }

            cost.CostTotal = cost.InspirationTotal + cost.IncompletenessPenalty;

            return cost;
        }

        public void Tick()
        {
            InspirationalBranch clone = null;

            clone = (InspirationalBranch)root.Clone();
            clone.Mutate();
            
            var engineNew = new EvaluationState();
            var engineOld = new EvaluationState();

            var newResult = Evaluate(clone, problem);
            var oldResult = Evaluate(root, problem);

            if (newResult.CostTotal < oldResult.CostTotal || Helper.Mutate(10))
            {
                root = clone;
                Solution = newResult;
            }
        }

        public Organism Clone()
        {
            Organism clone = new Organism(solver, problem);
            clone.root = this.root.Clone();
            clone.Solution = this.Solution;
            return clone;
        }

        public Organism MakeCrossOver(Organism father)
        {
            var child = this.Clone();
            var fatherDna = father.GetRandomNode().Clone();
            var motherDna = child.GetRandomNode();
            motherDna.LeftNode = fatherDna.LeftNode;
            motherDna.RightNode = fatherDna.RightNode;

            child.Solution = Evaluate(child.root, problem);
            return child;
        }

        private InspirationalBranch GetRandomNode()
        {
            return root.GetRandomNode();
        }
    }
}
