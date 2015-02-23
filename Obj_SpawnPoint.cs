namespace LeagueSharp
{
    /// <summary>
    ///     Gets the points where players spawn.
    /// </summary>
  public class Obj_SpawnPoint : Obj_Building
  {
    public Obj_SpawnPoint(ushort index, uint networkId)
      : base(index, networkId)
    {
    }

    public Obj_SpawnPoint()
    {
    }
  }
}
