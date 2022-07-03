using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CrossArea : IStrategy
    {
		private readonly int _distance;
		public CrossArea(int distance)
		{
			_distance = distance;
		}

		public List<Tuple<int, int>> Execute(Tuple<int, int> pos, Tuple<int, int> size)
        {
			List<Tuple<int, int>> reachableCells = new List<Tuple<int, int>>();
			Tuple<int, int> cellToAdd;

			for (int i = pos.Item1 - _distance; i <= pos.Item1 + _distance; i++)
			{
				cellToAdd = new Tuple<int, int>(i, pos.Item2);
				if (!pos.Equals(cellToAdd) && PosInGrid.checkPosInGrid(cellToAdd, size))
				{
					reachableCells.Add(cellToAdd);
				}
			}

			for (int i = pos.Item2 - _distance; i <= pos.Item2 + _distance; i++)
			{
				cellToAdd = new Tuple<int, int>(pos.Item1, i);
				if (!pos.Equals(cellToAdd) && PosInGrid.checkPosInGrid(cellToAdd, size))
				{
					reachableCells.Add(cellToAdd);
				}
			}

			return reachableCells;
		}
    }
}
