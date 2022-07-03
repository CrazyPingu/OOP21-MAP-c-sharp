using System;
using System.Collections.Generic;
namespace WeaponObject
{
    /// <summary>
    /// Interface that declares methods for the weapon. Represent the "Context" of Factory interface.
    /// </summary>
    public interface IWeapon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pos">current pos</param>
        /// <param name="size"></param>
        /// <returns>list of available cells to attack based on shooting strategy applied.</returns>
        List<Tuple<int, int>> getAttackArea(Tuple<int, int> pos, Tuple<int, int> size);
    }
}
