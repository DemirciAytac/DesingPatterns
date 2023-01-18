using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOne.InnerFactory.InTheOriginalClass
{
    public class Term2
    {
        //Properties
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        //Static factory methods
        public static Term2 CreateNewBetweenDefaultDates()
            => new Term2(new DateTime(2000, 1, 1), DateTime.UtcNow);

        public static Term2 CreateNewBetweenDates(DateTime startDate, DateTime endDate)
            => new Term2(startDate, endDate);

        //Private constructor
        private Term2(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
