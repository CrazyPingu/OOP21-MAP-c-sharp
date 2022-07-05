using System;
using System.Collections.Generic;
using Utilities;
using RoomArea;
using EntityObject;

namespace EnemyAIMovement
{
    /// <summary>
    /// Implementation of enemies behaviors.
    /// </summary>
    public class EnemyAI : IEnemyAI
    {
        private Room _room;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="room">current room</param>
        public EnemyAI(Room room) => _room = room;

        /// <summary>
        /// Updates the room in which the enemy AI is placed.
        /// </summary>
        /// <param name="room">current room</param>
        public void UpdateAIRoom(Room room) => _room = room;

        /// <inheritdoc/>
        public Tuple<int, int> Move(SimpleEnemy enemy)
        {
            Tuple<int, int> newEnemyPos = enemy.Pos;
            int distance, minDistance = _room.Size.Item1 + _room.Size.Item1;
            foreach (var cell in enemy.ReachableArea(_room.Size))
            {
                distance = CalculateDistanceFromPlayer(cell, _room.Player.Pos);
                if (distance < minDistance && !(RoomConstant.CellsOccupated(_room.EnemyList, _room.ArtefactList, _room.ObstacleList, _room.Player, cell)))
                {
                    newEnemyPos = cell;
                    minDistance = distance;
                }
            }
            return newEnemyPos;
        }


        /// <inheritdoc/>
        public bool IsPlayerInAttackArea(SimpleEnemy enemy, Player player, Tuple<int, int> roomSize)
        {
            List<Tuple<int, int>> attackableArea = enemy.Weapon.AttackArea(enemy.Pos, roomSize);
            return attackableArea.Contains(player.Pos);
        }

        /// <summary>
        /// Calculates the distance from a given cell to player's position.
        /// </summary>
        /// <param name="cell">from which is calculated the distance</param>
        /// <param name="playerPos">player's current position</param>
        /// <returns>the distance between player's current position and given cell</returns>
        private int CalculateDistanceFromPlayer(Tuple<int, int> cell, Tuple<int, int> playerPos)
        {
            return Math.Abs(cell.Item1 - playerPos.Item1) + Math.Abs(cell.Item2 - playerPos.Item2);
        }
    }
}
