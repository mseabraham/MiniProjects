using NUnit.Framework;
using System.Linq;
using MidProjClasses;
using MidProjData;

namespace MidProjTests
{
    public class Tests
    {
        UserCRUD operations;

        [SetUp]
        public void Setup()
        {
            operations = new UserCRUD();
            // remove test entry in DB if present
            using (var db = new Gam3Sp0tContext())
            {
                var testUser =
                from u in db.Users
                where u.Username == "FRY"
                select u;

                db.Users.RemoveRange(testUser);
                db.SaveChanges();
            }
        }
        /*
        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustemersIncreasesBy1()
        {
            using (var db = new Gam3Sp0tContext())
            {
                var numberOfUsersBefore = db.Users.Count();
                operations.Create("FRY", "Phillip", "Fry", "testPass");
                var numberOfCustomersAfter = db.Customers.Count();

                Assert.AreEqual(numberOfCustomersBefore + 1, numberOfCustomersAfter);
            }
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {
            using (var db = new Gam3Sp0tContext())
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
            using (var db = new Gam3Sp0tContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MAND"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
        */
    }
}