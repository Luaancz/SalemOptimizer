using System;
using System.Collections.Generic;
using System.Text;

namespace SalemOptimizer
{
    public class RandomHelper
    {
        private static Random basicRandom = new Random();
        private RndXorshift rnd;

        public RandomHelper()
        {
            lock (basicRandom)
            {
                rnd = new RndXorshift(basicRandom);
            }
        }

        public ushort GetShort(int chance)
        {
            return (ushort)(rnd.Next() % chance);
            //return (ushort)Math.Min(chance - 1, ((rnd.Next() * chance) / ushort.MaxValue));
        }

        public bool Mutate(int chance)
        {
            return GetShort(chance) == 1;
        }
    }
}
