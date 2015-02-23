using System;

namespace LeagueSharp
{
    /// <summary>
    ///     Game Input Event Arguments, contains input information and execution flag for game input event.
    /// </summary>
    public class GameInputEventArgs : EventArgs
    {
        /// <summary>
        ///     Game Input Event Arguments Constructor
        /// </summary>
        /// <param name="process">Process Input (Execution Flag)</param>
        /// <param name="input">Input Information (string)</param>
        public GameInputEventArgs(int process, string input) {}

        /// <summary>
        ///     Process Input (Execution Flag), can be set to execute or not the current input infromation by the client.
        /// </summary>
        public bool Process
        {
            get { }
            set { }
        }

        /// <summary>
        ///     Input Information (string), input string that was set to be sent as execution by the client.
        /// </summary>
        public string Input
        {
            get { }
        }
    }
}