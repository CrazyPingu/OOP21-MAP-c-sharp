using System;
using System.Collections.Generic;

namespace MovementStrategy
{
    /// <summary>
    /// Interface that declare methods for the movement sistem. Represent the
    /// "Context" of the Strategy interface.
    /// </summary>
    public interface IMovement
    {
        /// <summary>
        /// Given the a position that represent the current utilizer position return a list 
        /// that rapresent the possible position it can reach. 
        /// </summary>
        /// <param name="pos"> The current position in the map grid</param>
        /// <param name="size">The size of the map grid</param>
        /// <returns></returns>
        List<Tuple<int, int>> ReachableCells(Tuple<int, int> pos, Tuple<int, int> size);
    }
}

