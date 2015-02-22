using LeagueSharp.Native;
using System;
using System.Collections.Generic;

namespace LeagueSharp
{
  public static class ObjectManager
  {
    public static Obj_AI_Hero Player
    {
      get
      {
      }
    }

    public static IEnumerable<ObjectType> Get<ObjectType>() where ObjectType : GameObject, new()
    {
    }

    public static ObjectType GetUnitByNetworkId<ObjectType>(int networkId) where ObjectType : GameObject, new()
    {
    }
  }
}
