namespace MovieRental
{
    internal class BonusProgram
    {
        public BonusProgram()
        {
        }

        public int GetPoints(Rental rental)
        {
            if (rental.isTwoDaysOrOverNewReleaseMovie()) return 2;

            return 1;
        }
    }
}
