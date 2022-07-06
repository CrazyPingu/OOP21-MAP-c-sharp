using GameObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        Tuple<int, int> IGameObject.Pos { get; }

        /// <summary>
        /// The name of the obstacle
        /// </summary>
        string IGameObject.Name { get; }
    }
}
