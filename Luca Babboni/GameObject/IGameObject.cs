using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop21_MAP_Csharp.OOP21_MAP_c_sharp.Luca_Babboni.GameObject
{
    /// <summary>
    /// This class declare the common get for every object in game that can be
    /// displayed in the game grid.
    /// </summary>
    public interface IGameObject
    {
        Tuple<int, int> Pos { get; }

        String name { get; } 

    }
}
