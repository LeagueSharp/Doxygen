namespace LeagueSharp
{
    /// <summary>
    ///     FollowerObject is used to define a game object of an object that will follow a different set object.
    /// </summary>
    public class FollowerObject : GameObject
    {
        /// <summary>
        ///     FollowerObject constructor
        /// </summary>
        /// <param name="index">Object Index</param>
        /// <param name="networkId">Game Network Identity (ID)</param>
        public FollowerObject(ushort index, uint networkId) : base(index, networkId) {}

        /// <summary>
        ///     FollowerObject constructor without parameters (null)
        /// </summary>
        public FollowerObject() {}
    }
}