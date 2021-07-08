using Movies.Client.Helpers;
using Movies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IHttpService _httpService;
        private readonly string Url = "https://localhost:44369/api/genres";

        public GenreRepository(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task CreateGenre(Genre genre)
        {
            var response = await _httpService.Post(Url, genre);
            if (response.Success == false) {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
