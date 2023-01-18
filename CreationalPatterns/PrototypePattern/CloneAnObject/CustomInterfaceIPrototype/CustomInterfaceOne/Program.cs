using System;

namespace CustomInterfaceOne
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Address adr1 = new Address();
            adr1.Street = "Atatürk cad.";
            adr1.City = "Ankara";

            Person per1 = new Person();
            per1.Name = "Aytaç";
            per1.Age = 30;
            per1.Address = adr1;

            var newPerson = per1.CreateDeepCopy();

            Console.WriteLine(per1.Equals(newPerson));
        }
    }
}
