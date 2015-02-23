using System;

namespace LeagueSharp
{
    /// <summary>
    ///     GameObjectDelete delegate, passes a call to all subscribed events with a GameObject sender and System.EventArgs,
    ///     indicating a GameObject deletion.
    /// </summary>
    /// <param name="sender">GameObject sender, <see cref="GameObject"/></param>
    /// <param name="args">System.EventArgs</param>
    public delegate void GameObjectDelete(GameObject sender, EventArgs args);
}