using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Shared.Entities
{
    public class MovieGenres
    {
        public int MovieId { get; set; }

        public int GenresId { get; set; }

        public Genre Genre { get; set; }

        public Movie Movie { get; set; }
    }
}
