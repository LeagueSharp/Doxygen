using System;

namespace LeagueSharp
{
  public class GameObjectPropertyChangeEventArgs : EventArgs
  {
    public float NewValue
    {
      get
      {
      }
    }

    public float OldValue
    {
      get
      {
      }
    }

    public string Property
    {
      get
      {
      }
    }

    public GameObjectPropertyChangeEventArgs(string prop, float oldValue, float newValue)
    {
    }
  }
}
