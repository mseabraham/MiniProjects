using MidProjClasses;
using MidProjData;
using NUnit.Framework;
using System.Linq;

namespace MidProjTests
{
    public class Tests
    {
        UserCRUD operations;

        //UNHAPPY paths test
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
        
        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustemersIncreasesBy1()
        {
            using (var db = new Gam3Sp0tContext())
            {
                var numberOfUsersBefore = db.Users.Count();
                operations.CreateUser("FRY", "Phillip", "Fry", "testPass", false);
                var numberOfUsersAfter = db.Users.Count();

                Assert.AreEqual(numberOfUsersBefore + 1, numberOfUsersAfter);
            }
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {
            using (var db = new Gam3Sp0tContext())
            {
                operations.CreateUser("FRY", "Phillip", "Fry", "testPass", false);

                operations.Update("FRY", "Bender", "Fry");

                var updatedCustomer = db.Users.Where(u => u.Username == "Fry").FirstOrDefault();
                Assert.AreEqual("Bender", updatedCustomer.FirstName);
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new Gam3Sp0tContext())
            {
                var selectedUser =
                from c in db.Users
                where c.Username == "FRY"
                select c;

                db.Users.RemoveRange(selectedUser);
                db.SaveChanges();
            }
        }
        
    }
}