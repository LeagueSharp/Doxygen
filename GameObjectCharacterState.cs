using System;

namespace LeagueSharp
{
  [Flags]
  public enum GameObjectCharacterState
  {
    CanAttack = 1,
    CanCast = 2,
    CanMove = 4,
    Immovable = 8,
    RevealSpecificUnit = 32,
    Taunted = 64,
    Feared = 128,
    Fleeing = 256,
    Surpressed = 512,
    Asleep = 1024,
    NearSight = 2048,
    Ghosted = 4096,
    GhostProof = 8192,
    Charmed = 16384,
    NoRender = 32768,
    DodgePiercing = 131072,
    DisableAmbientGold = 262144,
    DisableAmbientXP = 524288,
    ForceRenderParticles = 65536,
  }
}
