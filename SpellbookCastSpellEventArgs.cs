using SharpDX;
using System;

namespace LeagueSharp
{
  public class SpellbookCastSpellEventArgs : EventArgs
  {
    public SpellSlot Slot
    {
      get
      {
      }
    }

    public GameObject Target
    {
      get
      {
      }
    }

    public Vector3 EndPosition
    {
      get
      {
      }
    }

    public Vector3 StartPosition
    {
      get
      {
      }
    }

    public bool Process
    {
      get
      {
      }
      set
      {
      }
    }

    public SpellbookCastSpellEventArgs(int process, Vector3 startPos, Vector3 endPos, GameObject target, SpellSlot spellSlot)
    {
    }
  }
}
