using System;

namespace LeagueSharp
{
    /// <summary>
    ///     GameObjectCreate delegate, passes a call to all subscribed events with a GameObject sender and System.EventArgs,
    ///     indicating a GameObject creation.
    /// </summary>
    /// <param name="sender">GameObject sender, <see cref="GameObject"/></param>
    /// <param name="args">System.EventArgs</param>
    public delegate void GameObjectCreate(GameObject sender, EventArgs args);
}