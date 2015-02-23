using \u003CCppImplementationDetails\u003E;
using System;

namespace LeagueSharp
{
    /// <summary>
    ///     A unit that is attackable
    /// </summary>
    public class AttackableUnit : GameObject
    {
        /// <summary>
        ///     Returns the Path finding collision radius (in float-units).
        /// </summary>
        public float PathfindingCollisionRadius
        {
            get { }
        }

        /// <summary>
        ///     Returns the overridden collision height value (in float-units).
        /// </summary>
        public float OverrideCollisionHeight
        {
            get { }
        }

        /// <summary>
        ///     Returns the overridden collision radius (in float-units).
        /// </summary>
        public float OverrideCollisionRadius
        {
            get { }
        }

        /// <summary>
        ///     Returns the Armor's material string.
        /// </summary>
        public string ArmorMaterial
        {
            get { }
        }

        /// <summary>
        ///     Returns if the unit is immune to lifesteal.
        /// </summary>
        public bool LifestealImmune
        {
            get { }
        }

        /// <summary>
        ///     Returns if the unit is immune to magic.
        /// </summary>
        public bool MagicImmune
        {
            get { }
        }

        /// <summary>
        ///     Returns if the unit is immune to physical.
        /// </summary>
        public bool PhysicalImmune
        {
            get { }
        }

        /// <summary>
        ///     Returns if the unit is invulnerable.
        /// </summary>
        public bool IsInvulnerable
        {
            get { }
        }

        /// <summary>
        ///     Returns the unit's maximum mana (in float-units).
        /// </summary>
        public float MaxMana
        {
            get { }
        }

        /// <summary>
        ///     Returns the unit's current mana (in float-units).
        /// </summary>
        public float Mana
        {
            get { }
        }

        /// <summary>
        ///     Returns the unit's maximum health (in float-units).
        /// </summary>
        public float MaxHealth
        {
            get { }
        }

        /// <summary>
        ///     Returns the unit's current health (in float-units).
        /// </summary>
        public float Health
        {
            get { }
        }

        /// <summary>
        ///     Returns if the unit is a zombie.
        /// </summary>
        public bool IsZombie
        {
            get { }
        }

        /// <summary>
        ///     Returns if the unit is targetable.
        /// </summary>
        public bool IsTargetable
        {
            get { }
        }
    }
}