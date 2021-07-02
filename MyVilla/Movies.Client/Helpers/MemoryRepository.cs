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
                new Movie()
                {
                    Id = 1,
                    Title = "Spider Man",
                    ReleaseDate = new DateTime(2019, 7, 10),
                    Poster = "https://m.media-amazon.com/images/M/MV5BZTQyNTU0MDktYTFkYi00ZjNhLWE2ODctMzBkM2U1ZTk3YTMzXkEyXkFqcGdeQXVyNTI4MzE4MDU@._V1_FMjpg_UY337_.jpg",
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Loky - Marven Studio",
                    ReleaseDate= DateTime.Now,
                    Poster = "https://m.media-amazon.com/images/M/MV5BNTkwOTE1ZDYtODQ3Yy00YTYwLTg0YWQtYmVkNmFjNGZlYmRiXkEyXkFqcGdeQXVyNTc4MjczMTM@._V1_.jpg",
                },
                new Movie()
                {
                    Id = 3,
                    Title = "Quiet Place",
                    ReleaseDate = DateTime.Now,
                    Poster = "https://m.media-amazon.com/images/M/MV5BMTE2ODU4NDEtNmRjNS00OTk1LTg4NmMtNTAzYzVlNzJmYjgzXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_FMjpg_UY473_.jpg",
                },
            };
        }
    }
}
