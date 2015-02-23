using System;

namespace LeagueSharp
{
    /// <summary>
    ///     Game Notify Event Arguments, contains information about an event identity that is newly passed, to state an event.
    /// </summary>
    public class GameNotifyEventArgs : EventArgs
    {
        /// <summary>
        ///     Game Notify Event Arguments Constructor.
        /// </summary>
        /// <param name="eventId">Event identity (Id)</param>
        /// <param name="networkId">Game Network Identity (Id)</param>
        public GameNotifyEventArgs(GameEventId eventId, uint networkId) {}

        /// <summary>
        ///     Game Network Identity (Id).
        /// </summary>
        public uint NetworkId
        {
            get { }
        }

        /// <summary>
        ///     Event identity that is passed (Id).
        /// </summary>
        public GameEventId EventId
        {
            get { }
        }
    }
}