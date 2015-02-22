using System;

namespace LeagueSharp
{
  public class GameNotifyEventArgs : EventArgs
  {
    public uint NetworkId
    {
      get
      {
      }
    }

    public GameEventId EventId
    {
      get
      {
      }
    }

    public GameNotifyEventArgs(GameEventId eventId, uint networkId)
    {
    }
  }
}
