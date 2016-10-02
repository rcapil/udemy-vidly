using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesIndexViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}
