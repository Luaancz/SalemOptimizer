using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalemOptimizer
{
    public static class InspirationalDatabase
    {
        public static List<Inspirational> Inspirationals { get; set; }

        static InspirationalDatabase()
        {
            Inspirationals = 
                new List<Inspirational>
                {
                    new Inspirational 
                    { 
                        Name = "A Taste of Autumn", Uses = 2, Weight = 1d, 
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            { 
                                { ProficiencyKind.CloakAndDagger, 300 }, 
                                { ProficiencyKind.FloraAndFauna, 575 }, 
                                { ProficiencyKind.HerbsAndSprouts, 875 }, 
                                { ProficiencyKind.HuntingAndHideworking, 245 }, 
                                { ProficiencyKind.LawAndLore, 620 }, 
                                { ProficiencyKind.MinesAndMountains, 435 }, 
                                { ProficiencyKind.NaturalPhilosophy, 520 } 
                            } 
                    },
                    new Inspirational
                    {
                        Name = "Abandoned Cobweb", Uses = 1, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 450 },
                                { ProficiencyKind.FloraAndFauna, 550 },
                                { ProficiencyKind.HerbsAndSprouts, 450 },
                                { ProficiencyKind.HuntingAndHideworking, 350 },
                                { ProficiencyKind.ThreadAndNeedle, 900 },
                                { ProficiencyKind.NaturalPhilosophy, 725 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Clover", Uses = 1, Weight = 100d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.FaithAndWisdom, 450 },
                                { ProficiencyKind.FloraAndFauna, 330 },
                                { ProficiencyKind.LawAndLore, 300 },
                                { ProficiencyKind.StocksAndCultivars, 250 },
                                { ProficiencyKind.SugarAndSpice, 320 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Dead Wartbite Cricket", Uses = 1, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.FloraAndFauna, 700 },
                                { ProficiencyKind.HerbsAndSprouts, 500 },
                                { ProficiencyKind.HuntingAndHideworking, 900 },
                                { ProficiencyKind.NaturalPhilosophy, 200 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Decorative Woodcarving", Uses = 2, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 620 },
                                { ProficiencyKind.FaithAndWisdom, 240 },
                                { ProficiencyKind.HammerAndNail, 1280 },
                                { ProficiencyKind.HuntingAndHideworking, 350 },
                                { ProficiencyKind.StocksAndCultivars, 500 },
                                { ProficiencyKind.SugarAndSpice, 500 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Devil's Wort", Uses = 1, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.CloakAndDagger, 150 },
                                { ProficiencyKind.FaithAndWisdom, 250 },
                                { ProficiencyKind.HerbsAndSprouts, 750 },
                                { ProficiencyKind.NaturalPhilosophy, 1125 },
                                { ProficiencyKind.PerenialPhilosophy, 45 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Fine Beaver Teeth", Uses = 2, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.CloakAndDagger, 550 },
                                { ProficiencyKind.HerbsAndSprouts, 1075 },
                                { ProficiencyKind.HuntingAndHideworking, 1550 },
                                { ProficiencyKind.LawAndLore, 900 },
                                { ProficiencyKind.ThreadAndNeedle, 800 },
                                { ProficiencyKind.NaturalPhilosophy, 500 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Four-leaf Clover", Uses = 13, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.FaithAndWisdom, 2850 },
                                { ProficiencyKind.HerbsAndSprouts, 2230 },
                                { ProficiencyKind.PerenialPhilosophy, 1420 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Lumberwood Figurine", Uses = 2, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 340 },
                                { ProficiencyKind.CloakAndDagger, 190 },
                                { ProficiencyKind.FaithAndWisdom, 340 },
                                { ProficiencyKind.FloraAndFauna, 275 },
                                { ProficiencyKind.HammerAndNail, 640 },
                                { ProficiencyKind.LawAndLore, 350 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Oak Duff", Uses = 1, Weight = 2d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.HerbsAndSprouts, 200 },
                                { ProficiencyKind.LawAndLore, 185 },
                                { ProficiencyKind.SparksAndEmbers, 175 },
                                { ProficiencyKind.StocksAndCultivars, 135 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Petrified Wood", Uses = 7, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 2500 },
                                { ProficiencyKind.HammerAndNail, 2500 },
                                { ProficiencyKind.MinesAndMountains, 4250 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Peyote Cactus", Uses = 1, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.CloakAndDagger, 250 },
                                { ProficiencyKind.HuntingAndHideworking, 1250 },
                                { ProficiencyKind.StocksAndCultivars, 750 },
                                { ProficiencyKind.SugarAndSpice, 1250 },
                                { ProficiencyKind.NaturalPhilosophy, 900 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Red Trillium", Uses = 1, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.HammerAndNail, 250 },
                                { ProficiencyKind.HerbsAndSprouts, 655 },
                                { ProficiencyKind.HuntingAndHideworking, 230 },
                                { ProficiencyKind.LawAndLore, 310 },
                                { ProficiencyKind.MinesAndMountains, 1375 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Rusty Coin", Uses = 1, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 50 },
                                { ProficiencyKind.LawAndLore, 290 },
                                { ProficiencyKind.MinesAndMountains, 170 },
                                { ProficiencyKind.SparksAndEmbers, 160 },
                                { ProficiencyKind.NaturalPhilosophy, 75 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Shed Skin", Uses = 7, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.CloakAndDagger, 2500 },
                                { ProficiencyKind.HuntingAndHideworking, 2500 },
                                { ProficiencyKind.ThreadAndNeedle, 4250 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Simple Crucifix", Uses = 2, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 350 },
                                { ProficiencyKind.FaithAndWisdom, 700 },
                                { ProficiencyKind.HammerAndNail, 400 },
                                { ProficiencyKind.LawAndLore, 350 },
                                { ProficiencyKind.PerenialPhilosophy, 40 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Singing Old Log", Uses = 1, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.CloakAndDagger, 900 },
                                { ProficiencyKind.FaithAndWisdom, 1000 },
                                { ProficiencyKind.FloraAndFauna, 2250 },
                                { ProficiencyKind.LawAndLore, 1900 },
                                { ProficiencyKind.SparksAndEmbers, 2600 },
                                { ProficiencyKind.StocksAndCultivars, 1500 },
                                { ProficiencyKind.PerenialPhilosophy, 400 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Smooth Stone", Uses = 1, Weight = 2d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 340 },
                                { ProficiencyKind.FloraAndFauna, 440 },
                                { ProficiencyKind.HammerAndNail, 350 },
                                { ProficiencyKind.HuntingAndHideworking, 290 },
                                { ProficiencyKind.MinesAndMountains, 375 },
                                { ProficiencyKind.SparksAndEmbers, 250 },
                                { ProficiencyKind.NaturalPhilosophy, 220 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Spinning Top", Uses = 2, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 650 },
                                { ProficiencyKind.HammerAndNail, 850 },
                                { ProficiencyKind.ThreadAndNeedle, 900 },
                                { ProficiencyKind.NaturalPhilosophy, 250 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Spring Beauty", Uses = 1, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 265 },
                                { ProficiencyKind.FloraAndFauna, 1450 },
                                { ProficiencyKind.HerbsAndSprouts, 665 },
                                { ProficiencyKind.ThreadAndNeedle, 280 },
                                { ProficiencyKind.NaturalPhilosophy, 380 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Steer Skull", Uses = 1, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 725 },
                                { ProficiencyKind.CloakAndDagger, 385 },
                                { ProficiencyKind.FloraAndFauna, 900 },
                                { ProficiencyKind.HammerAndNail, 825 },
                                { ProficiencyKind.HuntingAndHideworking, 675 },
                                { ProficiencyKind.MinesAndMountains, 425 },
                                { ProficiencyKind.SparksAndEmbers, 550 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Tumbleweed", Uses = 1, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.CloakAndDagger, 550 },
                                { ProficiencyKind.FaithAndWisdom, 1440 },
                                { ProficiencyKind.FloraAndFauna, 1750 },
                                { ProficiencyKind.StocksAndCultivars, 1350 },
                                { ProficiencyKind.NaturalPhilosophy, 850 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Walking the Beetle", Uses = 2, Weight = 1d,
                        Proficiencies =
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.LawAndLore, 950 },
                                { ProficiencyKind.MinesAndMountains, 1400 },
                                { ProficiencyKind.StocksAndCultivars, 450 },
                                { ProficiencyKind.ThreadAndNeedle, 1450 }
                            }
                    },
                    new Inspirational
                    {
                        Name = "Wood choppings", Uses = 1, Weight = 1d,
                        Proficiencies = 
                            new Dictionary<ProficiencyKind,int>
                            {
                                { ProficiencyKind.ArtsAndCrafts, 250 },
                                { ProficiencyKind.FloraAndFauna, 50 },
                                { ProficiencyKind.HammerAndNail, 150 },
                                { ProficiencyKind.HuntingAndHideworking, 75 },
                                { ProficiencyKind.SparksAndEmbers, 130 }
                            }
                    }
                };
        }
    }
}
