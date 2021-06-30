using Movies.Shared.Entities;
using System.Collections.Generic;

namespace Movies.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetList();
    }
}
