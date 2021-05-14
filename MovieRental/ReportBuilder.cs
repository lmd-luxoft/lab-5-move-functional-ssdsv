using System.Text;

namespace MovieRental
{
    internal class ReportBuilder
    {
        private readonly StringBuilder report;

        public ReportBuilder(string userName)
        {
            report = new StringBuilder();
            report.Append($"учет аренды для {userName}\n");
        }

        public void AddRental(Rental rental, double amount)
        {
            report.Append($"\t{rental.getMovie()}\t{amount}\n");
        }

        public void AddSummary(double totalAmount, int frequentRenterPoints)
        {
            report.Append($"Сумма задолженности составляет {totalAmount}\nВы заработали {frequentRenterPoints} очков за активность");
        }

        public string GetReport() => report.ToString();
    }
}
