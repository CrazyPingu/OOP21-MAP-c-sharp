using System;
using System.Collections.Generic;

namespace GameObject
{
    /// <summary>
    /// Declare the common method for the game_oject that can change their position
    /// in the game grid.
    /// </summary>
    public interface IMovingObject : IGameObject
    {
        new Tuple<int, int> Pos { get; set; }

        /// <summary>
        /// Uses the movement system to calculate the area that the object can reach
        /// </summary>
        /// <param name="size"></param>
        /// <returns>a list of nullable that represent the possible position the 
        /// object can reach</returns>
        public List<Tuple<int, int>>? ReachableArea(Tuple<int, int> pos, Tuple<int, int> size); 
    }
}
