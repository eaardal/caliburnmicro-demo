using System.Collections.Generic;

namespace CaliburnDemo
{
    class ObjectGraph
    {
        public static List<Country> Generate()
        {
            var countries = new List<Country>();

            var usa = new Country
            {
                Name = "USA",
                Population = 280000000,
                States = new List<State>
                {
                    new State
                    {
                        Name = "Texas",
                        Counties = new List<County>
                        {
                           new County
                           {
                               Name = "Jones"
                           },
                           new County
                           {
                               Name = "Duval"
                           },
                           new County
                           {
                               Name = "Falls"
                           }
                        }
                    },
                    new State
                    {
                        Name = "Georgia",
                        Counties = new List<County>
                        {
                            new County
                            {
                                Name = "Laurens"
                            },
                            new County
                            {
                                Name = "Charlton"
                            }
                        }
                    }
                }
            };
            
            countries.Add(usa);
            countries.Add(usa);
            countries.Add(usa);

            return countries;
        } 
    }

    internal class Country
    {
        public string Name { get; set; }
        public long Population { get; set; }
        public List<State> States { get; set; }

        public Country()
        {
            States = new List<State>();
        }
    }

    internal class State
    {
        public string Name { get; set; }
        public List<County> Counties { get; set; }
    }

    internal class County
    {
        public string Name { get; set; }
    }
}
