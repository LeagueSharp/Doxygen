namespace LeagueSharp
{
    /// <summary>
    ///     GameObject class, contains relevent information for the base class of each object of the game.
    /// </summary>
    public class GameObject
    {
        /// <summary>
        ///     GameObject Constructor.
        /// </summary>
        /// <param name="index">GameObject index</param>
        /// <param name="networkId">Game Network identity (Id)</param>
        public GameObject(ushort index, uint networkId) {}

        /// <summary>
        ///     GameObject Constructor, no parameters.
        /// </summary>
        public GameObject() {}

        /// <summary>
        ///     Returns if the GameObject is valid.
        /// </summary>
        public bool IsValid
        {
            get { }
        }

        /// <summary>
        ///     Returns if the GameObject is me by Game Network identity (Id).
        /// </summary>
        public bool IsMe
        {
            get { }
        }

        /// <summary>
        ///     Returns if the GameObject is an enemy by team data.
        /// </summary>
        public bool IsEnemy
        {
            get { }
        }

        /// <summary>
        ///     Returns if the GameObject is an ally by team data.
        /// </summary>
        public bool IsAlly
        {
            get { }
        }

        /// <summary>
        ///     Game Network Identity (Id).
        /// </summary>
        public int NetworkId
        {
            get { }
        }

        /// <summary>
        ///     GameObject Bounding Box, object size.
        /// </summary>
        public BoundingBox BBox
        {
            get { }
        }

        /// <summary>
        ///     GameObject Flags.
        /// </summary>
        public int Flags
        {
            get { }
        }

        /// <summary>
        ///     GameObject Team data.
        /// </summary>
        public GameObjectTeam Team
        {
            get { }
        }

        /// <summary>
        ///     Returns if the GameObject is dead.
        /// </summary>
        public bool IsDead
        {
            get { }
        }

        /// <summary>
        ///     Returns if the GameObject is visible.
        /// </summary>
        public bool IsVisible
        {
            get { }
        }

        /// <summary>
        ///     Returns the GameObject's Bounding Radius (in float-units).
        /// </summary>
        public float BoundingRadius
        {
            get { }
        }

        /// <summary>
        ///     Returns the GameObject's Oreintation.
        /// </summary>
        public Vector3 Orientation
        {
            get { }
        }

        /// <summary>
        ///     Returns the GameObject's Position.
        /// </summary>
        public Vector3 Position
        {
            get { }
        }

        /// <summary>
        ///     Returns the GameObject's Type.
        /// </summary>
        public GameObjectType Type
        {
            get { }
        }

        /// <summary>
        ///     Returns the GameObject's Name.
        /// </summary>
        public string Name
        {
            get { }
        }

        /// <summary>
        ///     GameObject Event which is called when a property is changed.
        /// </summary>
        public static event GameObjectPropertyChange OnPropertyChange;

        /// ///
        /// <summary>
        ///     GameObject Event which is called when an existing GameObject is deleted.
        /// </summary>
        public static event GameObjectDelete OnDelete;

        /// <summary>
        ///     GameObject Event which is called when a new GameObject is created.
        /// </summary>
        public static event GameObjectCreate OnCreate;

        /// <summary>
        ///     Returns a simplified message which contains data about the GameObject.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {}
    }
}