using LeagueSharp.Native;
using std;
using System;

namespace LeagueSharp
{
    /// <summary>
    ///     Defines a BuffInstance.
    /// </summary>
    public class BuffInstance
    {
        /// <summary>
        ///     Buff Instance.
        /// </summary>
        /// <param name="m_networkId">Game Network Identity (ID)</param>
        /// <param name="index">Buff Instance Index</param>
        internal BuffInstance(uint m_networkId, uint index) {}

        /// <summary>
        ///     Returns the buff's caster.
        /// </summary>
        public GameObject Caster
        {
            get { }
        }

        /// <summary>
        ///     Returns the buff's source name (string).
        /// </summary>
        public string SourceName
        {
            get { }
        }

        /// <summary>
        ///     Returns the buff's name (string).
        /// </summary>
        public string Name
        {
            get { }
        }

        /// <summary>
        ///     Returns the buff's display name (string).
        /// </summary>
        public string DisplayName
        {
            get { }
        }

        /// <summary>
        ///     Returns the buff's end time (in float-units).
        /// </summary>
        public float EndTime
        {
            get { }
        }

        /// <summary>
        ///     Returns the buff's starting time (in float-units).
        /// </summary>
        public float StartTime
        {
            get { }
        }

        /// <summary>
        ///     Returns if the buff has a positive effect.
        /// </summary>
        public bool IsPositive
        {
            get { }
        }

        /// <summary>
        ///     Returns if the buff is active.
        /// </summary>
        public bool IsActive
        {
            get { }
        }

        /// <summary>
        ///     Returns the stack count of the buff.
        /// </summary>
        public int Count
        {
            get { }
        }

        /// <summary>
        ///     Gets the type of the buff.
        /// </summary>
        public BuffType Type
        {
            get { }
        }
    }
}