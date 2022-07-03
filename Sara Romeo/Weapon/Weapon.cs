using System;
using System.Collections.Generic;
namespace WeaponObject
{
    /// <summary>
    /// Create the weapon designed by the passed value implementing the weapon interface.
    /// </summary>
    public class Weapon : IWeapon
    {
        public IWeaponFactory.Damage Damage { get; }
        public string Name { get; }
        private readonly Strategy _shootingStrategy;

        /**
         * @param damage           is the damage that the weapon can inflict
         * @param shootingStrategy is the area within the weapon can reach
         */
        public Weapon(IWeaponFactory.Damage damage, string name, Strategy shootingStrategy)
        {
            Damage = damage;
            Name = name;
            _shootingStrategy = shootingStrategy;
        }

        /// <inheritdoc />
        public List<Tuple<int, int>> getAttackArea(Tuple<int, int> pos, Tuple<int, int> size)
        {
            return _shootingStrategy.execute(pos, size);
        }
    }
}
