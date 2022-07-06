using System;
using System.Collections.Generic;
using NUnit.Framework;
using EnemyAIMovement;
using Enemy;
using WeaponObject;
using RoomArea;
using MovementStrategy;
using Strategy;
using EntityObject;
using Utilities;

namespace Test
{

    /// <summary>
    /// Test for the correct functioning of the room
    /// </summary>
    [TestFixture]
    public class RoomTest
    {
        private readonly RoomFactory _rf = new(null);

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
