using EntityObject;
using NUnit.Framework;
using GameArea;
using System;
using MovementStrategy;
using Strategy;
using WeaponObject;

namespace Test
{
    [TestFixture]
    public class TestGameAreaController
    {
        private GameAreaController _controller;

        private SimpleEnemy _enemy;

        private int _size;

        [SetUp]
        public void Init()
        {
            _controller = new GameAreaController(new Player(new Tuple<int, int>(2, 3), new Movement(new AroundArea(1)),
                                new WeaponFactory().CreateStick(), "Marcello-test", 2));


            _size = _controller.Room.EnemyList.Count;

            _enemy = _controller.Room.EnemyList[new Random().Next(_size)];
        }
        [Test]
        public void CheckRemovedObject()
        {
            bool flag = false;

            _controller.RemoveGameObject(_enemy.Pos);
            if (_controller.Room.EnemyList.Count == _size - 1)
            {
                flag = true;
            }

            Assert.True(flag);
            
        }
    }
}
