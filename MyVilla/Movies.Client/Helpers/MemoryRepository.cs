using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Helpers
{
    public class MemoryRepository : IRepository
    {
        public List<Movie> GetList()
        {
            return new List<Movie>()
            {
                new Movie(){
                    Title = "Spider Man",
                    ReleaseDate = new DateTime(2019, 7, 10)
                },
                new Movie(){
                    Title = "Arena",
                    ReleaseDate= DateTime.Now
                },
                new Movie(){
                    Title = "Taken",
                    ReleaseDate = DateTime.Now
                },
            };
        }
    }
}
