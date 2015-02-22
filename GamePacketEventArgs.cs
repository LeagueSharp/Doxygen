using System;

namespace LeagueSharp
{
  public class GamePacketEventArgs : EventArgs
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

    public PacketChannel Channel
    {
      get
      {
      }
    }

    public PacketProtocolFlags ProtocolFlag
    {
      get
      {
      }
    }

    public byte[] PacketData
    {
      get
      {
      }
    }

    public GamePacketEventArgs(int process, byte[] packetData, PacketProtocolFlags flag, PacketChannel channel)
    {
    }
  }
}
