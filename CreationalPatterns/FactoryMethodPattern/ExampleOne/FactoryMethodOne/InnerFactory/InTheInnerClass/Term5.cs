using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOne.InnerFactory.InTheInnerClass
{
    public class Term5
    {
        //Properties
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        //Private constructor
        private Term5(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        //Inner factory
        public static class Factory
        {
            //Static factory methods
            public static Term5 CreateNewBetweenDefaultDates()
                => new Term5(new DateTime(2000, 1, 1), DateTime.UtcNow);

            public static Term5 CreateNewBetweenDates(DateTime startDate, DateTime endDate)
                => new Term5(startDate, endDate);
        }
    }
}
