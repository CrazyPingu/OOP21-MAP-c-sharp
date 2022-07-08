using System;
using RoomArea;
using EntityObject;

namespace RoomType
{
    /// <summary>
    /// Room with medium dimension
    /// </summary>
    public class MediumRoom : Room
    {
        /// <summary>
        /// Constructor of the medium room
        /// </summary>
        /// <param name="size">The size of the room</param>
        /// <param name="Player">The player of the game</param>
        public MediumRoom(Tuple<int, int> size, Player Player) : base(size, Player, new Tuple<int, int>(0, size.Item2 / 2)) { }
    }
}
