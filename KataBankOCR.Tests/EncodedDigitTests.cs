using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataBankOCR.Logic;

namespace KataBankOCR.Tests
{
    [TestClass]
    public class EncodedDigitTests
    {
        [TestMethod]
        public void Decode_PassOne_ReturnsOne()
        {
            var result = EncodedDigit.Decode("   ", 
                                             "  |",
                                             "  |");
            Assert.AreEqual(result, "1");
        }

        // TODO: Add tests for other digits
    }
}
