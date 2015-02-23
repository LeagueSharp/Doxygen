namespace LeagueSharp
{
    /// <summary>
    ///     GameMode enum, contains an identity number for each mode.
    /// </summary>
    public enum GameMode
    {
        /// <summary>
        ///     Connecting GameMode identity (Id).
        /// </summary>
        Connecting = 1,

        /// <summary>
        ///     Running GameMode identity (Id).
        /// </summary>
        Running = 2,

        /// <summary>
        ///     Paused GameMode identity (Id).
        /// </summary>
        Paused = 3,

        /// <summary>
        ///     Finished GameMode identity (Id).
        /// </summary>
        Finished = 4,

        /// <summary>
        ///     Exiting GameMode identity (Id).
        /// </summary>
        Exiting = 5
    }
}