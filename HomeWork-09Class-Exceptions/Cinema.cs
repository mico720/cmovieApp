 
using System.Collections.Generic;
using System.Linq;
using System; 

namespace HomeWork_09Class_Exceptions
{
    public class Cinema
    {

        public string Name { get; set; }
        public int Halls { get; set; }

        public List<Movie> Movies { get; set; }



        public Cinema( string name, int halls)
        {

            Name = name;
            Halls = halls;
            Movies = new List<Movie>();

        }

      

        public void AddMovieList(List<Movie> movie)
        {
            Movies = movie;

        }



        public string MoviePlaying(string movie)
        {
            string info = string.Empty;
           
            foreach (var item in Movies)
            {
             
                if(movie == item.Title )
                {
                    
                    info = $"Watching movie {item.Title} , rating is {item.Rating}, ticket price is {item.Ticketprice}";
                }
            }

            return info;
        }
         



        public string ShowAllMovies()
        {

            string info = string.Empty;

            for (int i = 0; i < Movies.Count; i++)
            {
                info += $" {i + 1}. {Movies[i].Title} \n" ;
            }

            return info;
        }


        public string MoviesByGenre()
        {

            string info = $"\n 1.{Genre.Action} \n 2.{Genre.Comedy}\n 3.{Genre.Drama}\n 4.{Genre.Horror}\n 5.{Genre.SciFi}";
 

            return info;
        }


         
        public string InputGenre(string genre)
          
            {

           

              if (genre.ToLower() == "action" || genre.ToLower() == "comedy" || genre.ToLower() == "drama" || genre.ToLower() == "horror" || genre.ToLower() == "scifi")
              {
                return genre;
              }
              else
              {
                throw new Exception(" We dont have that genre");
              }

           

        }



        public void ChooseGenre(string genreInput, List<string> genre)
        {

            if (genreInput.ToLower() == "action"  )
            {


                genre = Movies.Where(product => product.Genre == Genre.Action).Select(product => product.Title).ToList();
                genre.ForEach(Console.WriteLine);
            }

            if (genreInput.ToLower() == "comedy")
            {


                genre = Movies.Where(product => product.Genre == Genre.Comedy).Select(product => product.Title).ToList();
                genre.ForEach(Console.WriteLine);
            }

            if (genreInput.ToLower() == "drama")
            {


                genre = Movies.Where(product => product.Genre == Genre.Drama).Select(product => product.Title).ToList();
                genre.ForEach(Console.WriteLine);
            }


            if (genreInput.ToLower() == "horror")
            {


                genre = Movies.Where(product => product.Genre == Genre.Horror).Select(product => product.Title).ToList();
                genre.ForEach(Console.WriteLine);
            }


            if (genreInput.ToLower() == "scifi")
            {


                genre = Movies.Where(product => product.Genre == Genre.SciFi).Select(product => product.Title).ToList();
                genre.ForEach(Console.WriteLine);
            }
            
         


        }


 


    }
}
