using System;
using Utilities;
using RoomType;

namespace RoomArea
{
    /// <summary>
    /// The factory of room
    /// </summary>
    public class RoomFactory : IRoomFactory
    {
        private readonly Player _player;

        /// <summary>
        /// The constructor of the room factory
        /// </summary>
        /// <param name="player">The player of the game</param>
        public RoomFactory(Player player)
        {
            _player = player;
        }

        /// <inheritdoc/>
        public Room CreateBigRoom()
        {
            return new BigRoom(RoomConstant.MAX_DIM, _player);
        }

        /// <inheritdoc/>
        public Room CreateMediumRoom()
        {
            return new MediumRoom(new Tuple<int, int>((RoomConstant.MAX_DIM.Item1 + RoomConstant.MIN_DIM.Item1) / 2,
                (RoomConstant.MAX_DIM.Item2 + RoomConstant.MIN_DIM.Item2) / 2), _player);
        }

        /// <inheritdoc/>
        public Room CreateSmallRoom()
        {
            return new SmallRoom(RoomConstant.MIN_DIM, _player);
        }
    }
}
