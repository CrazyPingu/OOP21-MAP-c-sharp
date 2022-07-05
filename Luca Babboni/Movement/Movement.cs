using System;
using System.Collections.Generic;
using Strategy;

namespace MovementStrategy
{
    /// <summary>
    /// This class define the method for the movement implementation. This class is a
    /// part of the stratey pattern, represent the "Context" of the Strategy interface.
    /// </summary>
    public class Movement : IMovement
    {
        private readonly IStrategy _movingStrategy;

        /// <summary>
        /// set the movingStrategy of the movement system to the desired one passed in input as an argument.
        /// </summary>
        /// <param name="movingStrategy">the strategy of the movement system</param>
        public Movement(IStrategy movingStrategy) 
        {
            _movingStrategy = movingStrategy;
        }

        public List<Tuple<int, int>> ReachableCells(Tuple<int, int> pos, Tuple<int, int> size)
        {
            return _movingStrategy.Execute(pos, size);
        }
    }
}
