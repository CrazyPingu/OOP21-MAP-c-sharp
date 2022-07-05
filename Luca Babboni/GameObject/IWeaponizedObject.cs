using WeaponObject; 

namespace GameObject
{
    /// <summary>
    /// Declare the method for the game object that can hold a weapon. 
    /// </summary>
    public interface IWeaponizedObject : IGameObject 
    {
        /// <summary>
        /// Represent the weapon the object is currently holding. 
        /// </summary>
        IWeapon Weapon {  get; set; }   
    }
}
