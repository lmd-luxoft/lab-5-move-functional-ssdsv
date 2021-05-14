namespace MovieRental.Tarificators
{
    internal class ChildrenMovieTarificator : IMovieTarificator
    {
        public double Calculate(int days)
        {
            double thisAmount = 15;

            if (days > 3)
                thisAmount += (days - 3) * 15;

            return thisAmount;
        }
    }
}