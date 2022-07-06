using EntityObject;
using Enemy;
using System;
using System.Collections.Generic;
using Utilities;
using System.Reflection;

namespace RandomGenerator
{
    /// <summary>
    /// Class that is a random generated list of enemy
    /// </summary>
    public class EnemyListGenerator : List<SimpleEnemy>
    {
        private readonly EnemyFactory _ef = new();
        private readonly Random _rand = new();
        private readonly MethodInfo[] _method = typeof(EnemyFactory).GetMethods();
        private readonly int _maxEnemy = typeof(EnemyFactory).GetMethods().Length;

        /// <summary>
        /// Initialize the list of the enemy
        /// </summary>
        /// <param name="size">The size of the room</param>
        /// <param name="player">The player of the game</param>
        public EnemyListGenerator(Tuple<int, int> size, Player player)
        {
            Tuple<int, int> pos;
            for (int i = 0; i < _maxEnemy; i++)
            {
                do
                {
                    pos = new(_rand.Next(
                        RoomConstant.FORBIDDEN_ZOMBIE_SPAWN, size.Item1)
                        , _rand.Next(0, size.Item2));
                } while (RoomConstant.CellsOccupated(null, player, this, pos));
                Add((SimpleEnemy)_method[_maxEnemy].Invoke(_ef, new object[] { pos }));
            }
        }
    }
}
