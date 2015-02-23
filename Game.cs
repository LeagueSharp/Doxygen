using LeagueSharp.Native;
using SharpDX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace LeagueSharp
{
    /// <summary>
    ///     Game class, contains information about the current game and gameserver.
    /// </summary>
    public sealed class Game
    {
        /// <summary>
        ///     Returns the game region.
        /// </summary>
        public static string Region
        {
            get { }
        }

        /// <summary>
        ///     Returns the game id.
        /// </summary>
        public static long Id
        {
            get { }
        }

        /// <summary>
        ///     Returns the gamerserver game map identity (ID).
        /// </summary>
        public static GameMapId MapId
        {
            get { }
        }

        /// <summary>
        ///     Returns the gameserver game type.
        /// </summary>
        public static GameType Type
        {
            get { }
        }

        /// <summary>
        ///     Returns the gameserver version.
        /// </summary>
        public static string Version
        {
            get { }
        }

        /// <summary>
        ///     Returns the real ingame clock time.
        /// </summary>
        public static float ClockTime
        {
            get { }
        }

        /// <summary>
        ///     Returns the gameserver port.
        /// </summary>
        public static string IP
        {
            get { }
        }

        /// <summary>
        ///     Returns the gameserver port.
        /// </summary>
        public static int Port
        {
            get { }
        }

        /// <summary>
        ///     Returns the ping.
        /// </summary>
        public static int Ping
        {
            get { }
        }

        /// <summary>
        ///     Returns the 3D cursor position.
        /// </summary>
        public static Vector3 CursorPos
        {
            get { }
        }

        /// <summary>
        ///     Returns the current game mode.
        /// </summary>
        public static GameMode Mode
        {
            get { }
        }

        /// <summary>
        ///     Returns the ingame time that is used for spelltimers.
        /// </summary>
        public static float Time
        {
            get { }
        }

        /// <summary>
        ///     This event is fired when trying to use the chat input.
        /// </summary>
        public static event GameInput OnGameInput;

        /// <summary>
        ///     This event is fired when the game ends.
        /// </summary>
        public static event GameNotifyEvent OnGameNotifyEvent;

        /// <summary>
        ///     This event is fired when the game ends.
        /// </summary>
        public static event GameEnd OnGameEnd;

        /// <summary>
        ///     This event is fired when the game starts.
        /// </summary>
        public static event GameStart OnGameStart;

        /// <summary>
        ///     This event is fired every a packet is about to be sent.
        /// </summary>
        public static event GameSendPacket OnGameSendPacket;

        /// <summary>
        ///     This event is fired every a packet is received and about to be processed by LoL.
        /// </summary>
        public static event GameProcessPacket OnGameProcessPacket;

        /// <summary>
        ///     This event is fired every time the game updates.
        /// </summary>
        public static event GameUpdate OnGameUpdate;

        /// <summary>
        ///     This event is fired when a window event is being processed. To prevent the game from processing
        ///     a event, you can set process to false. <see cref="T:LeagueSharp.WndEventArgs" />.
        /// </summary>
        public static event WndProc OnWndProc;

        /// <summary>
        ///     Prints text into the game chat.
        /// </summary>
        public static void PrintChat(string format, params object[] @params) {}

        /// <summary>
        ///     Prints text into the game chat.
        /// </summary>
        public static void PrintChat(string format) {}

        /// <summary>
        ///     Executes a chat command.
        /// </summary>
        public static void Say(string format) {}

        /// <summary>
        ///     Executes a chat command.
        /// </summary>
        public static void Say(string format, params object[] @params) {}

        /// <summary>
        ///      Send a packet to the gameserver.
        /// </summary>
        /// <param name="packetData">Packet Data</param>
        /// <param name="channel">Packet Channel</param>
        /// <param name="flag">Packet Protocol Flag</param>
        public static void SendPacket(byte[] packetData, PacketChannel channel, PacketProtocolFlags flag) {}

        /// <summary>
        ///     Processes a packet.
        /// </summary>
        /// <param name="packetData">PacketData</param>
        /// <param name="channel">Packet Channel</param>
        public static void ProcessPacket(byte[] packetData, PacketChannel channel) {}
    }
}