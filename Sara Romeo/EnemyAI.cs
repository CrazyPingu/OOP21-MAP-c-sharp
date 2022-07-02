
/// <summary>
/// Implementation of enemies behaviors.
/// </summary>
namespace EnemyAI
{
    public class EnemyAI : IEnemyAI
    {

        private Room.Room _room;

        public EnemyAI(Room.Room room) => _room = room;

        /// <summary>
        /// Updates the room in which the enemy AI is placed.
        /// </summary>
        /// <param name="room">current room</param>
        public void updateAIRoom(readonly Room.Room room)
        {
            _room = room;
        }




        /// <inheritdoc />
        public Tuple<int, int> move(SimpleEnemy enemy)
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc />
        public bool isPlayerInAttackArea(SimpleEnemy enemy, Player player, Tuple<int, int> roomSize)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cell">from which is calculated the distance</param>
        /// <param name="playerPos">player's current position</param>
        /// <returns>the distance between player's current position and given cell</returns>
        private int calculateDistanceFromPlayer(final Pair<Integer, Integer> cell, final Pair<Integer, Integer> playerPos)
        {
            
        }

    }
}
