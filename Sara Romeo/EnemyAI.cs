using Room;
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
            throw new NotImplementedException();
        }
        /// <inheritdoc />
        public bool IsPlayerInAttackArea(SimpleEnemy enemy, Player player, Tuple<int, int> roomSize)
        {
            throw new NotImplementedException();
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
