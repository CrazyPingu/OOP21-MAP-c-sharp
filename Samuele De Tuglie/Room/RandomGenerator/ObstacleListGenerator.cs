using System;
using System.Collections.Generic;
using ObstacleObject;
using System.Reflection;
using EntityObject;
using Utilities;

namespace RandomGenerator
{
    /// <summary>
    /// Class that is a random generated list of obstacle
    /// </summary>
    public class ObstacleListGenerator : List<Obstacle>
    {
        private ObstacleFactory _of = new ObstacleFactory();
        private readonly Random _rand = new();
        private readonly MethodInfo[] _method = typeof(ObstacleFactory).GetMethods();
        private readonly int _maxObstacle = typeof(ObstacleFactory).GetMethods().Length;

        /// <summary>
        /// Initialize the list of the obstacle
        /// </summary>
        /// <param name="size">The size of the room</param>
        /// <param name="player">The player of the game</param>
        /// <param name="enemyList">The list of enemy already spawned in</param>
        public ObstacleListGenerator(Tuple<int, int> size, Player player, List<SimpleEnemy> enemyList)
        {
            Tuple<int, int> pos;
            for (int i = 0; i < _maxObstacle; i++)
            {
                do
                {
                    pos = new(_rand.Next(0, size.Item1 - 2), _rand.Next(0, size.Item2));
                } while (RoomConstant.CellsOccupated(this, player, enemyList, pos));
                Add((Obstacle)_method[_maxObstacle].Invoke(_of, new object[] { pos }));
            }
        }
    }
}
