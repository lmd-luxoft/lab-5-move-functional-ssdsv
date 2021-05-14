using System.Collections.Generic;
using MovieRental.Tarificators;

namespace MovieRental
{
    internal class MoviePricer
    {
        private IDictionary<MovieType, IMovieTarificator> _movieTarificators =
            new Dictionary<MovieType, IMovieTarificator>();

        public MoviePricer()
        {
            _movieTarificators.Add(MovieType.REGULAR, new RegularMovieTarificator());
            _movieTarificators.Add(MovieType.NEW_RELEASE, new NewReleaseMovieTarificator());
            _movieTarificators.Add(MovieType.CHILDREN, new ChildrenMovieTarificator());
        }

        public double GetMoviePrice(Movie movie, int days)
        {
            var movieTarificator = _movieTarificators[movie.getPriceCode()];

            double thisAmount = movieTarificator.Calculate(days);

            return thisAmount;
        }
    }
}
