using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringPermutationsTests
{
    [TestClass]
    public class StringPermutationTest
    {
        [TestMethod]
        public void Testhat()
        {
            var ret = Program.FindPermutations("hat");
            Assert.AreEqual("aht,ath,hat,hta,tah,tha", ret);
        }
    }
}
