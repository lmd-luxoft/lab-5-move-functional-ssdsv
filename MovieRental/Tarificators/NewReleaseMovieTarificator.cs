namespace MovieRental.Tarificators
{
    internal class NewReleaseMovieTarificator : IMovieTarificator
    {
        public double Calculate(int days)
        {
            return days * 3;
        }
    }
}