using System;

namespace LeagueSharp
{
    /// <summary>
    ///     GameObject Instant Stop Attack Event Arguments, contains information about an instantly stopped attack event.
    /// </summary>
    public class GameObjectInstantStopAttackEventArgs : EventArgs
    {
        /// <summary>
        ///     GameObject Instant Stop Attack Event Arguments.
        /// </summary>
        /// <param name="unk1">Unknown (index 1)</param>
        /// <param name="unk2">Missile's Network Identity (Id).</param>
        /// <param name="bitData">BitData of the GameObject Instant Stop Attack Event.</param>
        public GameObjectInstantStopAttackEventArgs(uint unk1, uint unk2, byte bitData) {}

        /// <summary>
        ///     BitData of the GameObject.
        /// </summary>
        public byte BitData
        {
            get { }
        }

        /// <summary>
        ///     Missile's Network Identity (Id).
        /// </summary>
        public int MissileNetworkId
        {
            get { }
        }

        /// <summary>
        ///     Unknown 1.
        /// </summary>
        public uint Unk1
        {
            get { }
        }
    }
}