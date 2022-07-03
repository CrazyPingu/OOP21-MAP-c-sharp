using System;
using Utilities;
using WeaponObject;
namespace Enemy
{
    /// <summary>
    /// 
    /// </summary>
    public class EnemyFactory : IEnemyFactory
    {
        /// <inheritdoc />
        public SimpleEnemy CreateZombieStick(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(Health.LOW_HEALTH.getHealth()), pos, new WeaponFactory().CreateStick(),
                new MovementFactoryImpl().CreateStepMovement(), "zombie stick", EntityTexture.ZOMBIE_STICK);
        }

        /// <inheritdoc />
        public SimpleEnemy CreateZombieAxe(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(Health.LOW_HEALTH.getHealth()), pos, new WeaponFactory().CreateAxe(),
                new MovementFactoryImpl().CreateStepMovement(), "zombie axe", EntityTexture.ZOMBIE_AXE);
        }

        /// <inheritdoc />
        public SimpleEnemy CreateZombieDagger(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(Health.MID_HEALTH.getHealth()), pos, new WeaponFactory().CreateDagger(),
                new MovementFactoryImpl().CreateRunMovement(), "zombie dagger", EntityTexture.ZOMBIE_DAGGER);
        }

        /// <inheritdoc />
        public SimpleEnemy CreateZombieTube(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(Health.HIGH_HEALTH.getHealth()), pos, new WeaponFactory().CreateTube(),
                new MovementFactoryImpl().CreateStepMovement(), "zombie tube", EntityTexture.ZOMBIE_TUBE);
        }

        /// <inheritdoc />
        public SimpleEnemy CreateZombieGun(Tuple<int, int> pos)
        {
            return new SimpleEnemy(new SimpleLifeSystem(Health.HIGH_HEALTH.getHealth()), pos, new WeaponFactory().CreateGun(),
                new MovementFactoryImpl().CreateRunMovement(), "zombie gun", EntityTexture.ZOMBIE_GUN);
        }
    }
}
