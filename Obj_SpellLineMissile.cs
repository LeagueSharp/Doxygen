using \u003CCppImplementationDetails\u003E;
using LeagueSharp.Native;
using System;

namespace LeagueSharp
{
    /// <summary>
    ///     A skillshot
    /// </summary>
  public class Obj_SpellLineMissile : Obj_SpellMissile
  {
    public Obj_SpellLineMissile(ushort index, uint networkId)
      : base(index, networkId)
    {
    }

    public Obj_SpellLineMissile()
    {
    }

    public void SendStandardPacket(int networkId)
    {
    }
  }
}
