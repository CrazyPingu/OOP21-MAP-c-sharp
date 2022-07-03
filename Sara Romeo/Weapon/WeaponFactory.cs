using Strategy;
namespace WeaponObject
{
    /// <summary>
    /// Factory with methods to create different types of weapons.
    /// </summary>
    public class WeaponFactory : IWeaponFactory
    {
        /// <inheritdoc/>
        public Weapon CreateStick()
        {
            return new Weapon(IWeaponFactory.Damage.ONE, "stick", new AroundArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc/>
        public Weapon CreateAxe()
        {
            return new Weapon(IWeaponFactory.Damage.THREE, "axe", new AroundArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc/>
        public Weapon CreateDagger()
        {
            return new Weapon(IWeaponFactory.Damage.THREE, "dagger", new AroundArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc/>
        public Weapon CreateTube()
        {
            return new Weapon(IWeaponFactory.Damage.TWO, "tube", new AsteriskArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc/>
        public Weapon CreateGun()
        {
            return new Weapon(IWeaponFactory.Damage.FOUR, "gun", new AroundArea(VariableDistanceConstants.DOUBLE_DISTANCE));
        }



}
}
