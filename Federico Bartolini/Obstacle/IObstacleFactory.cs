using System;

namespace ObstacleObject
{

    /// <summary>
    /// Interface that define methods for the creations of Obstacles
    /// </summary>
    public interface IObstacleFactory
    {
        /// <summary>
        /// Create a new Rock Obstacle
        /// </summary>
        /// <param name="pos"> The position of the Obstacle</param>
        /// <returns></returns>
        Obstacle CreateRock(Tuple<int, int> pos);

        /// <summary>
        /// Create a new Pebble Obstacle
        /// </summary>
        /// <param name="pos"> The position of the Obstacle</param>
        /// <returns></returns>
        Obstacle CreatePebble(Tuple<int, int> pos);
    }
}
