using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerString.Data;

namespace PowerString.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UpdateTest()
        {
            Tester tester = new Tester();
            tester.TesterId = 4;
            tester.TesterName = "그리고";
            tester.TesterPassword = "aaa";

            DataRepository.Tester.Update(tester);

            Tester t2 = DataRepository.Tester.SelectById(4);

            Assert.AreEqual(tester.TesterName, t2.TesterName);
        }

        [TestMethod]
        public void DeleteTest()
        {
            int count = DataRepository.Tester.Count();

            Tester tester = DataRepository.Tester.SelectById(4);
            DataRepository.Tester.Delete(tester);

            Assert.AreEqual(count - 1, DataRepository.Tester.Count());
        }

        [TestMethod]
        public void InsertTest()
        {
            int count = DataRepository.Tester.Count();

            Tester tester = new Tester();
            tester.TesterId = 4; // Auto Increment라서 번호 입력해도 지정되지 않음.
            tester.TesterName = "And";
            tester.TesterPassword = "and";
            DataRepository.Tester.Insert(tester);

            Assert.AreEqual(count + 1, DataRepository.Tester.Count());
        }
        // prop Nullable<int> TesterScore

    }
}
