using System;

namespace LeagueSharp
{
    /// <summary>
    ///     Game End Data.
    /// </summary>
    public class GameEndEventArgs : EventArgs
    {
        /// <summary>
        ///     Game End Event Args constructor.
        /// </summary>
        /// <param name="winningTeam">The winning team</param>
        public GameEndEventArgs(GameObjectTeam winningTeam) {}

        /// <summary>
        ///     Returns the saved winning team.
        /// </summary>
        public GameObjectTeam WinningTeam
        {
            get { }
        }
    }
}