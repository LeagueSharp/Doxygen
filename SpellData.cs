using LeagueSharp.Native;
using std;
using System;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  /// <summary>
  /// This class defines static information on a given spell. This information usually doesn't change as the game progresses.
  /// Use this for spellshot calculations and so on.
  /// 
  /// </summary>
  public class SpellData
  {
    public float LineWidth
    {
      get
      {
      }
    }

    public float MissileSpeed
    {
      get
      {
      }
    }

    public float CastFrame
    {
      get
      {
      }
    }

    public float SpellCastTime
    {
      get
      {
      }
    }

    public float SpellTotalTime
    {
      get
      {
      }
    }

    public float[] CastRadiusSecondary
    {
      get
      {
      }
    }

    public float[] CastRangeDisplayOverride
    {
      get
      {
      }
    }

    public float[] CastRadius
    {
      get
      {
      }
    }

    public float[] CastRange
    {
      get
      {
      }
    }

    public uint Hash
    {
      get
      {
      }
    }

    public string Name
    {
      get
      {
      }
    }
	
    public static SpellData GetSpellData(uint hash)
    {
    }

    public static SpellData GetSpellData(string spellName)
    {
    }
  }
}
