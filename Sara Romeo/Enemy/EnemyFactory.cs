using System;
using Utilities;
using WeaponObject;
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
            return new SimpleEnemy(new SimpleLifeSystem(IEnemyFactory.Health.LOW_HEALTH), pos, new WeaponFactory().CreateStick(),
                new MovementFactory().CreateStepMovement(), "zombie stick", EntityTexture.ZOMBIE_STICK);
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieAxe(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(IEnemyFactory.Health.LOW_HEALTH), pos, new WeaponFactory().CreateAxe(),
                new MovementFactory().CreateStepMovement(), "zombie axe", EntityTexture.ZOMBIE_AXE);
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieDagger(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(IEnemyFactory.Health.MID_HEALTH), pos, new WeaponFactory().CreateDagger(),
                new MovementFactory().CreateRunMovement(), "zombie dagger", EntityTexture.ZOMBIE_DAGGER);
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieTube(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(IEnemyFactory.Health.HIGH_HEALTH), pos, new WeaponFactory().CreateTube(),
                new MovementFactory().CreateStepMovement(), "zombie tube", EntityTexture.ZOMBIE_TUBE);
        }

        /// <inheritdoc/>
        public SimpleEnemy CreateZombieGun(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(IEnemyFactory.Health.HIGH_HEALTH), pos, new WeaponFactory().CreateGun(),
                new MovementFactory().CreateRunMovement(), "zombie gun", EntityTexture.ZOMBIE_GUN);
        }
    }
}
