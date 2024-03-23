using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDbTests
{
    internal class T_serv_ClassManagement
    {
        [SetUp]
        public void Setup()
        {
            Test_Commons.SetDataLayer();
        }

        [Test]
        public void CreateDatabeseTest()
        {
            Test_Commons.dl.CreateDatabase();
            Assert.That(Test_Commons.dl.DatabaseExsist("Schoolgrades"));
        }


        [Test]
        public void CreateTableTest()
        {

        }
    }
}
