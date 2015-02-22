using SharpDX;
using System;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public class GameObjectNewPathEventArgs : EventArgs
  {
    public float Speed
    {
      get
      {
      }
    }

    public bool IsDash
    {
      get
      {
      }
    }

    public Vector3[] Path
    {
      get
      {
      }
    }

    public GameObjectNewPathEventArgs(Vector3[] newPath, [MarshalAs(UnmanagedType.U1)] bool isDash, float speed)
    {
    }
  }
}
