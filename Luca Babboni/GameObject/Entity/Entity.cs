using System;
using MovementStrategy; 
using System.Collections.Generic;
using GameObject;
using WeaponObject;

namespace EntityObject
{
    /// <summary>
    ///Class to incapsulate an entity behaviur. This class will be extends to create
    /// more complex Entity.
    /// Implements all the common method for a simple game object able to hold a
    /// weapon, move and take damage. This class is used for the enemy
    /// implementation.
    /// 
    /// This class is only partially traslated from jata to c#. It will implement only the movement 
    /// feature
    /// </summary>
    public class Entity : IMovingObject, IWeaponizedObject 
    {
        private Tuple<int, int> _pos;
        private readonly string _name;
        private readonly IMovement _movement;
        private  IWeapon _weapon;

        /// <summary>
        /// create a new istance of an Entity class. 
        /// </summary>
        /// <param name="name">The name of the entity</param>
        /// <param name="pos">The position of the entity</param>
        /// <param name="movement">The movement sistem of the entity</param>
        /// <param name="weapon">The weapon the entity is holding</param>
        public Entity(string name, Tuple<int, int> pos, IMovement movement, IWeapon weapon)
        {
            _pos = pos;
            _name = name;
            _movement = movement;
            _weapon = weapon;
        }

        /// <summary>
        /// The current Entity position
        /// </summary>
        public Tuple<int, int> Pos { get => _pos; set => _pos = value; }

        /// <summary>
        /// The name of the entity
        /// </summary>
        public string Name => _name;

        public IWeapon Weapon { get => _weapon; set => _weapon = value; }

        public List<Tuple<int, int>>? ReachableArea(Tuple<int, int> size)
        {
            return _movement.ReachableCells(_pos, size);
        }
    }
}
