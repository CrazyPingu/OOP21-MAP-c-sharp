using GameObject;
using System;
using System.Drawing;


namespace ObstacleObject
{
    /// <summary>
    /// The class of the obstacle created in Game
    /// </summary>
    public class Obstacle : IGameObject
    {
        public Obstacle(Tuple<int, int> pos, string v, Image image) { }

        /// <summary>
        ///  The position of the obstacle
        /// </summary>
        public Tuple<int, int> Pos { get; }

        /// <summary>
        /// The name of the obstacle
        /// </summary>
        public string Name { get; }
    }
}
