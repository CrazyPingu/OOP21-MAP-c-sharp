using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using EntityObject;
using ObstacleObject;

namespace Utilities
{
    public class RoomConstant
    {
        public static readonly Color ATTACK_HIGHLIGHT = Color.Red;
        public static readonly Color MOVE_HIGHLIGHT = Color.Blue;
        public static readonly Color ENEMY_RANGE = Color.FromArgb(153, 50, 204);

        public static readonly Color BASIC_CELL_COLOR = Color.Gray;
        public static readonly Color DOOR_CELL_COLOR = Color.FromArgb(110, 38, 14);

        public const int FORBIDDEN_ZOMBIE_SPAWN = 3;

        public static readonly Tuple<int, int> MAX_DIM = new(10, 10);

        public static readonly Tuple<int, int> MIN_DIM = new(5, 5);

        public const Image BUTTON_IMAGE = null;

        private RoomConstant() { }

        /// <summary>
        /// Method to search a enemy inside a list
        /// </summary>
        /// <param name="pos">The position of the enemy</param>
        /// <param name="enemyList">The List to search in</param>
        /// <returns>The enemy at that position otherwise null</returns>
        public static SimpleEnemy? SearchEnemy(Tuple<int, int> pos, List<SimpleEnemy> enemyList)
        {
            if (enemyList != null && enemyList.Any())
            {
                foreach (SimpleEnemy x in enemyList)
                {
                    if (x.Pos.Equals(pos))
                    {
                        return x;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Method to search a obstacle inside a list
        /// </summary>
        /// <param name="pos">The position of the wanted obstacle</param>
        /// <param name="obstacleList">The List to search in</param>
        /// <returns>The obstacle at that position otherwise null</returns>
        public static Obstacle ? SearchObstacle(Tuple<int, int> pos, List<Obstacle> obstacleList)
        {
            if (obstacleList != null && obstacleList.Any())
            {
                foreach (Obstacle x in obstacleList)
                {
                    if (x.Pos.Equals(pos))
                    {
                        return x;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Method to know if a cell if free
        /// </summary>
        /// <param name="obstacleList">The list of the obstacle of the room</param>
        /// <param name="player">The player of the game</param>
        /// <param name="enemyList">The list of the enemy of the game</param>
        /// <param name="pos">The position to check in</param>
        /// <returns>True if the cells is occupated otherwise false</returns>
        public static bool? CellsOccupated(List<Obstacle> obstacleList, Player player, List<SimpleEnemy> enemyList, Tuple<int, int> pos)
        {
            return player.Pos.Equals(pos) || SearchEnemy(pos, enemyList) != null || SearchObstacle(pos, obstacleList) != null;
        }
    }
}
