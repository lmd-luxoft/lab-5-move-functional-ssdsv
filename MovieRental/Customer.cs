using System.Collections.Generic;

namespace MovieRental
{
    public class Customer
    {
        List<Rental> rentals = new List<Rental>();
        private readonly string name;
        private readonly MoviePricer pricer = new MoviePricer();
        private readonly BonusProgram bonusProgram = new BonusProgram();

        public Customer(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }

        internal void addRental(Rental rental)
        {
            rentals.Add(rental);
        }

        internal string statement()
        {
            var report = new ReportBuilder(getName());

            double totalAmount = 0;
            int frequentRenterPoints = 0;

            foreach (var item in rentals)
            {
                double thisAmount = pricer.GetMoviePrice(item.getMovie(), item.getDaysRented());
                report.AddRental(item, thisAmount);

                totalAmount += thisAmount;
                frequentRenterPoints += bonusProgram.GetPoints(item);
            }

            report.AddSummary(totalAmount, frequentRenterPoints);

            return report.GetReport();
        }
    }
}