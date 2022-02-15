using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorResturent.Models.Service
{
    public class ResturentService
    {
        List<Resturant> resturants= new List<Resturant> 
        { 
           new Resturant{Id = 1, Name = "Olyris", Cuisine = CuisineType.Swedish, Location = "Valand" },
           new Resturant{Id = 2, Name = "Bodarnas", Cuisine = CuisineType.Italian, Location = "Brusparking" },
           new Resturant{Id = 3, Name = "Tarka", Cuisine = CuisineType.Indain, Location = "Jagntoget" },
           new Resturant{Id = 4, Name = "Dine", Cuisine = CuisineType.FastFood, Location = "KungsPortplatsen" },

        };
        
        
        public IEnumerable<Resturant> GettAllResturantByName(string name=null)
        {
            return from r in resturants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Resturant GetResturantById(int id)
        {
            var model = resturants.Where(c => c.Id == id).FirstOrDefault();

            return model;
        }
    }
}
