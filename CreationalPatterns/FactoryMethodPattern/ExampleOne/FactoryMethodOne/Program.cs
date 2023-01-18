using FactoryMethodOne.AsynchronousFactoryMethod;
using FactoryMethodOne.InnerFactory.InASeparateClass;
using FactoryMethodOne.InnerFactory.InTheInnerClass;
using FactoryMethodOne.InnerFactory.InTheOriginalClass;
using FactoryMethodOne.ParameterizedFactoryMethod;
using FactoryMethodOne.StaticFactoryMethod;
using System;

namespace FactoryMethodOne
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static Factory Methos
            Term term1 = Term.CreateNewBetweenDefaultDates();
            Term term2 = Term.CreateNewBetweenDates(DateTime.Now, DateTime.Now);
            #endregion

            #region Asynchronous Factory Method
            // var storage = await Storage.CreateNewAsync();
            #endregion

            #region Parameterized Factory Method
            var parser = ParserFactory.Create("deneme.xml");
            #endregion

            #region Inner Factory

            #region In The Original Class
            Term2 termnew = Term2.CreateNewBetweenDefaultDates();
            #endregion

            #region In a separate class
            // Dezavantajı 2 farklı şekilde term4 oluşturabildim
            var term4 = TermFactory.CreateNewBetweenDefaultDates();
            var newTerm4 = new Term4(DateTime.Now, DateTime.Now);
            #endregion

            #region In the inner class
            var term5 = Term5.Factory.CreateNewBetweenDefaultDates();
            #endregion

            #endregion
        }
    }
}
