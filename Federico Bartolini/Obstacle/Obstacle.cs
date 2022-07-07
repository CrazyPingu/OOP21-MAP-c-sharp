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

        /// <summary>
        ///  The position of the obstacle
        /// </summary>
        public Tuple<int, int> Pos { get; }

        /// <summary>
        /// The name of the obstacle
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pos"> position of the obstacle</param>
        /// <param name="name">name of the obstacle</param>
        public Obstacle(Tuple<int, int> pos, string name)
        {
            Pos = pos;
            Name = name;
        }
    }
}
