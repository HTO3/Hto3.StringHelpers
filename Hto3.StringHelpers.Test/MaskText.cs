using Hto3.StringHelpers.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class MaskText
    {
        [TestMethod]
        public void MaskBegining()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0.5f;
            const MaskTextMode MODE = MaskTextMode.Begining;
            const String EXPECTED = "*** *** ** * ***d friend too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskBegining0()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0f;
            const MaskTextMode MODE = MaskTextMode.Begining;
            const String EXPECTED = "The cat is a good friend too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskBegining1()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 1f;
            const MaskTextMode MODE = MaskTextMode.Begining;
            const String EXPECTED = "*** *** ** * **** ****** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskEnding()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0.5f;
            const MaskTextMode MODE = MaskTextMode.Ending;
            const String EXPECTED = "The cat is a go** ****** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskEnding0()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0f;
            const MaskTextMode MODE = MaskTextMode.Ending;
            const String EXPECTED = "The cat is a good friend too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskEnding1()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 1f;
            const MaskTextMode MODE = MaskTextMode.Ending;
            const String EXPECTED = "*** *** ** * **** ****** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskCenter()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0.5f;
            const MaskTextMode MODE = MaskTextMode.Center;
            const String EXPECTED = "The cat ** * **** *****d too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskCenter0()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0f;
            const MaskTextMode MODE = MaskTextMode.Center;
            const String EXPECTED = "The cat is a good friend too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskCenter1()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 1f;
            const MaskTextMode MODE = MaskTextMode.Center;
            const String EXPECTED = "*** *** ** * **** ****** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskIntervaled()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0.5f;
            const MaskTextMode MODE = MaskTextMode.Intervaled;
            const String EXPECTED = "**e *a* i* a *o*d *r*e*d *o*.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskIntervaled0()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0f;
            const MaskTextMode MODE = MaskTextMode.Intervaled;
            const String EXPECTED = "The cat is a good friend too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskIntervaled1()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 1f;
            const MaskTextMode MODE = MaskTextMode.Intervaled;
            const String EXPECTED = "*** *** ** * **** ****** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskRandom()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0.5f;
            const MaskTextMode MODE = MaskTextMode.Random;
            const Int32 COUNT_MASK_CHARS = 12;

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(COUNT_MASK_CHARS, result.Count(c => c == '*'));
        }

        [TestMethod]
        public void MaskRandom0()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0f;
            const MaskTextMode MODE = MaskTextMode.Random;
            const String EXPECTED = "The cat is a good friend too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskRandom1()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 1f;
            const MaskTextMode MODE = MaskTextMode.Random;
            const String EXPECTED = "*** *** ** * **** ****** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskEnds()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0.5f;
            const MaskTextMode MODE = MaskTextMode.Ends;
            const String EXPECTED = "*** *** is a good frie** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskEnds0()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 0f;
            const MaskTextMode MODE = MaskTextMode.Ends;
            const String EXPECTED = "The cat is a good friend too.";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskEnds1()
        {
            //Arrange
            const String TEXT = "The cat is a good friend too.";
            const Single COVERAGE = 1f;
            const MaskTextMode MODE = MaskTextMode.Ends;
            const String EXPECTED = "*** *** ** * **** ****** ****";

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE);

            //Assert
            Assert.AreEqual(EXPECTED, result);
        }

        [TestMethod]
        public void MaskSkipChars()
        {
            //Arrange
            const String TEXT = "111.111.111-00";
            const Single COVERAGE = 0.7f;
            const MaskTextMode MODE = MaskTextMode.Intervaled;
            const Int32 COUNT_MASK_CHARS = 8;
            const Char REPLACEMENT_CHAR = '°';

            //Act
            var result = StringHelpers.MaskText(TEXT, COVERAGE, MODE, REPLACEMENT_CHAR, new[] { '.', '-' });

            //Assert
            Assert.AreEqual(COUNT_MASK_CHARS, result.Count(c => c == REPLACEMENT_CHAR));
        }
    }
}
