namespace Weapon
{
    /// <summary>
    /// Factory with methods to create different types of weapons.
    /// </summary>
    public class WeaponFactory
    {
        /// <inheritdoc />
        public Weapon createStick()
        {
            return new Weapon(IWeaponFactory.Damage.ONE, "stick", new AroundArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc />
        public Weapon createAxe()
        {
            return new Weapon(IWeaponFactory.Damage.THREE, "axe", new AroundArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc />
        public Weapon createDagger()
        {
            return new Weapon(IWeaponFactory.Damage.THREE, "dagger", new AroundArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc />
        public Weapon createTube()
        {
            return new Weapon(IWeaponFactory.Damage.TWO, "tube", new AsteriskArea(VariableDistanceConstants.SINGLE_DISTANCE));
        }

        /// <inheritdoc />
        public Weapon createGun()
        {
            return new Weapon(IWeaponFactory.Damage.FOUR, "gun", new AroundArea(VariableDistanceConstants.DOUBLE_DISTANCE));
        }



}
}
