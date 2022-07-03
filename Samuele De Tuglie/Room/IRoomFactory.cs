namespace RoomArea
{
    /// <summary>
    /// Interface for the creation of a room factory
    /// </summary>
    public interface IRoomFactory
    {
        /// <summary>
        /// Method to create a small room
        /// </summary>
        /// <returns>A small room</returns>
        Room CreateSmallRoom();

        /// <summary>
        /// Method to create a big room
        /// </summary>
        /// <returns>A big room</returns>
        Room CreateBigRoom();

        /// <summary>
        /// Method to create a medium room
        /// </summary>
        /// <returns>A medium room</returns>
        Room CreateMediumRoom();
    }
}
