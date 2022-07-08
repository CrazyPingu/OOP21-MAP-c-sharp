using System;
using EntityObject;
namespace Enemy
{
    /// <summary>
    /// Interface that declares methods for the enemy factory.
    /// </summary>
    public interface IEnemyFactory
    {

        /// <summary>
        /// Different types of health values.
        /// </summary>
        enum Health
        {
            LOW_HEALTH = 5,
            MID_HEALTH = 7,
            HIGH_HEALTH = 10
        }

        /// <summary>
        /// Creates a zombie with a stick.
        /// </summary>
        /// <param name="pos">the position to spawn the enemy</param>
        /// <returns>a new enemy using a stick as a weapon.</returns>
        SimpleEnemy CreateZombieStick(Tuple<int, int> pos);

        /// <summary>
        /// Creates a zombie with an axe.
        /// </summary>
        /// <param name="pos">the position to spawn the enemy</param>
        /// <returns>a new enemy using an axe as a weapon.</returns>
        SimpleEnemy CreateZombieAxe(Tuple<int, int> pos);

        /// <summary>
        /// Creates a zombie with a dagger.
        /// </summary>
        /// <param name="pos">the position to spawn the enemy</param>
        /// <returns>a new enemy using a dagger as a weapon.</returns>
        SimpleEnemy CreateZombieDagger(Tuple<int, int> pos);

        /// <summary>
        /// Creates a zombie with a tube.
        /// </summary>
        /// <param name="pos">the position to spawn the enemy</param>
        /// <returns>a new enemy using a tube as a weapon.</returns>
        SimpleEnemy CreateZombieTube(Tuple<int, int> pos);

        /// <summary>
        /// Creates a zombie with a gun.
        /// </summary>
        /// <param name="pos">the position to spawn the enemy</param>
        /// <returns>a new enemy using a gun as a weapon.</returns>
        SimpleEnemy CreateZombieGun(Tuple<int, int> pos);

    }
}
