using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
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
            List<Tuple< int, int>> reachableCells = new List<Tuple<int, int>>();
            for (int i = pos.Item1 - _distance; i <= pos.Item1 + _distance; i++)
            {
                for (int j = pos.Item2 - _distance; j <= pos.Item2 + _distance; j++)
                {
                    Tuple<int, int> cellToAdd = new Tuple<int, int>(i, j);
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
}
