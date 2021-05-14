namespace MovieRental.Tarificators
{
    internal class RegularMovieTarificator : IMovieTarificator
    {
        public double Calculate(int days)
        {
            double thisAmount = 2;

            if (days > 2)
                thisAmount += (days - 2) * 15;

            return thisAmount;
        }
    }
}