using System;
using System.Collections.Generic;
using Strategy;
namespace WeaponObject
{
    /// <summary>
    /// Create the weapon designed by the passed value implementing the weapon interface.
    /// </summary>
    public class Weapon : IWeapon
    {
        public IWeaponFactory.Damage Damage { get; }
        public string Name { get; }
        private readonly IStrategy _shootingStrategy;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="damage">is the damage that the weapon can inflict</param>
        /// <param name="name">is the weapon's name</param>
        /// <param name="shootingStrategy">is the area within the weapon can reach</param>
        public Weapon(IWeaponFactory.Damage damage, string name, IStrategy shootingStrategy)
        {
            Damage = damage;
            Name = name;
            _shootingStrategy = shootingStrategy;
        }

        /// <inheritdoc/>
        public List<Tuple<int, int>> AttackArea(Tuple<int, int> pos, Tuple<int, int> size)
        {
            return _shootingStrategy.Execute(pos, size);
        }
    }
}
