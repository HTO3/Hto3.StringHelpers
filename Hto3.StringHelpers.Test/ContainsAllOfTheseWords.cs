using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hto3.StringHelpers;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ContainsAllOfTheseWords
    {
        [TestMethod]
        public void Should_Contains()
        {
            //arrange
            var text = @"Historically, the world of data and the world of objects " +
            @"have not been well integrated. Programmers work in C# or Visual Basic " +
            @"and also in SQL or XQuery. On the one side are concepts such as classes, " +
            @"objects, fields, inheritance, and .NET APIs. On the other side " +
            @"are tables, columns, rows, nodes, and separate languages for dealing with " +
            @"them. Data types often require translation between the two worlds; there are " +
            @"different standard functions. Because the object world has no notion of query, a " +
            @"query can only be represented as a string without compile-time type checking or " +
            @"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
            @"objects in memory is often tedious and error-prone.";
            var words = new[] { "memory", "rows" };
            var expected = true;

            //act
            var actual = StringHelpers.ContainsAllOfTheseWords(text, words);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Not_Contains()
        {
            //arrange
            var text = @"Historically, the world of data and the world of objects " +
            @"have not been well integrated. Programmers work in C# or Visual Basic " +
            @"and also in SQL or XQuery. On the one side are concepts such as classes, " +
            @"objects, fields, inheritance, and .NET APIs. On the other side " +
            @"are tables, columns, rows, nodes, and separate languages for dealing with " +
            @"them. Data types often require translation between the two worlds; there are " +
            @"different standard functions. Because the object world has no notion of query, a " +
            @"query can only be represented as a string without compile-time type checking or " +
            @"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
            @"objects in memory is often tedious and error-prone.";
            var words = new[] { "memory", "cow" };
            var expected = false;

            //act
            var actual = StringHelpers.ContainsAllOfTheseWords(text, words);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
