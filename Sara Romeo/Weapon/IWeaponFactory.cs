namespace WeaponObject
{
    public interface IWeaponFactory
    {
        /// <summary>
        /// Different types of damage values.
        /// </summary>
        enum Damage
        {
            ONE=1,
            TWO=2,
            THREE=3,
            FOUR=4
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>a stick</returns>
        Weapon CreateStick();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>an axe</returns>
        Weapon CreateAxe();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>a dagger</returns>
        Weapon CreateDagger();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>a tube</returns>
        Weapon CreateTube();

        /// <summary>
        /// 
        /// </summary>
        /// <returns>a gun</returns>
        Weapon CreateGun();
    }
}
