using System;

namespace EnemyAI
{
    /// <summary>
    /// Methods to define enemies behaviors during their turn.
    /// </summary>
    public interface IEnemyAI
    {

        /// <summary>
        /// Enemy automated movement.
        /// </summary>
        /// <param name="enemy">enemy of which is needed to change position</param>
        /// <returns>the new calculated position for the enemy</returns>
        Tuple<int, int> Move(SimpleEnemy enemy);

        /// <summary>
        /// Checks if player is reachable by the enemy attack.
        /// </summary>
        /// <param name="enemy">entity of which is needed to know the attackable area</param>
        /// <param name="player">entity to be found whether or not is in the attackable area</param>
        /// <param name="roomSize">size of the current room</param>
        /// <returns>true if the player passed is in the attack area of the enemy passed</returns>
        bool IsPlayerInAttackArea(SimpleEnemy enemy, Player player, Tuple<int, int> roomSize);

    }
}
