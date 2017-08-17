using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using E2_Clase;

namespace E2_ClasesPruebaUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Estudent s1 = new Estudent();
            s1.Age = (19);
            Estudent s2 = new Estudent();

            Teacher t1 = new Teacher();
            Teacher t2 = new Teacher();

            School Engineering = new School();

            Engineering.Students.Add(s1);
            Engineering.Students.Add(s2);

            Assert.AreEqual(2, Engineering.Students.Count);

            Engineering.Teachers.Add(t1);
            Engineering.Teachers.Add(t2);

            Assert.AreEqual(2, Engineering.Teachers.Count);

            Engineering.Students.Add(s1);

            Assert.AreEqual(19, Engineering.Students[0].Age);
        }
    }
}
