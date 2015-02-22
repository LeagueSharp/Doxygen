using System;

namespace LeagueSharp
{
  public class GameEndEventArgs : EventArgs
  {
    public GameObjectTeam WinningTeam
    {
      get
      {
      }
    }

    public GameEndEventArgs(GameObjectTeam winningTeam)
    {
    }
  }
}
