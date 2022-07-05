using System;
using WeaponObject;
using EntityObject;
using Strategy;
using MovementStrategy;
namespace Enemy
{
    /// <summary>
    /// Factory to create new enemy.
    /// </summary>
    public class EnemyFactory : IEnemyFactory
    {
        /// <inheritdoc/>
        public SimpleEnemy CreateZombieStick(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new WeaponFactory().CreateStick(), new Movement(new AroundArea(1)), "zombie stick");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieAxe(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new WeaponFactory().CreateAxe(), new Movement(new AroundArea(1)), "zombie axe");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieDagger(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new WeaponFactory().CreateDagger(), new Movement(new CrossArea(2)), "zombie dagger");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieTube(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new WeaponFactory().CreateTube(), new Movement(new AroundArea(1)), "zombie tube");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieGun(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new WeaponFactory().CreateGun(), new Movement(new CrossArea(2)), "zombie gun");
        }
    }
}
