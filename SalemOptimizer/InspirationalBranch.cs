using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public class InspirationalBranch
    {
        private Solver solver;

        public InspirationalBranch(Solver solver)
        {
            this.solver = solver;

            Inspirational = solver.AvailableInspirationals[Helper.GetInt(solver.AvailableInspirationals.Length)];
        }

        public InspirationalBranch CreateRandomNode()
        {
            var newNode = new InspirationalBranch(solver);
            newNode.Inspirational = solver.AvailableInspirationals[Helper.GetInt(solver.AvailableInspirationals.Length)];

            return newNode;
        }

        public Inspirational Inspirational { get; set; }

        public override string ToString()
        {
            return Inspirational.Name;
        }

        public IEnumerable<string> GetNames()
        {
            var nodes = new List<InspirationalBranch>();

            TraverseNode(this, nodes);

            return nodes.GroupBy(i => i.Inspirational.Name).OrderBy(i => i.Key).Select(i => i.Count().ToString() + "x " + i.Key);
        }
        
        public void Mutate()
        {
            if (Helper.Mutate(100))
            {
                Inspirational = solver.AvailableInspirationals[Helper.GetInt(solver.AvailableInspirationals.Length)];
            }

            if (LeftNode != null) LeftNode.Mutate();
            if (RightNode != null) RightNode.Mutate();

            if (LeftNode == null)
            {
                if (Helper.Mutate(20)) LeftNode = CreateRandomNode();
                else if (Helper.Mutate(20)) LeftNode = this.Clone();
            }
            else
            {
                if (Helper.Mutate(50)) LeftNode = null;
            }

            if (RightNode == null)
            {
                if (Helper.Mutate(20)) RightNode = CreateRandomNode();
                else if (Helper.Mutate(20)) RightNode = this.Clone();
            }
            else
            {
                if (Helper.Mutate(50)) RightNode = null;
            }
        }
        
        public void Evaluate(EvaluationState engine)
        {
            var nodes = new List<InspirationalBranch>();
            TraverseNode(this, nodes);

            foreach (var node in nodes)
            {
                engine.AddInspirational(node.Inspirational);
            }
        }

        public InspirationalBranch Clone()
        {
            InspirationalBranch clone = new InspirationalBranch(solver);

            if (LeftNode != null) clone.LeftNode = LeftNode.Clone();
            if (RightNode != null) clone.RightNode = RightNode.Clone();

            return clone;
        }
        
        public InspirationalBranch LeftNode { get; set; }
        public InspirationalBranch RightNode { get; set; }

        public InspirationalBranch GetRandomNode()
        {
            var nodes = new List<InspirationalBranch>();
            TraverseNode(this, nodes);

            var index = Helper.GetInt(nodes.Count);
            return nodes[index];
        }

        private void TraverseNode(InspirationalBranch part, List<InspirationalBranch> nodes)
        {
            nodes.Add(part);

            if (part.LeftNode != null)
            {
                TraverseNode(part.LeftNode, nodes);
            }

            if (part.RightNode != null)
            {
                TraverseNode(part.RightNode, nodes);
            }
        }

    }
}
