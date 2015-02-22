using LeagueSharp.Native;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  /// <summary>
  /// This class represents a spellbook of a LoL unit.
  /// 
  /// </summary>
  public class Spellbook
  {
   
    public bool IsStopped
    {
      get
      {
      }
    }

    public float CastEndTime
    {
      get
      {
      }
    }

    public float CastTime
    {
      get
      {
      }
    }

    public bool SpellWasCast
    {
      get
      {
      }
    }

    public bool IsChanneling
    {
      get
      {
      }
    }

    public bool IsCharging
    {
      get
      {
      }
    }

    public bool IsAutoAttacking
    {
      get
      {
      }
    }

    public bool HasSpellCaster
    {
      get
      {
	  }
    }

    public Obj_AI_Base Owner
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets a array of all Spells defined in the Spellbook
    /// 
    /// </summary>
    public SpellDataInst[] Spells
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets the active spell
    /// 
    /// </summary>
    public SpellSlot ActiveSpellSlot
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets the selected spell
    /// 
    /// </summary>
    public SpellSlot SelectedSpellSlot
    {
      get
      {
      }
    }

    /// <summary>
    /// Gets if a spell is being casted currently.
    /// 
    /// </summary>
    public bool IsCastingSpell
    {
      get
      {
      }
    }

    public static event SpellbookUpdateChargedSpell OnUpdateChargedSpell;

    public static event SpellbookStopCast OnStopCast;

    public static event SpellbookCastSpell OnCastSpell;

    static Spellbook()
    {
	}

    internal Spellbook(uint networkId, [MarshalAs(UnmanagedType.U1)] bool summonerSpellbook)
    {
    }

    internal LeagueSharp.Native.Spellbook* GetSpellBook()
    {
    }

    internal static void DomainUnloadEventHandler(object sender, EventArgs e)
    {
    }

    internal static void OnCastSpellNative(LeagueSharp.Native.GameObject* caster, Vector3f* startPos, Vector3f* endPos, uint targetNetworkId, int* process)
    {
    }

    internal static void OnStopCastNative(LeagueSharp.Native.GameObject* caster, [MarshalAs(UnmanagedType.U1)] bool stopAnimation, [MarshalAs(UnmanagedType.U1)] bool executeCastFrame, [MarshalAs(UnmanagedType.U1)] bool forceStop, [MarshalAs(UnmanagedType.U1)] bool destroyMissile, int missileNetworkId, int unk)
    {
    }

    internal static void OnUpdateChargedSpellNative(LeagueSharp.Native.GameObject* caster, int slot, Vector3f* pos, [MarshalAs(UnmanagedType.U1)] bool releaseCast, int* process)
    {
    }

    /// <summary>
    /// Gets a specified Spell
    /// 
    /// </summary>
    public SpellDataInst GetSpell(SpellSlot slot)
    {
    }

    /// <summary>
    /// Gets the <see cref="T:LeagueSharp.SpellState"/> of the given spellslot.
    /// 
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:LeagueSharp.SpellState"/> of the given spellslot.
    /// </returns>
    public SpellState CanUseSpell(SpellSlot slot)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot, [MarshalAs(UnmanagedType.U1)] bool triggerEvent)
    {
     }

    /// <summary>
    /// Casts a spell
    /// 
    /// </summary>
    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot)
    {
     }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot, GameObject target, [MarshalAs(UnmanagedType.U1)] bool triggerEvent)
    {
    }

    /// <summary>
    /// Casts a spell on the given unit
    /// 
    /// </summary>
    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot, GameObject target)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot, Vector3 startPosition, Vector3 endPosition, [MarshalAs(UnmanagedType.U1)] bool triggerEvent)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot, Vector3 startPosition, Vector3 endPosition)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot, Vector3 position, [MarshalAs(UnmanagedType.U1)] bool triggerEvent)
    {
    }

    /// <summary>
    /// Casts a spell at the given position
    /// 
    /// </summary>
    [return: MarshalAs(UnmanagedType.U1)]
    public bool CastSpell(SpellSlot slot, Vector3 position)
    {
	}

    [return: MarshalAs(UnmanagedType.U1)]
    public bool UpdateChargedSpell(SpellSlot slot, Vector3 position, [MarshalAs(UnmanagedType.U1)] bool releaseCast, [MarshalAs(UnmanagedType.U1)] bool triggerEvent)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool UpdateChargedSpell(SpellSlot slot, Vector3 position, [MarshalAs(UnmanagedType.U1)] bool releaseCast)
    {
    }

    public void LevelSpell(SpellSlot slot)
    {
    }

    public void EvolveSpell(SpellSlot slot)
    {
	}

    [SpecialName]
    protected static void raise_OnCastSpell(Spellbook value0, SpellbookCastSpellEventArgs value1)
    {
    }

    [SpecialName]
    protected static void raise_OnStopCast(Spellbook value0, SpellbookStopCastEventArgs value1)
    {
    }

    [SpecialName]
    protected static void raise_OnUpdateChargedSpell(Spellbook value0, SpellbookUpdateChargedSpellEventArgs value1)
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void OnCastSpellNativeDelegate(LeagueSharp.Native.GameObject* caster, Vector3f* startPos, Vector3f* endPos, uint targetNetworkId, int* process);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void OnStopCastNativeDelegate(LeagueSharp.Native.GameObject* caster, [MarshalAs(UnmanagedType.U1)] bool stopAnimation, [MarshalAs(UnmanagedType.U1)] bool executeCastFrame, [MarshalAs(UnmanagedType.U1)] bool forceStop, [MarshalAs(UnmanagedType.U1)] bool destroyMissile, int missileNetworkId, int unk);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate void OnUpdateChargedSpellNativeDelegate(LeagueSharp.Native.GameObject* caster, int slot, Vector3f* pos, [MarshalAs(UnmanagedType.U1)] bool releaseSpell, int* process);
  }
}
