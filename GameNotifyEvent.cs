namespace LeagueSharp
{
    /// <summary>
    ///     GameNotifyEvent delegate, passes a call to all subscribed events with Game Notify Event Arguments on a game
    ///     event notification call.
    /// </summary>
    /// <param name="args">Game Notify Event Arguments, <see cref="GameNotifyEventArgs" /></param>
    public delegate void GameNotifyEvent(GameNotifyEventArgs args);
}