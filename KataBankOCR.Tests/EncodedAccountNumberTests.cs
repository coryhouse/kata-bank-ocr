using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using KataBankOCR.Logic;

namespace KataBankOCR.Tests
{
    [TestClass]
    public class EncodedAccountNumberTests
    {
        [TestMethod]
        public void Decode_GivenValidEncodedAccountNumber_ReturnsAccountNumber()
        {
            var encodedAccountNumber = new List<string>()
            {
                "    _  _     _  _  _  _  _ ",
                "  | _| _||_||_ |_   ||_||_|",
                "  ||_  _|  | _||_|  ||_| _|",
                ""
            };

            Assert.AreEqual("123456789", EncodedAccountNumber.Decode(encodedAccountNumber));
        }
    }
}
