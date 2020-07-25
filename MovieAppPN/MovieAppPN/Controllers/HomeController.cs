using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAppPN.Models;
using MovieAppPN.Data;

namespace MovieAppPN.Controllers
{
    public class HomeController : Controller  //using Microsoft.AspNetCore.Mvc;
    {
        public IActionResult Index(int? Id)
        {
            // MovieRepository.Movies
            // CategoryRepository.Categories
            // return View(MovieRepository.Movies);

            List<Movie> movies = MovieRepository.Movies;
            if (Id!=null)
            {
                movies = movies.Where(i => i.CategoryId == Id).ToList();
            }
            return View(movies);
            

            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movies = MovieRepository.Movies;
            //return View(model);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
              return View(MovieRepository.GetById(id));

            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.MovieP = MovieRepository.GetById(id);
            //return View(model);
           
        }
    }
}
