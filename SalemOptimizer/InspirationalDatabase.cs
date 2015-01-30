﻿using System;
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
						(cols, index) =>
							new Inspirational
							{
								Name = cols[0],
								Proficiencies =
									cols
										.Select((val, idx) => new { Index = idx, Value = val })
										.Where(i => i.Index >= 2 && i.Index <= 16 && !string.IsNullOrWhiteSpace(i.Value))
										.ToDictionary(i => (ProficiencyKind)(i.Index - 2), i => int.Parse(i.Value)),
								Uses = int.Parse(cols[18]),
								Weight = string.IsNullOrWhiteSpace(cols[1]) ? 1d : double.Parse(cols[1], CultureInfo.InvariantCulture)
							}
					)
					.Where(i => i.Proficiencies.Count > 0)
					.Select((inspirational, index) => { inspirational.Id = index; return inspirational; })
					.ToList();
        }
    }
}
