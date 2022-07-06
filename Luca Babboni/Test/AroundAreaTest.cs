using NUnit.Framework;
using Strategy;
using System;
using System.Collections.Generic;

namespace Test
{
    /// <summary>
    /// Nunit test for around area strategy
    /// </summary>
    [TestFixture]
    public class AroundAreaTest
    {
        private Tuple<int, int> _size, _pos;
        private readonly IStrategy _aroundAreaStrategy = new AroundArea(1);
        private readonly List<Tuple<int, int>> _expectedResults = new List<Tuple<int, int>>();

        /// <summary>
        /// Initialize grid size and clear the expected result
        /// </summary>
        [SetUp]
        public void Init()
        {
            _size = new Tuple<int, int>(3, 3);
            _expectedResults.Clear();
        }

        /// <summary>
        /// Test of inner area cell choice. 
        /// </summary>
        [Test] 
        public void InnerGridTest()
        {
            _pos = new Tuple<int, int>(1, 1);

            _expectedResults.Add(new Tuple<int, int>(0, 0));
            _expectedResults.Add(new Tuple<int, int>(0, 1));
            _expectedResults.Add(new Tuple<int, int>(0, 2));
            _expectedResults.Add(new Tuple<int, int>(1, 0));
            _expectedResults.Add(new Tuple<int, int>(1, 2));
            _expectedResults.Add(new Tuple<int, int>(2, 0));
            _expectedResults.Add(new Tuple<int, int>(2, 1));
            _expectedResults.Add(new Tuple<int, int>(2, 2));

            Assert.AreEqual(_expectedResults, _aroundAreaStrategy.Execute(_pos, _size));
        }

        /// <summary>
        /// Test of grid's upper left corner cell choice. 
        /// </summary>
        [Test]
        public void UpperLeftCornerTest()
        {
            _pos = new Tuple<int, int>(0, 0);
            _expectedResults.Add(new Tuple<int, int>(0, 1));
            _expectedResults.Add(new Tuple<int, int>(1, 0));
            _expectedResults.Add(new Tuple<int, int>(1, 1));

            Assert.AreEqual(_expectedResults, _aroundAreaStrategy.Execute(_pos, _size));
        }

        /// <summary>
        /// Test of grid's bottom left corner cell choice. 
        /// </summary>
        [Test]
        public void BottomLeftCornerTest()
        {
            _pos = new Tuple<int, int>(0, 2);
            _expectedResults.Add(new Tuple<int, int>(0, 1));
            _expectedResults.Add(new Tuple<int, int>(1, 1));
            _expectedResults.Add(new Tuple<int, int>(1, 2));

            Assert.AreEqual(_expectedResults, _aroundAreaStrategy.Execute(this._pos, this._size));
        }

        /// <summary>
        /// Test of grid's upper right corner cell choice.
        /// </summary>
        [Test]
        public void UpperRightCornerTest()
        {
            _pos = new Tuple<int, int>(2, 0);
            _expectedResults.Add(new Tuple<int, int>(1, 0));
            _expectedResults.Add(new Tuple<int, int>(1, 1));
            _expectedResults.Add(new Tuple<int, int>(2, 1));

            Assert.AreEqual(_expectedResults, _aroundAreaStrategy.Execute(this._pos, this._size));
        }

        /// <summary>
        /// Test of grid's bottom right corner cell choice
        /// </summary>
        [Test]
        public void BottomRightCornerTest()
        {
            _pos = new Tuple<int, int>(2, 2);
            _expectedResults.Add(new Tuple<int, int>(1, 1));
            _expectedResults.Add(new Tuple<int, int>(1, 2));
            _expectedResults.Add(new Tuple<int, int>(2, 1));

            Assert.AreEqual(_expectedResults, _aroundAreaStrategy.Execute(this._pos, this._size));
        }
    }
}
