using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EF;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 6,
                CustomerId = 4,
                RentDate = DateTime.Now
            
            });
            Console.WriteLine(result.Message);
            
                


        }

        private static void Test1()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(
                new Customer { UserId = 1, CompanyName = "blindsnisa" }
                );
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }
    }
}