using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class QuoteText
    {
        [TestMethod]
        public void QuoteString()
        {
            //Arrange
            var text = "ttt";
            var expected = "\"ttt\"";

            //Act
            var result = StringHelpers.QuoteText(text);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EmptyString()
        {
            //Arrange
            var text = String.Empty;
            var expected = "\"\"";

            //Act
            var result = StringHelpers.QuoteText(text);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NullString()
        {
            //Arrange
            var text = default(String);
            var expected = "\"\"";

            //Act
            var result = StringHelpers.QuoteText(text);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
