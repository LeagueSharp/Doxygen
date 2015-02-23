using \u003CCppImplementationDetails\u003E;
using LeagueSharp.Native;
using SharpDX;
using std;
using System;
using System.Collections.Generic;

namespace LeagueSharp
{
    /// <summary>
    ///     Generic skillshot
    /// </summary>
  public class Obj_SpellMissile : GameObject
  {
    public GameObject Target
    {
      get
      {
      }
    }

    public Vector3 EndPosition
    {
    }

    public Vector3 StartPosition
    {
    }

    public Obj_AI_Base SpellCaster
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

    public Obj_SpellMissile(ushort index, uint networkId)
      : base(index, networkId)
    {
    }

    public Obj_SpellMissile()
    {
    }
  }
}
