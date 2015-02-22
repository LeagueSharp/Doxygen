using SharpDX;
using System;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public class GameObjectIssueOrderEventArgs : EventArgs
  {
    public bool IsAttackMove
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

    public Vector3 TargetPosition
    {
      get
      {
      }
    }

    public GameObjectOrder Order
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

    public GameObjectIssueOrderEventArgs(int process, GameObjectOrder order, Vector3 targetPosition, GameObject target, [MarshalAs(UnmanagedType.U1)] bool attackMove)
    {
    }
  }
}
