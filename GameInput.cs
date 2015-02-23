namespace LeagueSharp
{
    /// <summary>
    ///     GameInput delegate, passes a call to all subscribed events with Game Input Event Arguments on a chat input.
    /// </summary>
    /// <param name="args">Game Input Event Arguments, <see cref="GameInputEventArgs"/></param>
    public delegate void GameInput(GameInputEventArgs args);
}