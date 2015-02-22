using LeagueSharp.Native;
using std;
using System;

namespace LeagueSharp
{
  /// <summary>
  /// Defines a BuffInstance
  /// 
  /// </summary>
  public class BuffInstance
  {
    public GameObject Caster
    {
      get
      {
      }
    }

    public string SourceName
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets the internal name of the buff
    /// 
    /// </summary>
    public string Name
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets the display name of the buff, e.g. for tooltips
    /// 
    /// </summary>
    public string DisplayName
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets the time when the buff will run out
    /// 
    /// </summary>
    public float EndTime
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns the starting time of the buff.
    /// 
    /// </summary>
    public float StartTime
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns true if the buff is having positive effect
    /// 
    /// </summary>
    public bool IsPositive
    {
      get
      {
      }
    }

    /// <summary>
    /// Returns true if a buff is still active
    /// 
    /// </summary>
    public bool IsActive
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets the stack count
    /// 
    /// </summary>
    public int Count
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets the type of the Buff
    /// 
    /// </summary>
    public BuffType Type
    {
      get
      {
      }
    }

    internal BuffInstance(uint m_networkId, uint index)
    {
    }
  }
}
