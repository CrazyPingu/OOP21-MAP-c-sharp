using System;
using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// Interface that defines the method execute for the "Strategy" design pattern
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Given a position and the grid size calculate the possible position where the user can move.  
        /// </summary>
        /// <param name="pos">An absolute position in the map grid</param>
        /// <param name="size">Represent the size of the map grid</param>
        /// <returns>Selectable position calculated by an internal algorithm</returns>
        List<Tuple<int, int>> Execute(Tuple<int, int> pos, Tuple<int, int> size);
    }
}
