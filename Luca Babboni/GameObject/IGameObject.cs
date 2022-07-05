using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject
{
    /// <summary>
    /// This class declare the common get for every object in game that can be
    /// displayed in the game grid.
    /// </summary>
    public interface IGameObject
    {
        /// <summary>
        /// Represent the Game Object position.
        /// </summary>
        Tuple<int, int> Pos { get; }

        /// <summary>
        /// Represent the Game Objec name.
        /// </summary>
        string Name { get; } 

    }
}
