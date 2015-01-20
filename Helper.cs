using System;
using System.Collections.Generic;
using System.Text;

namespace SalemOptimizer
{
    public static class Helper
    {
        private static Random basicRandom = new Random();

        [ThreadStatic]
        private static Random rnd;

        public static bool Mutate(int chance)
        {
            if (rnd == null)
            {
                lock (basicRandom)
                {
                    rnd = new Random(basicRandom.Next());
                }
            }

            return rnd.Next(chance) == 1;
        }

        public static int GetInt(int chance)
        {
            if (rnd == null)
            {
                lock (basicRandom)
                {
                    rnd = new Random(basicRandom.Next());
                }
            }

            return rnd.Next(chance);
        }

        public static double GetDouble()
        {
            if (rnd == null)
            {
                lock (basicRandom)
                {
                    rnd = new Random(basicRandom.Next());
                }
            }

            return rnd.NextDouble();
        }
    }
}
