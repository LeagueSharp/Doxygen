using \u003CCppImplementationDetails\u003E;
using LeagueSharp.Native;
using SharpDX;
using System;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public static class NavMesh
  {
    /// <summary>
    /// Returns the height of the NavMesh
    /// 
    /// </summary>
    public static short Height
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the width of the NavMesh
    /// 
    /// </summary>
    public static short Width
    {
      get
      {
      }
    }

    /// <summary>
    /// Checks if you have line of sight from A to B
    /// 
    /// </summary>
    [return: MarshalAs(UnmanagedType.U1)]
    public static bool LineOfSightTest(Vector3 start, Vector3 end, out Vector3 collision)
    {
   
    }

    /// <summary>
    /// Checks if you have line of sight from A to B
    /// 
    /// </summary>
    [return: MarshalAs(UnmanagedType.U1)]
    public static bool LineOfSightTest(Vector3 start, Vector3 end)
    {
    }

    /// <summary>
    /// Checks if there is a wall of grass at the given position.
    /// 
    /// </summary>
    [return: MarshalAs(UnmanagedType.U1)]
    public static bool IsWallOfGrass(float x, float y, float radius)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public static bool IsWallOfGrass(Vector3 position, float radius)
    {
    }

    /// <summary>
    /// Returns the Z axis for the given position
    /// 
    /// </summary>
    public static float GetHeightForPosition(float x, float y)
    {
    }

    /// <summary>
    /// Returns the Collision Flags for the given coordinates.
    /// 
    /// </summary>
    public static CollisionFlags GetCollisionFlags(float x, float y)
    {
    }

    /// <summary>
    /// Returns the Collision Flags for the given coordinates.
    /// 
    /// </summary>
    public static CollisionFlags GetCollisionFlags(Vector3 position)
    {
    }

    public static NavMeshCell GetCell(short x, short y)
    {
    }

    public static Vector3 GridToWorld(short x, short y)
    {
    }

    public static Vector2 WorldToGrid(float x, float y)
    {
    }
  }
}
