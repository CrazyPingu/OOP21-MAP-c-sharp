using System;

namespace Utilities
{
    /// <summary>
    /// Offer a static method that check il the given position is in the given grid size.
    /// </summary>
    public class PosInGrid
    {
        private PosInGrid() { }
        /// <summary>
        /// Check il the given position is in the given grid size. 
        /// </summary>
        /// <param name="pos">Represents the position to check (coordinate in 0 based sistem)</param>
        /// <param name="size">Represents the grid size. First coordinate determinates the
        /// horizontal number of cells(1 based) and second one the vertical
        /// number of cells.</param>
        /// <returns></returns>
        public static bool CheckPosInGrid(Tuple<int, int> pos, Tuple<int, int> size)
        {
            return !(pos.Item1 < 0 || pos.Item2 < 0 || pos.Item1 >= size.Item1 || pos.Item2 >= size.Item2);
        }
    }
}
