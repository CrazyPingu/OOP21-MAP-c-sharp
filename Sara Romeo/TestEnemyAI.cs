using System;
using System.Collections.Generic;
using NUnit.Framework;
using EnemyAIMovement;
using Enemy;
using WeaponObject;
using RoomArea;

namespace Test
{
    /// <summary>
    ///  NUnit test for enemy AI methods.
    /// </summary>
    [TestFixture]
    public class TestEnemyAI
    {
        private readonly WeaponFactory _wf = new WeaponFactory();
        private readonly EnemyFactory _ef = new EnemyFactory();
        private readonly IHealthArtefactFactory _hf = new HealthArtefactFactory();
        private readonly IMovementFactory _mf = new MovementFactory();
        private readonly IObstacleFactory _of = new ObstacleFactory();
        private Tuple<int, int> _roomSize;
        private List<Tuple<int, int>> _expectedResult = new List<Tuple<int, int>>();
        private IEnemyAI _enemyAI;
        private Player _player;
        private SimpleEnemy _enemyAroundArea, _enemyCrossArea;
        private Room _room;

        [SetUp]
        /// Initialize all elements needed.
        public void Init()
        {
            _roomSize = new Tuple<int, int>(10, 4);
            _player = new Player(new ExtendibleMaxLifeSystem(4, 10, 20), _wf.CreateAxe(), _mf.createStepMovement(), "Marcello-test", EntityTexture.PLAYER);
            _room = new Room(_roomSize, _player, new Tuple<int, int>(2, 1));
            _enemyAI = new EnemyAI(_room);
            _room.EnemyList.Clear();
            _room.ArtefactList.Clear();
            _room.ObstacleList.Clear();
            _enemyAroundArea = _ef.CreateZombieStick(new Tuple<int, int>(5, 1));
            _room.EnemyList.Add(_enemyAroundArea);
            _enemyCrossArea = _ef.CreateZombieGun(new Tuple<int, int>(3, 3));
            _room.EnemyList.Add(_enemyCrossArea);
        }

        [Test]
        /// testing of enemy's moving behavior whether there's an obstacle on chosen cell
        public void ObjectInArea()
        {
            // Console.WriteLine("\n-- objectInArea\n");
            // _player.setPos(new Tuple<int, int>(2, 3));
            // _room.ArtefactList.Add(_hf.createBigHealArtefact(new Tuple<int, int>(4, 2)));
            // _expectedResult.Add(new Tuple<int, int>(4, 1));
            // _expectedResult.Add(new Tuple<int, int>(5, 2));
            // ResultsToString(_enemyAI.Move(_enemyAroundArea), _expectedResult);
            _room.ArtefactList.Clear();
            _room.ObstacleList.Add(_of.createPebble(new Tuple<int, int>(4, 2)));
            ResultsToString(_enemyAI.Move(_enemyAroundArea), _expectedResult);
        }

        [Test]
        /// testing of enemy's moving area with different coordinates than player's position         
        public void PlayerOutside()
        {
            Console.WriteLine("\n-- playerOutside\n");
            _player.setPos(new Tuple<int, int>(2, 3));
            _expectedResult.Add(new Tuple<int, int>(4, 2));
            _expectedResult.Add(new Tuple<int, int>(4, 1));
            ResultsToString(_enemyAI.Move(_enemyAroundArea), _expectedResult);

            _expectedResult.Clear();
            _player.setPos(new Tuple<int, int>(2, 0));
            _expectedResult.Add(new Tuple<int, int>(3, 1));
            ResultsToString(_enemyAI.Move(_enemyCrossArea), _expectedResult);

            _expectedResult.Clear();
            _enemyCrossArea.setPos(new Tuple<int, int>(3, 3));
            _player.setPos(new Tuple<int, int>(6, 0));
            _expectedResult.Add(new Tuple<int, int>(3, 1));
            _expectedResult.Add(new Tuple<int, int>(3, 2));
            _expectedResult.Add(new Tuple<int, int>(4, 3));
            _expectedResult.Add(new Tuple<int, int>(5, 3));
            ResultsToString(_enemyAI.Move(_enemyCrossArea), _expectedResult);
        }

        [Test]
        /// testing of enemy's moving area with enemy and player with the same X coordinate
        public void PlayerAlignedX()
        {
            Console.WriteLine("\n-- playerAlignedX\n");
            _player.setPos(new Tuple<int, int>(2, 1));
            _expectedResult.Add(new Tuple<int, int>(4, 0));
            _expectedResult.Add(new Tuple<int, int>(4, 1));
            _expectedResult.Add(new Tuple<int, int>(4, 2));
            ResultsToString(_enemyAI.Move(_enemyAroundArea), _expectedResult);

            _expectedResult.Clear();
            _player.setPos(new Tuple<int, int>(7, 3));
            _expectedResult.Add(new Tuple<int, int>(5, 3));
            ResultsToString(_enemyAI.Move(_enemyCrossArea), _expectedResult);
        }

        [Test]
        /// testing of enemy's moving area with enemy and player with the same X coordinate
        public void PlayerAlignedY()
        {
            Console.WriteLine("\n-- playerAlignedY\n");
            _player.setPos(new Tuple<int, int>(5, 3));
            _expectedResult.Add(new Tuple<int, int>(4, 2));
            _expectedResult.Add(new Tuple<int, int>(5, 2));
            _expectedResult.Add(new Tuple<int, int>(6, 2));
            ResultsToString(_enemyAI.Move(_enemyAroundArea), _expectedResult);

            _expectedResult.Clear();
            _player.setPos(new Tuple<int, int>(3, 0));
            _expectedResult.Add(new Tuple<int, int>(3, 1));
            ResultsToString(_enemyAI.Move(_enemyCrossArea), _expectedResult);
        }

        [Test]
        /// testing of enemy's moving area with enemy and player on the right of enemy's area (not exactly aligned with enemy pos)
        public void PlayerRightArea()
        {
            Console.WriteLine("\n-- playerRightArea\n");
            _player.setPos(new Tuple<int, int>(8, 2));
            _expectedResult.Add(new Tuple<int, int>(6, 0));
            _expectedResult.Add(new Tuple<int, int>(6, 1));
            _expectedResult.Add(new Tuple<int, int>(6, 2));
            ResultsToString(_enemyAI.Move(_enemyAroundArea), _expectedResult);

            _expectedResult.Clear();
            _player.setPos(new Tuple<int, int>(5, 2));
            _expectedResult.Add(new Tuple<int, int>(4, 3));
            _expectedResult.Add(new Tuple<int, int>(5, 3));
            ResultsToString(_enemyAI.Move(_enemyCrossArea), _expectedResult);
        }

        /// <summary>
        /// Results are printed on console and tested with JUnit.
        /// </summary>
        private void ResultsToString(Tuple<int, int> newPos, List<Tuple<int, int>> expected)
        {
            Console.WriteLine(" Result:\r" + newPos + "\n Expected:\r" + expected);
            Assert.True(_expectedResult.Contains(newPos));
        }
    }
}
