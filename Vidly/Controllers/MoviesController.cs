﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly List<Movie> _movies;

        public MoviesController()
        {
            _movies = new List<Movie>()
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Wall-E" },
            };
        }

        // GET: Movies/
        public ActionResult Index()
        {
            var viewModel = new MoviesIndexViewModel
            {
                Movies = _movies
            };

            return View(viewModel);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1" },
                new Customer { Name = "Customer2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}