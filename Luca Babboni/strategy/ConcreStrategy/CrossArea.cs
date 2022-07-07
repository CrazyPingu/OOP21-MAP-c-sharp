using System;
using System.Collections.Generic;
using Utilities; 

namespace Strategy
{
	/// <summary>
	/// Concrete strategy. Implements an algorithm that returns a cross shaped area around the given coordinate.
	/// </summary>
	public class CrossArea : IStrategy
    {
		private readonly int _distance;
		/// <summary>
		/// Create an istance of the cross area strategy.
		/// </summary>
		/// <param name="distance">Distance is how far from around area can reach</param>
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
				if (!pos.Equals(cellToAdd) && PosInGrid.CheckPosInGrid(cellToAdd, size))
				{
					reachableCells.Add(cellToAdd);
				}
			}

			for (int i = pos.Item2 - _distance; i <= pos.Item2 + _distance; i++)
			{
				cellToAdd = new Tuple<int, int>(pos.Item1, i);
				if (!pos.Equals(cellToAdd) && PosInGrid.CheckPosInGrid(cellToAdd, size))
				{
					reachableCells.Add(cellToAdd);
				}
			}

			return reachableCells;
		}
    }
}
