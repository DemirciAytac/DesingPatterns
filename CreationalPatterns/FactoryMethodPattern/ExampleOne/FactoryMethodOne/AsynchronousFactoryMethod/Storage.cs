using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodOne.AsynchronousFactoryMethod
{
    public class Storage
    {
        private Storage() { }

        //Asynchronous static factory method
        public static async Task<Storage> CreateNewAsync()
        {
            await Task.Delay(100); //Simulating an asynchronous operation
            return new Storage();
        }
    }
}
