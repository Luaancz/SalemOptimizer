using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public static class InspirationalDatabase
    {
        private static readonly Lazy<List<Inspirational>> inspirationals = new Lazy<List<Inspirational>>(Load);

        public static List<Inspirational> Inspirationals { get { return inspirationals.Value; } }

        static List<Inspirational> Load()
        {
            return
                File.ReadAllLines("Inspirationals.tab")
                    .Select(row => row.Split('\t'))
                    .Select
                    (
                        cols =>
                            new Inspirational
                            {
                                Name = cols[0],
                                Proficiencies =
                                    cols
                                        .Select((val, idx) => new { Index = idx, Value = val })
                                        .Where(i => i.Index >= 1 && i.Index <= 15 && !string.IsNullOrWhiteSpace(i.Value))
                                        .ToDictionary(i => (ProficiencyKind)(i.Index - 1), i => int.Parse(i.Value)),
                                Uses = int.Parse(cols[17]),
                                Weight = double.Parse(cols[18], CultureInfo.InvariantCulture)
                            }
                    )
                    .Where(i => i.Proficiencies.Count > 0)
                    .ToList();
        }
    }
}
