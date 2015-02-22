using LeagueSharp.Native;
using SharpDX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace LeagueSharp
{
  /// <summary>
  /// This class offers game relevant stuff
  /// 
  /// </summary>
  public sealed class Game
  {

    public static string Region
    {
      get
      {
      }
    }

    public static long Id
    {
      get
      {
      }
    }

    public static GameMapId MapId
    {
      get
      {
      }
    }

    public static GameType Type
    {
      get
      {
      }
    }

    public static string Version
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the real ingame clock time.
    /// 
    /// </summary>
    public static float ClockTime
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the gameserver port.
    /// 
    /// </summary>
    public static string IP
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the gameserver port.
    /// 
    /// </summary>
    public static int Port
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the ping.
    /// 
    /// </summary>
    public static int Ping
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the 3D cursor position.
    /// 
    /// </summary>
    public static Vector3 CursorPos
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the current game mode.
    /// 
    /// </summary>
    public static GameMode Mode
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the ingame time that is used for spelltimers
    /// 
    /// </summary>
    public static float Time
    {
      get
      {
      }
    }

    /// <summary>
    /// This event is fired when trying to use the chat input.
    /// 
    /// </summary>
    public static event GameInput OnGameInput;

    /// <summary>
    /// This event is fired when the game ends
    /// 
    /// </summary>
    public static event GameNotifyEvent OnGameNotifyEvent;

    /// <summary>
    /// This event is fired when the game ends
    /// 
    /// </summary>
    public static event GameEnd OnGameEnd;

    /// <summary>
    /// This event is fired when the game starts
    /// 
    /// </summary>
    public static event GameStart OnGameStart;

    /// <summary>
    /// This event is fired every a packet is about to be sent
    /// 
    /// </summary>
    public static event GameSendPacket OnGameSendPacket;

    /// <summary>
    /// This event is fired every a packet is received and about to be processed by LoL
    /// 
    /// </summary>
    public static event GameProcessPacket OnGameProcessPacket;

    /// <summary>
    /// This event is fired every time the game updates.
    /// 
    /// </summary>
    public static event GameUpdate OnGameUpdate;

    /// <summary>
    /// This event is fired when a window event is being processed. To prevent the game from processing
    /// a event, you can set process to false. <see cref="T:LeagueSharp.WndEventArgs"/>.
    /// 
    /// </summary>
    public static event WndProc OnWndProc;

    static Game()
    {
    }

    /// <summary>
    /// Prints text into the game chat
    /// 
    /// </summary>
    public static void PrintChat(string format, params object[] @params)
    {
    }

    /// <summary>
    /// Prints text into the game chat
    /// 
    /// </summary>
    public static void PrintChat(string format)
    {
    }

    /// <summary>
    /// Executes a chat command
    /// 
    /// </summary>
    public static void Say(string format)
    {
    }

    /// <summary>
    /// Executes a chat command
    /// 
    /// </summary>
    public static void Say(string format, params object[] @params)
    {
    }

    public static void SendPacket(byte[] packetData, PacketChannel channel, PacketProtocolFlags flag)
    {
    }

    public static void ProcessPacket(byte[] packetData, PacketChannel channel)
    {
    }
  }
}
