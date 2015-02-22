using System;

namespace LeagueSharp
{
  public class GameObjectTeleportEventArgs : EventArgs
  {
    public string RecallName
    {
      get
      {
      }
    }

    public string RecallType
    {
      get
      {
      }
    }

    public GameObjectTeleportEventArgs(sbyte* recallType, sbyte* recallName)
    {
    }
  }
}
