using System;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public class SpellbookStopCastEventArgs : EventArgs
  {
    public int Unk
    {
      get
      {
      }
    }

    public int MissileNetworkId
    {
      get
      {
      }
    }

    public bool DestroyMissile
    {
      get
      {
      }
    }

    public bool ForceStop
    {
      get
      {
      }
    }

    public bool ExecuteCastFrame
    {
      get
      {
      }
    }

    public bool StopAnimation
    {
      get
      {
      }
    }

    public SpellbookStopCastEventArgs([MarshalAs(UnmanagedType.U1)] bool stopAnimation, [MarshalAs(UnmanagedType.U1)] bool executeCastFrame, [MarshalAs(UnmanagedType.U1)] bool forceStop, [MarshalAs(UnmanagedType.U1)] bool destroyMissile, int missileNetworkId, int unk)
    {
    }
  }
}
