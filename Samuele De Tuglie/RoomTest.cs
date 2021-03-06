using EntityObject;
using MovementStrategy;
using NUnit.Framework;
using RoomArea;
using Strategy;
using System;
using Utilities;
using WeaponObject;

namespace Test
{
    /// <summary>
    /// Test for the correct functioning of the room
    /// </summary>
    [TestFixture]
    public class RoomTest
    {
        private readonly RoomFactory _rf = new(new Player(new Tuple<int, int>(2, 3), new Movement(new AroundArea(1)),
                                    new WeaponFactory().CreateStick(), "Marcello-test", 2));

        /// <summary>
        /// Test to control the correct dimension of the big room
        /// </summary>
        [Test]
        public void BigRoomSize()
        {
            Room room = _rf.CreateBigRoom();
            Assert.AreEqual(room.Size, RoomConstant.MAX_DIM);
        }

        /// <summary>
        /// Test to control the correct dimension of the small room
        /// </summary>
        [Test]
        public void SmallRoomSize()
        {
            Room room = _rf.CreateSmallRoom();
            Assert.AreEqual(room.Size, RoomConstant.MIN_DIM);
        }

        /// <summary>
        /// Test to control the correct dimension of the medium room
        /// </summary>
        [Test]
        public void MediumRoomSize()
        {
            Room room = _rf.CreateMediumRoom();
            Assert.AreEqual(room.Size, RoomConstant.MED_DIM);
        }
    }
}
