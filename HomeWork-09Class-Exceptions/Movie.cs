
using System;
using System.Dynamic;

namespace HomeWork_09Class_Exceptions
{
    public class Movie
    {

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }

        private int ticketprice;

     

      public Movie( string title, Genre genre, int rating )
        {
            Title = title ;
            Genre = genre;
            Rating = rating;
            Ticketprice = ticketprice;
        }




        public int Ticketprice
        {
            get
            {
                return ticketprice;
            }

            set
            {
                ticketprice = 5 * Rating;
            }
        }




    }
}
