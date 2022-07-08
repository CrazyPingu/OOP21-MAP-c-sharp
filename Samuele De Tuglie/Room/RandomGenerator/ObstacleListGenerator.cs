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
            for (int i = 0; i < size.Item1 * size.Item2 / RoomConstant.SPAWNING_RATIO; i++)
            {
                do
                {
                    pos = new(_rand.Next(0, size.Item1 - 2), _rand.Next(0, size.Item2));
                } while (RoomConstant.CellsOccupated(this, player, enemyList, pos));
                //Add((Obstacle)_method[_rand.Next(0, _maxObstacle)].Invoke(_of, new object[] { pos }));
                Add(RandomObstacle(pos));
            }
        }

        /// <summary>
        /// Method to generate a random obstacle
        /// </summary>
        /// <param name="pos">The position of the obstacle</param>
        /// <returns>A random obstacle object</returns>
        private Obstacle RandomObstacle(Tuple<int, int> pos)
        {
            int num = _rand.Next(0, _maxObstacle);
            if (num == 0)
            {
                return _of.CreateRock(pos);
            }
            else
            {
                return _of.CreatePebble(pos);
            }
        }
    }
}
