using System;

namespace LeagueSharp
{
    /// <summary>
    ///     Collision Flags, are used to define certain position in the game which hold a collision.
    /// </summary>
    [Flags]
    public enum CollisionFlags : ushort
    {
        /// <summary>
        ///     No Collision
        /// </summary>
        None = 0,

        /// <summary>
        ///     Grass Collision
        /// </summary>
        Grass = (ushort) 1,

        /// <summary>
        ///     Wall Collision
        /// </summary>
        Wall = (ushort) 2,

        /// <summary>
        ///     Building Collision
        /// </summary>
        Building = (ushort) 64,

        /// <summary>
        ///     Prop (Object) Collision
        /// </summary>
        Prop = (ushort) 128
    }
}