using System;

namespace ObstacleObject

{
    /// <summary>
    /// The class that implements the interface ObstacleFactory
    /// </summary>
    public class ObstacleFactoryImpl : IObstacleFactory
    {
        /// <inheritdoc/>
        public Obstacle CreatePebble(Tuple<int, int> pos)
        {
            return new Obstacle(pos, "rock", null);
        }

        /// <inheritdoc/>
        public Obstacle CreateRock(Tuple<int, int> pos)
        {
            return new Obstacle(pos, "pebble", null);
        }
    }
}
