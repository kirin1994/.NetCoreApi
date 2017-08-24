using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story." ,
                        }
                    }
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Antwerp1",
                            Description = "Antwerp1Desc."
                        },

                        new PointOfInterest()
                        {
                            Name = "Antwerp2",
                            Description = "Antwerp2Desc."
                        },
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                     {
                        new PointOfInterest()
                        {
                            Name = "Paris1",
                            Description = "Paris1desc."
                        },

                        new PointOfInterest()
                        {
                            Name = "Paris2",
                            Description = "Paris2desc."
                        },
                      }

                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}


