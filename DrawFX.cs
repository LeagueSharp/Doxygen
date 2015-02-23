namespace LeagueSharp
{
    /// <summary>
    ///     Draw Visual Effects (FX) class, a game object that is assigned to visual effects.
    /// </summary>
    public class DrawFX : GameObject
    {
        /// <summary>
        ///     DrawFX constructor
        /// </summary>
        /// <param name="index">Visual Effects Index</param>
        /// <param name="networkId">Game Network Identity (ID)</param>
        public DrawFX(ushort index, uint networkId) : base(index, networkId) {}

        /// <summary>
        ///     DrawFX constructor without parameters (null)
        /// </summary>
        public DrawFX() {}
    }
}