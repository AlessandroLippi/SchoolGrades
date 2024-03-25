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
            Assert.That(Test_Commons.dl.DatabaseExsist("Schoolgrades"));   //controlla se l'esecuzione è falsa o vera, in  caso il metodo vada in errore manda l'errore.
        }


        [Test]
        public void CreateTableTest()
        {

        }
    }
}
