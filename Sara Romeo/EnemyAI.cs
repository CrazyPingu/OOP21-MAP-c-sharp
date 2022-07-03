using Utilities;
/// <summary>
/// Implementation of enemies behaviors.
/// </summary>
namespace EnemyAI
{
    public class EnemyAI : IEnemyAI
    {

        private Room.Room _room;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="room">current room</param>
        public EnemyAI(Room.Room room) => _room = room;

        /// <summary>
        /// Updates the room in which the enemy AI is placed.
        /// </summary>
        /// <param name="room">current room</param>
        public void UpdateAIRoom(Room.Room room) => _room = room;

        /// <inheritdoc />
        public Tuple<int, int> Move(SimpleEnemy enemy)
        {
            Tuple<int, int> newEnemyPos = enemy.getPos();
            int distance, minDistance = int.MaxValue;
            foreach (var cell in enemy.getReachableArea(_room.Size).get())
            {
                distance = CalculateDistanceFromPlayer(cell, _room.Player.getPos());
                if (distance < minDistance && !(RoomConstant.CellsOccupated(_room.EnemyList, _room.ArtefactList, _room.ObstacleList, _room.Player, cell)))
                {
                    newEnemyPos = cell;
                    minDistance = distance;
                }
            }
            return newEnemyPos;
        }


        /// <inheritdoc />
        public bool IsPlayerInAttackArea(SimpleEnemy enemy, Player player, Tuple<int, int> roomSize)
        {
            List<Tuple<int, int>> attackableArea = enemy.getWeapon().getAttackArea(enemy.getPos(), roomSize);
            return attackableArea.Contains(player.getPos());
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
