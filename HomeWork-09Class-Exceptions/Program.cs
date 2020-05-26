using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_09Class_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {




            #region Movies and Cinema

            Movie movie1 = new Movie("Skin", Genre.Action, 3);
            Movie movie2 = new Movie("Fast Color", Genre.Comedy, 2);
            Movie movie3 = new Movie("Execption", Genre.Action, 4);
            Movie movie4 = new Movie("Little Women", Genre.Horror, 5);
            Movie movie5 = new Movie("One Cut of the Dead", Genre.Horror, 3);
            Movie movie6 = new Movie("American Factory", Genre.Drama, 1);
            Movie movie7 = new Movie("Plus One", Genre.Comedy, 5);
            Movie movie8 = new Movie("Crawl", Genre.Action, 3);
            Movie movie9 = new Movie("High Life", Genre.SciFi, 2);
            Movie movie10 = new Movie("Avatar", Genre.SciFi, 5);



            Cinema kinoVardar = new Cinema("Kino Vardar", 4);
            List<Movie> kinoVardarMovies = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            kinoVardar.AddMovieList(kinoVardarMovies);



            Movie movie11 = new Movie("Dust", Genre.Drama, 2);
            Movie movie12 = new Movie("John Wickr", Genre.Action, 4);
            Movie movie13 = new Movie("Shadow", Genre.Action, 3);
            Movie movie14 = new Movie("Birds of Passage", Genre.Horror, 1);
            Movie movie15 = new Movie("The Souvenir", Genre.Comedy, 4);
            Movie movie16 = new Movie("Life", Genre.Drama, 1);
            Movie movie17 = new Movie("Apollo 11", Genre.SciFi, 5);
            Movie movie18 = new Movie("Gloria Bell", Genre.Comedy, 4);
            Movie movie19 = new Movie("Hagazussa", Genre.Horror, 5);
            Movie movie20 = new Movie("Uncut Gems", Genre.Action, 3);


            Cinema milenium = new Cinema("Milenium", 6);
            List<Movie> mileniumMovies = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            milenium.AddMovieList(mileniumMovies);




            #endregion


            try
            {
                 
                if (movie1.Rating < 1 || movie1.Rating > 5)
                {
                    throw new Exception(" Rating can not be less then 1 and higher then 5 ");
                }



                      Console.WriteLine("Choose cinema  Kinovardar or  Milenium ");
                      string inputCinema = Console.ReadLine();


                      if (inputCinema.ToLower() != "kinovardar" && inputCinema.ToLower() != "milenium")
                      {
                           throw new Exception("Incorrect cinema ");
                      }


                     if (inputCinema.ToLower() == "kinovardar")
                     {
                        Console.WriteLine("If you want to see all movies type 'all' or by genre type 'genre' ");
                        string inputAllMoviesOrGenre = Console.ReadLine();

                        if (inputAllMoviesOrGenre.ToLower() != "all" && inputAllMoviesOrGenre.ToLower() != "genre")
                        {
                            throw new Exception("You need to type 'all' or 'genre'");
                        }


                       if (inputAllMoviesOrGenre.ToLower() == "all")
                       {
                         Console.WriteLine(kinoVardar.ShowAllMovies());

                         Console.WriteLine("Choose which movie you want to watch \n");
                         string playMovie = Console.ReadLine();

                              if (!kinoVardar.MoviePlaying(playMovie).Contains(playMovie))
                              {
                                     throw new Exception("We dont have that movie in the list, choose movie from the list");
                              }

                         if (kinoVardar.MoviePlaying(playMovie).Contains(playMovie))
                         {
                            Console.WriteLine(kinoVardar.MoviePlaying(playMovie));
                            
                         }
                       }
                       
                       if (inputAllMoviesOrGenre.ToLower() == "genre")
                       {
                            Console.WriteLine($"Choose you genre by typing the genre: {kinoVardar.MoviesByGenre()}  \n");
                            string movieByGenre = Console.ReadLine();
                       
                           if (kinoVardar.InputGenre(movieByGenre).Contains(movieByGenre))
                           {

                              List<string> moviesByGenre = new List<string>();
                              kinoVardar.ChooseGenre(movieByGenre, moviesByGenre);


                              Console.WriteLine($"Choose which movie you want to play \n");
                              string movieToPlay = Console.ReadLine();

                             if (!kinoVardar.MoviePlaying(movieToPlay).Contains(movieToPlay))
                             {
                                throw new Exception("We dont have that movie in the list, choose movie from the list");
                             }

                             if (kinoVardar.MoviePlaying(movieToPlay).Contains(movieToPlay))
                             {
                                Console.WriteLine(kinoVardar.MoviePlaying(movieToPlay));
                             }

                           }

             
                       }





                     }

                #region milenium

                if (inputCinema.ToLower() == "milenium")
                {
                    Console.WriteLine("If you want to see all movies type 'all' or by genre type 'genre' ");
                    string inputAllMoviesOrGenre = Console.ReadLine();

                    if (inputAllMoviesOrGenre.ToLower() != "all" && inputAllMoviesOrGenre.ToLower() != "genre")
                    {
                        throw new Exception(" You need to type 'all' or 'genre'");
                    }


                    if (inputAllMoviesOrGenre.ToLower() == "all")
                    {
                        Console.WriteLine(milenium.ShowAllMovies());

                        Console.WriteLine("Choose which movie you want to watch \n");
                        string playMovie = Console.ReadLine();

                        if (!milenium.MoviePlaying(playMovie).Contains(playMovie))
                        {
                            throw new Exception(" We dont have that movie in the list, choose movie from the list");
                        }

                        if (milenium.MoviePlaying(playMovie).Contains(playMovie))
                        {
                            Console.WriteLine(milenium.MoviePlaying(playMovie));

                        }
                    }

                    if (inputAllMoviesOrGenre.ToLower() == "genre")
                    {
                        Console.WriteLine($"Choose you genre by typing the genre: {milenium.MoviesByGenre()}  \n");
                        string movieByGenre = Console.ReadLine();

                        if (milenium.InputGenre(movieByGenre).Contains(movieByGenre))
                        {

                            List<string> moviesByGenre = new List<string>();
                            milenium.ChooseGenre(movieByGenre, moviesByGenre);


                            Console.WriteLine($" Choose which movie you want to play \n");
                            string movieToPlay = Console.ReadLine();

                            if (!milenium.MoviePlaying(movieToPlay).Contains(movieToPlay))
                            {
                                throw new Exception(" We dont have that movie in the list, choose movie from the list");
                            }

                            if (milenium.MoviePlaying(movieToPlay).Contains(movieToPlay))
                            {
                                Console.WriteLine(milenium.MoviePlaying(movieToPlay));
                            }

                        }


                    }





                }
                #endregion


            }



            catch (Exception ex)
            {

                Console.WriteLine((ex.Message))    ;
            }
      
             

        }
    }
}
