using MovementStrategy;
using System;
using WeaponObject; 

namespace EntityObject
{
    /// <summary>
    /// Wraps the entity class and allows a simple way to distingue an entity from a
    /// simpleEnemy
    /// This is only a partial translation. It exposes only the methods that are useful for moving the object. 
    /// </summary>
    public class SimpleEnemy : Entity
    {
        /// <summary>
        /// Used to create a class SimpleEnemy
        /// </summary>
        /// <param name="pos">The starting enemy position</param>
        /// <param name="movement">The position of the entity</param>
        /// <param name="name">The name of the entity</param>
        public SimpleEnemy(Tuple<int, int> pos, IMovement movement, 
            IWeapon weapon,  string name) : base(name, pos, movement, weapon) { }
    }
}
