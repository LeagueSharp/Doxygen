namespace LeagueSharp
{
    /// <summary>
    ///     Delegate which is routed through the game event call to subscribed event.
    /// </summary>
    /// <param name="args">Game End Data, <see cref="GameEndEventArgs" /></param>
    public delegate void GameEnd(GameEndEventArgs args);
}