using System;

namespace LeagueSharp
{
  /// <summary>
  /// Spells can have different flags. This enum defines those.
  /// 
  /// </summary>
  [Flags]
  public enum SpellFlags
  {
    Autocast = 2,
    Instacast = 4,
    PersistThroughDeath = 8,
    NonDispellable = 16,
    AffectImportantBotTargets = 64,
    AllowWhileTaunted = 128,
    AffectUntargetable = 512,
    AffectEnemies = 1024,
    AffectFriends = 2048,
    AffectBuildings = 4096,
    NotAffectSelf = 8192,
    AffectNeutral = 16384,
    AffectMinions = 32768,
    AffectHeroes = 65536,
    AffectTurrets = 131072,
    AlwaysSelf = 262144,
    AffectDead = 524288,
    AffectNotPet = 1048576,
    AffectBarrackOnly = 2097152,
    NonTargetableAlly = 8388608,
  }
}
