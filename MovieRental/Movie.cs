namespace MovieRental
{
    public class Movie
    {
        private string title;
        private MovieType _movieType;

        public Movie(string title, MovieType movieType)
        {
            this.title = title;
            this._movieType = movieType;
        }

        public string getTitle()
        {
            return title;
        }

        public MovieType getPriceCode()
        {
            return _movieType;
        }

        public override string ToString()
        {
            return title;
        }

        public bool isNewRelease()
        {
            return _movieType == MovieType.NEW_RELEASE;
        }
    }
}