using SharpDX;
using System;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public class SpellbookUpdateChargedSpellEventArgs : EventArgs
  {
    public bool Process
    {
      get
      {
      }
      set
      {
      }
    }

    public bool ReleaseCast
    {
      get
      {
      }
    }

    public Vector3 Position
    {
      get
      {
      }
    }

    public SpellSlot Slot
    {
      get
      {
      }
    }

    public SpellbookUpdateChargedSpellEventArgs(SpellSlot slot, Vector3 position, [MarshalAs(UnmanagedType.U1)] bool releaseCast, int process)
    {
    }
  }
}
