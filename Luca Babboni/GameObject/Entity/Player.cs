using MovementStrategy;
using System;
using WeaponObject;

namespace EntityObject
{
    /// <summary>
    /// This class model the player's entity. Can perform multiple action in a turn,
    /// can change is position, can use artefact, can take damage and can carry a
    /// weapon
    /// That's only a partial transaltion from the java project. Expose only the method of 
    /// the movement system and the action number. 
    /// </summary>
    public class Player : Entity
    {
        /// <summary>
        /// Represent the number of action the player can perform in a turn. 
        /// </summary>
        public int ActionNumber { get; set; }

        /// <summary>
        /// Used to create a class player
        /// </summary>
        /// <param name="pos">The starting player position</param>
        /// <param name="movement">The movement system the player will use </param>
        /// <param name="weapon">The weapon the player start with</param>
        /// <param name="name">The name of the player</param>
        /// <param name="initialActionNumber">The starting amount of action the player can perform in a turn</param>

        public Player(Tuple<int, int> pos, IMovement movement, IWeapon weapon,
            string name, int initialActionNumber) : base(name, pos, movement, weapon)
        {
            ActionNumber = initialActionNumber;
        } 
    }
}
