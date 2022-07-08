using EntityObject;
using MovementStrategy;
using NUnit.Framework;
using ObstacleObject;
using RoomArea;
using Strategy;
using System;
using Utilities;
using WeaponObject;

namespace Test
{

    /// <summary>
    /// Test to check the correct spawn of the game object in the room
    /// </summary>
    [TestFixture]
    public class TestGameObjectSpawn
    {
        private readonly RoomFactory _rf = new(new Player(new Tuple<int, int>(2, 3), new Movement(new AroundArea(1)),
                                new WeaponFactory().CreateStick(), "Marcello-test", 2));

        /// <summary>
        /// Control the correct functioning of the EnemyListGenerator class
        /// </summary>
        [Test]
        public void SpawnEnemy()
        {
            Room room = _rf.CreateBigRoom();
            Assert.AreEqual(room.EnemyList.Count, room.Size.Item1 * room.Size.Item2 / RoomConstant.SPAWNING_RATIO);
        }

        /// <summary>
        /// Control the correct functioning of the ObstacleListGenerator class
        /// </summary>
        [Test]
        public void SpawnObstacle()
        {
            Room room = _rf.CreateBigRoom();
            Assert.AreEqual(room.ObstacleList.Count, room.Size.Item1 * room.Size.Item2 / RoomConstant.SPAWNING_RATIO);
        }
        
        /// <summary>
        /// Control the spawn position of the enemy
        /// </summary>
        [Test]
        public void ForbiddenZombieSpawn()
        {
            Room room = _rf.CreateMediumRoom();
            bool flag = false;
            foreach (SimpleEnemy x in room.EnemyList)
            {
                if (x.Pos.Item1 < RoomConstant.FORBIDDEN_ZOMBIE_SPAWN)
                {
                    flag = true;
                }
            }
            Assert.False(flag);
        }

        /// <summary>
        /// Control the spawn position of the obstacle
        /// </summary>
        [Test]
        public void ForbiddenObstacleSpawn()
        {
            Room room = _rf.CreateMediumRoom();
            bool flag = false;
            foreach (Obstacle x in room.ObstacleList)
            {
                if (x.Pos.Item1 > room.Size.Item1 - 2)
                {
                    flag = true;
                }
            }
            Assert.False(flag);
        }
    }
}
