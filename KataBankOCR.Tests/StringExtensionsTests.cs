using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataBankOCR.Logic;

namespace KataBankOCR.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void SplitByLength_GivenString_ReturnsArraySplitBySpecifiedLength()
        {
            var lengthToSplitBy = 3;
            var input = "AAABBBCCC";
            var result = input.SplitByLength(lengthToSplitBy);
            Assert.AreEqual("AAA", result.ElementAt(0));
            Assert.AreEqual("BBB", result.ElementAt(1));
        }
    }
}
