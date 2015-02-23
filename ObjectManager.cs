using LeagueSharp.Native;
using System;
using System.Collections.Generic;

namespace LeagueSharp
{
    /// <summary>
    ///     Manages all of the objects in the League of Legends world.
    /// </summary>
  public static class ObjectManager
  {
    public static Obj_AI_Hero Player
    {
      get
      {
      }
    }

      /// <summary>
      ///   Gets all of the objects by their type.
      /// </summary>
      /// <typeparam name="ObjectType">Type of object to get</typeparam>
      /// <returns>IEnumerable with all of the objects.</returns>
    public static IEnumerable<ObjectType> Get<ObjectType>() where ObjectType : GameObject, new()
    {
    }

      /// <summary>
      ///   Gets an object by its network ID.
      /// </summary>
      /// <typeparam name="ObjectType">Type of object to get</typeparam>
      /// <param name="networkId">Network ID</param>
      /// <returns>The object that has that network ID</returns>
    public static ObjectType GetUnitByNetworkId<ObjectType>(int networkId) where ObjectType : GameObject, new()
    {
    }
  }
}
