namespace WeaponObject
{
    /// <summary>
    /// Interface that declares methods for the weapon factory.
    /// </summary>
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
        /// Creates a stick weapon.
        /// </summary>
        /// <returns>a stick</returns>
        Weapon CreateStick();

        /// <summary>
        /// Creates a gun weapon.
        /// </summary>
        /// <returns>an axe</returns>
        Weapon CreateAxe();

        /// <summary>
        /// Creates a dagger weapon.
        /// </summary>
        /// <returns>a dagger</returns>
        Weapon CreateDagger();

        /// <summary>
        /// Creates a tube weapon.
        /// </summary>
        /// <returns>a tube</returns>
        Weapon CreateTube();

        /// <summary>
        /// Creates a gun weapon.
        /// </summary>
        /// <returns>a gun</returns>
        Weapon CreateGun();
    }
}
