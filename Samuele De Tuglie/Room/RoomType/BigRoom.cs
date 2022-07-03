using System;
using RoomArea;

namespace RoomType
{
    /// <summary>
    /// Biggest room possible
    /// </summary>
    internal class BigRoom : Room
    {
        /// <summary>
        /// Constructor of the big room
        /// </summary>
        /// <param name="size">The size of the room</param>
        /// <param name="player">The player of the game</param>
        public BigRoom(Tuple<int, int> size, Player player) : base(size, player, new Tuple<int, int>(2, size.Item2 / 2)) { }
    }
}
