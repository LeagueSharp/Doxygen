using System;

namespace LeagueSharp
{
  public class WndEventArgs : EventArgs
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

    public int LParam
    {
      get
      {
      }
    }

    public uint WParam
    {
      get
      {
      }
    }

    public uint Msg
    {
      get
      {
      }
    }

    public HWND__* HWnd
    {
      get
      {
      }
    }

    public WndEventArgs(int process, HWND__* hwnd, uint msg, uint wparam, int lparam)
    {
    }
  }
}
