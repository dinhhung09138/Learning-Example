using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Shared.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]

        public string Name { get; set; }

        public List<MovieGenres> MovieGenres { get; set; } = new List<MovieGenres>();

    }
}
