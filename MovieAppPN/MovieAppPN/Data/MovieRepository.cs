using MovieAppPN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppPN.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;
        static MovieRepository()
        {

            _movies = new List<Movie>
            {
              //  https://www.imdb.com/list/ls062458414/?sort=user_rating,desc&st_dt=&mode=detail&page=1 film bilgileri alındığı yer
                new Movie()
                {
                    Id=1,
                    Name="Esaretin Bedeli",
                    ShortDescription=" Esaretin Bedeli Two imprisoned men bond over ",
                    Description=" <p> Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.  </p>",
                    ImageUrl="1.jpg",
                    CategoryId=1
                    },
                new Movie()
                {
                    Id=2,
                    Name=" Baba",
                    ShortDescription=" Baba The aging patriarch of an organized crime ",
                    Description=" <p> The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.  </p>",
                    ImageUrl="2.jpg",
                    CategoryId=2
                },
                new Movie()
                {
                    Id=3,
                    Name=" Kara Şövalye ",
                    ShortDescription=" Kara Şövalye When the menace known ",
                    Description="<p> When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.  </p>",
                    ImageUrl="3.jpg",
                    CategoryId=3
                },
                new Movie()
                {
                    Id=4,
                    Name=" Baba 2",
                    ShortDescription=" Baba 2 The early life and career of Vito Corleone  ",
                    Description="<p> The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.  </p>",
                    ImageUrl="4.jpg",
                    CategoryId=4
                },
                new Movie()
                {
                    Id=5,
                    Name=" Ucuz Roman",
                    ShortDescription=" Ucuz Roman The lives of two mob hitmen ",
                    Description=" <p> The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.  </p>",
                    ImageUrl="5.jpg",
                    CategoryId=4
                },
                new Movie()
                {
                    Id=6,
                    Name=" Schindler'in Listesi",
                    ShortDescription=" Schindler'in Listesi In German-occupied Poland ",
                    Description="<p> In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.  </p>",
                    ImageUrl="6.jpg",
                    CategoryId=1
                }
            };

        }
        public static List<Movie> Movies
        {
            get { return _movies; }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
