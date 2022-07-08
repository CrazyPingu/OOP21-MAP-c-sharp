using System;
using System.Collections.Generic;
using Utilities; 

namespace Strategy
{   /// <summary>
    /// Concrete strategy. Implements an algorithm that returns the area around chosen position.
    /// </summary>
    public class AroundArea : IStrategy
    {
        private readonly int _distance;

        /// <summary>
        /// Set the parameter distance
        /// </summary>
        /// <param name="distance">the area the strategy can reach</param>
        public AroundArea(int distance)
        {
           _distance = distance;
        }

        public List<Tuple<int, int>> Execute(Tuple<int, int> pos, Tuple<int, int> size)
        {
            List<Tuple< int, int>> reachableCells = new();
            for (int i = pos.Item1 - _distance; i <= pos.Item1 + _distance; i++)
            {
                for (int j = pos.Item2 - _distance; j <= pos.Item2 + _distance; j++)
                {
                    Tuple<int, int> cellToAdd = new(i, j);
                    if (!pos.Equals(cellToAdd) && PosInGrid.CheckPosInGrid(cellToAdd, size))
                    {
                        reachableCells.Add(cellToAdd);
                    }
                }
            }
            return reachableCells;
        }
    }
}

