using System;
using Cojac.Core.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Cojac.IntegrationTest
{
    [TestClass]
    public class ContextTest
    {
        [TestMethod]
        public void TestCreateAndInitializeDatabase()
        {
            CojacContext context = new CojacContext(@"Data Source=dpchl00765\SQLEXPRESS2;Initial Catalog=JeauxDB;User ID=milk;Password=honey;");

            var chris = context.Users.Find(483);

            Assert.IsNotNull(chris);
        }
    }
}
