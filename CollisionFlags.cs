using System;

namespace LeagueSharp
{
  [Flags]
  public enum CollisionFlags : ushort
  {
    None = (ushort) 0,
    Grass = (ushort) 1,
    Wall = (ushort) 2,
    Building = (ushort) 64,
    Prop = (ushort) 128,
  }
}
