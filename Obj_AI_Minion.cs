using LeagueSharp.Native;
using SharpDX;
using System;

namespace LeagueSharp
{
  public class Obj_AI_Minion : Obj_AI_Base
  {
    public int MinionLevel
    {
      get
      {
      }
    }

    public Vector3 LeashedPosition
    {
      get
      {
      }
    }

    public int CampNumber
    {
      get
      {
      }
    }

    public int OriginalState
    {
      get
      {
      }
    }

    public int RoamState
    {
      get
      {
      }
    }

    public Obj_AI_Minion(ushort index, uint networkId)
      : base(index, networkId)
    {
    }

    public Obj_AI_Minion()
    {
    }
  }
}
