using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            RateCalculator calculator = new RateCalculator();
            int rating = calculator.Calculate(this);

            //int rating = CalculateRating(true);
            //if (rating == 0)
            //{
            //    Console.WriteLine("Promoted to Level 1");
            //}
            //else
            //    Console.WriteLine("Promoted to Level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}