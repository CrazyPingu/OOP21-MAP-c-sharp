using NUnit.Framework;
using Strategy;
using System;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    /// Nunit test for cross area strategy
    /// </summary>
    [TestFixture]
    public class CrossAreaTest
    { 
        private readonly IStrategy _crossStrategy = new CrossArea(1);
        private readonly List<Tuple<int, int>> _expectedResults = new();

        /// <summary>
        /// Initialize grid size and clear the expected result
        /// </summary>
        [SetUp]
        public void Init()
        { 
            _expectedResults.Clear();
        }

        /// <summary>
        /// Test of inner area cell choice. 
        /// </summary>
        [Test]
        public void InnerGridTest()
        {
            Tuple<int, int> pos = new(1, 1);
            Tuple<int, int> size = new(3, 3);

            _expectedResults.Add(new Tuple<int, int>(0, 1));
            _expectedResults.Add(new Tuple<int, int>(2, 1));
            _expectedResults.Add(new Tuple<int, int>(1, 0));
            _expectedResults.Add(new Tuple<int, int>(1, 2));

            Assert.AreEqual(_expectedResults, _crossStrategy.Execute(pos, size));
        }

        /// <summary>
        /// Test of grid's upper left corner cell choice. 
        /// </summary>
        [Test]
        public void UpperLeftCornerTest()
        {
            Tuple<int, int> pos = new(0, 0);
            Tuple<int, int> size = new(3, 3);

            _expectedResults.Add(new Tuple<int, int>(1, 0));
            _expectedResults.Add(new Tuple<int, int>(0, 1));

            Assert.AreEqual(_expectedResults, _crossStrategy.Execute(pos, size));
        }

        /// <summary>
        /// Test of grid's bottom left corner cell choice. 
        /// </summary>
        [Test]
        public void BottomLeftCornerTest()
        {
            Tuple<int, int> pos = new(0, 2);
            Tuple<int, int> size = new(3, 3);

            _expectedResults.Add(new Tuple<int, int>(1, 2));
            _expectedResults.Add(new Tuple<int, int>(0, 1));

            Assert.AreEqual(_expectedResults, _crossStrategy.Execute(pos, size));
        }

        /// <summary>
        /// Test of grid's upper right corner cell choice.
        /// </summary>
        [Test]
        public void UpperRightCornerTest()
        {
            Tuple<int, int> pos = new(2, 0);
            Tuple<int, int> size = new(3, 3);

            _expectedResults.Add(new Tuple<int, int>(1, 0));
            _expectedResults.Add(new Tuple<int, int>(2, 1));

            Assert.AreEqual(_expectedResults, _crossStrategy.Execute(pos, size));
        }

        /// <summary>
        /// Test of grid's bottom right corner cell choice
        /// </summary>
        [Test]
        public void BottomRightCornerTest()
        {
            Tuple<int, int> pos = new(2, 2);
            Tuple<int, int> size = new(3, 3);

            _expectedResults.Add(new Tuple<int, int>(1, 2));
            _expectedResults.Add(new Tuple<int, int>(2, 1));

            Assert.AreEqual(_expectedResults, _crossStrategy.Execute(pos, size));
        }
    }
}

