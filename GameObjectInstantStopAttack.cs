namespace LeagueSharp
{
    /// <summary>
    ///     GameObjectDelete delegate, passes a call to all subscribed events with a GameObject sender and System.EventArgs,
    ///     indicating an instant stop attack by a GameObject.
    /// </summary>
    /// <param name="sender">GameObject sender, <see cref="GameObject" /></param>
    /// <param name="args">GameObjectInstantStopAttackEventArgs, <see cref="GameObjectInstantStopAttackEventArgs" /></param>
    public delegate void GameObjectInstantStopAttack(Obj_AI_Base sender, GameObjectInstantStopAttackEventArgs args);
}