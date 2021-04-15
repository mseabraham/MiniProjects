using MidProjClasses;
using MidProjData;
using NUnit.Framework;
using System.Linq;

namespace MidProjTests
{
    public class Tests
    {
        private UserCRUD _operations;

        //UNHAPPY paths test
        [SetUp]
        public void Setup()
        {
            _operations = new UserCRUD();
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
                _operations.CreateUser("FRY", "Phillip", "Fry", "testPass", false);
                var numberOfUsersAfter = db.Users.Count();

                Assert.AreEqual(numberOfUsersBefore + 1, numberOfUsersAfter);
            }
        }

        [Test]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated()
        {
            using (var db = new Gam3Sp0tContext())
            {
                _operations.CreateUser("FRY", "Phillip", "Fry", "testPass", false);

                _operations.Update("FRY", "Bender", "Fry");

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