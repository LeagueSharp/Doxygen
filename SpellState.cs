namespace LeagueSharp
{
  /// <summary>
  /// This enum defines the different states a <see cref="T:LeagueSharp.SpellDataInst"/> can have.
  /// 
  /// </summary>
  public enum SpellState
  {
    Ready = 0,
    NotLearned = 2,
    Surpressed = 3,
    Cooldown = 4,
    NoMana = 5,
    Unknown = 10,
  }
}
