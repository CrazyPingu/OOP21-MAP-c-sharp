using System;
using RoomArea;

namespace RoomType
{
    /// <summary>
    /// The smaller room
    /// </summary>
    public class SmallRoom : Room
    {
        /// <summary>
        /// The constructor of the small room
        /// </summary>
        /// <param name="size">The size of the room</param>
        /// <param name="player">The player of the game</param>
        public SmallRoom(Tuple<int, int> size, Player player) : base(size, player, new Tuple<int, int>(1, size.Item2 / 2)) { }
    }
}
