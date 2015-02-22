using SharpDX;
using System;

namespace LeagueSharp
{
  public class GameObjectProcessSpellCastEventArgs : EventArgs
  {
    public GameObject Target
    {
      get
      {
      }
    }

    public float TimeTillPlayAnimation
    {
      get
      {
      }
    }

    public float ExtraTimeForCast
    {
      get
      {
      }
    }

    public float AnimateCast
    {
      get
      {
      }
    }

    public float TimeCast
    {
      get
      {
      }
    }

    public float TimeSpellEnd
    {
      get
      {
      }
    }

    public Vector3 End
    {
      get
      {
      }
    }

    public Vector3 Start
    {
      get
      {
      }
    }

    public int Level
    {
      get
      {
      }
    }

    public SpellData SData
    {
      get
      {
      }
    }

    public GameObjectProcessSpellCastEventArgs(SpellData sdata, int level, Vector3 start, Vector3 end, float timeSpellEnd, float timeCast, float animateCast, float extraTimeForCast, float timeTillPlayAnimation, uint targetLocalId)
    {
    }
  }
}
