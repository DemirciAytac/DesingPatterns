using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOne.InnerFactory.InASeparateClass
{
    //A separate factory
    public class TermFactory
    {
        //Static factory methods
        public static Term4 CreateNewBetweenDefaultDates()
            => new Term4(new DateTime(2000, 1, 1), DateTime.UtcNow);

        public static Term4 CreateNewBetweenDates(DateTime startDate, DateTime endDate)
            => new Term4(startDate, endDate);
    }

    public class Term4
    {
        //Properties
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        //Public constructor
        public Term4(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
