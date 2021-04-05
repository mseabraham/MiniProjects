using NUnit.Framework;
using MidTrainingProj;

namespace MidProjectTest
{
    public class CRUDtests
    {
        CustomerManager _customerManager;
        [SetUp]
        public void Setup()
        {
            _customerManager = new CustomerManager();
            // remove test entry in DB if present
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MAND"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustemersIncreasesBy1()
        {
            using (var db = new NorthwindContext())
            {
                var numberOfCustomersBefore = db.Customers.Count();
                _customerManager.Create("MAND", "Nish Mandal", "Sparta Global");
                var numberOfCustomersAfter = db.Customers.Count();

                Assert.AreEqual(numberOfCustomersBefore + 1, numberOfCustomersAfter);
            }
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {
            using (var db = new NorthwindContext())
            {
                _customerManager.Create("MAND", "Nish Mandal", "Sparta Global", "Paris");

                _customerManager.Update("MAND", "Nish Mandal", "Birmingham", null, null);

                var updatedCustomer = db.Customers.Find("MAND");
                Assert.AreEqual("Birmingham", updatedCustomer.City);
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MAND"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
    }
}