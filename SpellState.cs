namespace LeagueSharp
{
  /// <summary>
  /// This enum defines the different states a <see cref="T:LeagueSharp.SpellDataInst"/> can have.
  /// 
  /// </summary>
  public enum SpellState
  {
    /// <summary>
    /// Ready to be used.
    /// </summary>
    Ready = 0,

    /// <summary>
    /// Not level up yet.
    /// </summary>
    NotLearned = 2,

    /// <summary>
    /// Spell surpressed
    /// </summary>
    Surpressed = 3,

    /// <summary>
    /// On Cooldown
    /// </summary>
    Cooldown = 4,

    /// <summary>
    /// Not enough mana to cast the spell.
    /// </summary>
    NoMana = 5,

    /// <summary>
    /// Unknown
    /// </summary>
    Unknown = 10,
  }
}
