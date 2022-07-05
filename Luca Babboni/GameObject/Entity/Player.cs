using MovementStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Used to create an class player
        /// </summary>
        /// <param name="pos">The starting player position</param>
        /// <param name="movement">The movement system the player will use </param>
        /// <param name="name">The name of the player</param>
        /// <param name="initialActionNumber">The starting amount of action the player can perform in a turn</param>
        public Player(Tuple<int, int> pos, IMovement movement, string name, int initialActionNumber) : base(name, pos, movement)
        {
            ActionNumber = initialActionNumber;
        } 
    }
}
