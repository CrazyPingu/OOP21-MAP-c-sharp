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
        private readonly IWeaponFactory _wf = new WeaponFactory();
        /// <inheritdoc/>
        public SimpleEnemy CreateZombieStick(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new Movement(new AroundArea(1)), _wf.CreateStick(), "zombie stick");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieAxe(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new Movement(new AroundArea(1)), _wf.CreateAxe(), "zombie axe");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieDagger(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new Movement(new CrossArea(2)), _wf.CreateDagger(), "zombie dagger");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieTube(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new Movement(new AroundArea(1)), _wf.CreateTube(), "zombie tube");
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieGun(Tuple<int, int> pos)
        {
            return new SimpleEnemy(pos, new Movement(new CrossArea(2)), _wf.CreateGun(), "zombie gun");
        }
    }
}
