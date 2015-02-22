using \u003CCppImplementationDetails\u003E;
using LeagueSharp.Native;
using SharpDX;
using std;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public class Obj_AI_Base : AttackableUnit
  {
    public float PercentLocalGoldRewardMod
    {
      get
      {
      }
    }

    public float FlatGoldRewardMod
    {
      get
      {
      }
    }

    public float FlatExpRewardMod
    {
      get
      {
      }
    }

    public float PathfindingRadiusMod
    {
      get
      {
      }
    }

    public float AcquisitionRangeMod
    {
      get
      {
      }
    }

    public float _NonHealingFlatHPPoolMod
    {
      get
      {
      }
    }

    public float _PercentMagicPenetrationModPerLevel
    {
      get
      {
      }
    }

    public float _PercentMagicPenetrationMod
    {
      get
      {
      }
    }

    public float _FlatMagicPenetrationModPerLevel
    {
      get
      {
      }
    }

    public float _FlatMagicPenetrationMod
    {
      get
      {
      }
    }

    public float FlatGoldPer10Mod
    {
      get
      {
      }
    }

    public float _PercentTimeDeadModPerLevel
    {
      get
      {
      }
    }

    public float _PercentTimeDeadMod
    {
      get
      {
      }
    }

    public float _FlatTimeDeadModPerLevel
    {
      get
      {
      }
    }

    public float _FlatTimeDeadMod
    {
      get
      {
      }
    }

    public float _PercentCooldownModPerLevel
    {
      get
      {
      }
    }

    public float _PercentCooldownMod
    {
      get
      {
      }
    }

    public float _PercentArmorPenetrationModPerLevel
    {
      get
      {
      }
    }

    public float _PercentArmorPenetrationMod
    {
      get
      {
      }
    }

    public float _FlatArmorPenetrationModPerLevel
    {
      get
      {
      }
    }

    public float _FlatArmorPenetrationMod
    {
      get
      {
      }
    }

    public float _FlatDodgeModPerLevel
    {
      get
      {
      }
    }

    public float _FlatDodgeMod
    {
      get
      {
      }
    }

    public float _FlatCritDamageModPerLevel
    {
      get
      {
      }
    }

    public float _FlatCritChanceModPerLevel
    {
      get
      {
      }
    }

    public float _PercentAttackSpeedModPerLevel
    {
      get
      {
      }
    }

    public float _PercentMovementSpeedModPerLevel
    {
      get
      {
      }
    }

    public float _FlatMovementSpeedModPerLevel
    {
      get
      {
      }
    }

    public float _FlatMagicDamageModPerLevel
    {
      get
      {
      }
    }

    public float _FlatPhysicalDamageModPerLevel
    {
      get
      {
      }
    }

    public float _FlatMPRegenModPerLevel
    {
      get
      {
      }
    }

    public float _FlatHPRegenModPerLevel
    {
      get
      {
      }
    }

    public float _FlatSpellBlockModPerLevel
    {
      get
      {
      }
    }

    public float _FlatArmorModPerLevel
    {
      get
      {
      }
    }

    public float _FlatMPModPerLevel
    {
      get
      {
      }
    }

    public float _FlatHPModPerLevel
    {
      get
      {
      }
    }

    public float PercentBubbleRadiusMod
    {
      get
      {
      }
    }

    public float FlatBubbleRadiusMod
    {
      get
      {
      }
    }

    public float CastRange
    {
      get
      {
      }
    }

    public float AttackRange
    {
      get
      {
      }
    }

    public float MoveSpeed
    {
      get
      {
      }
    }

    public float PARRegenRate
    {
      get
      {
      }
    }

    public float PercentBasePARRegenMod
    {
      get
      {
      }
    }

    public float BasePARRegenRate
    {
      get
      {
      }
    }

    public float HPRegenRate
    {
      get
      {
      }
    }

    public float SpellBlock
    {
      get
      {
      }
    }

    public float Armor
    {
      get
      {
      }
    }

    public float Crit
    {
      get
      {
      }
    }

    public float Dodge
    {
      get
      {
      }
    }

    public float MissChance
    {
      get
      {
      }
    }

    public float ScaleSkinCoef
    {
      get
      {
      }
    }

    public float CritDamageMultiplier
    {
      get
      {
      }
    }

    public float BaseAbilityDamage
    {
      get
      {
      }
    }

    public float BaseAttackDamage
    {
      get
      {
      }
    }

    public float AttackSpeedMod
    {
      get
      {
      }
    }

    public float PercentGoldLostOnDeathMod
    {
      get
      {
      }
    }

    public float PercentRespawnTimeMod
    {
      get
      {
      }
    }

    public float PercentSpellVampMod
    {
      get
      {
      }
    }

    public float PercentLifeStealMod
    {
      get
      {
      }
    }

    public float PercentHealingAmountMod
    {
      get
      {
      }
    }

    public float PercentMultiplicativeAttackSpeedMod
    {
      get
      {
      }
    }

    public float PercentAttackSpeedMod
    {
      get
      {
      }
    }

    public float PercentCastRangeMod
    {
      get
      {
      }
    }

    public float FlatCastRangeMod
    {
      get
      {
      }
    }

    public float PercentAttackRangeMod
    {
      get
      {
      }
    }

    public float FlatAttackRangeMod
    {
      get
      {
      }
    }

    public float PercentEXPBonus
    {
      get
      {
      }
    }

    public float PercentMagicReduction
    {
      get
      {
      }
    }

    public float FlatMagicReduction
    {
      get
      {
      }
    }

    public float PercentPhysicalReduction
    {
      get
      {
      }
    }

    public float FlatPhysicalReduction
    {
      get
      {
      }
    }

    public float PercentMagicDamageMod
    {
      get
      {
      }
    }

    public float FlatMagicDamageMod
    {
      get
      {
      }
    }

    public float PercentPhysicalDamageMod
    {
      get
      {
      }
    }

    public float FlatPhysicalDamageMod
    {
      get
      {
      }
    }

    public float PercentCritDamageMod
    {
      get
      {
      }
    }

    public float FlatCritDamageMod
    {
      get
      {
      }
    }

    public float FlatCritChanceMod
    {
      get
      {
      }
    }

    public float FlatDodgeMod
    {
      get
      {
      }
    }

    public float FlatMissChanceMod
    {
      get
      {
      }
    }

    public float PercentSpellBlockMod
    {
      get
      {
        return *\u003CModule\u003E.LeagueSharp\u002ENative\u002ECharacterIntermediate\u002EGetPercentSpellBlockMod(\u003CModule\u003E.LeagueSharp\u002ENative\u002Eobj_AI_Base\u002EGetCharIntermediate((obj_AI_Base*) this.GetPtr()));
      }
    }

    public float FlatSpellBlockMod
    {
      get
      {
        return *\u003CModule\u003E.LeagueSharp\u002ENative\u002ECharacterIntermediate\u002EGetFlatSpellBlockMod(\u003CModule\u003E.LeagueSharp\u002ENative\u002Eobj_AI_Base\u002EGetCharIntermediate((obj_AI_Base*) this.GetPtr()));
      }
    }

    public float PercentBonusMagicPenetrationMod
    {
      get
      {
        return *\u003CModule\u003E.LeagueSharp\u002ENative\u002ECharacterIntermediate\u002EGetPercentBonusMagicPenetrationMod(\u003CModule\u003E.LeagueSharp\u002ENative\u002Eobj_AI_Base\u002EGetCharIntermediate((obj_AI_Base*) this.GetPtr()));
      }
    }

    public float PercentMagicPenetrationMod
    {
      get
      {
      }
    }

    public float FlatMagicPenetrationMod
    {
      get
      {
      }
    }

    public float PercentBonusArmorPenetrationMod
    {
      get
      {
      }
    }

    public float PercentArmorPenetrationMod
    {
      get
      {
      }
    }

    public float FlatArmorPenetrationMod
    {
      get
      {
      }
    }

    public float PercentArmorMod
    {
      get
      {
      }
    }

    public float FlatArmorMod
    {
      get
      {
      }
    }

    public float MoveSpeedFloorMod
    {
      get
      {
      }
    }

    public float PercentMultiplicativeMovementSpeedMod
    {
      get
      {
      }
    }

    public float PercentMovementSpeedMod
    {
      get
      {
      }
    }

    public float FlatMovementSpeedMod
    {
      get
      {
      }
    }

    public float PercentSlowResistMod
    {
      get
      {
      }
    }

    public float PercentCCReduction
    {
      get
      {
      }
    }

    public float PercentTenacityRuneMod
    {
      get
      {
      }
    }

    public float PercentTenacityMasteryMod
    {
      get
      {
      }
    }

    public float PercentTenacityItemMod
    {
      get
      {
      }
    }

    public float PercentTenacityCharacterMod
    {
      get
      {
      }
    }

    public float PercentTenacityCleanseMod
    {
      get
      {
      }
    }

    public float PercentPARRegenMod
    {
      get
      {
      }
    }

    public float FlatPARRegenMod
    {
      get
      {
      }
    }

    public float PercentBaseHPRegenMod
    {
      get
      {
      }
    }

    public float PercentHPRegenMod
    {
      get
      {
      }
    }

    public float FlatHPRegenMod
    {
      get
      {
      }
    }

    public float PercentPARPoolMod
    {
      get
      {
      }
    }

    public float FlatPARPoolMod
    {
      get
      {
      }
    }

    public float PercentHPPoolMod
    {
      get
      {
      }
    }

    public float FlatHPPoolMod
    {
      get
      {
      }
    }

    public float PercentCooldownMod
    {
      get
      {
      }
    }

    public float PassiveCooldownTotalTime
    {
      get
      {
      }
    }

    public float PassiveCooldownEndTime
    {
      get
      {
      }
    }

    public float FlatCooldownMod
    {
      get
      {
	  }
    }

    public Vector3 Direction
    {
      get
      {
      }
    }

    public bool IsHPBarRendered
    {
      get
      {
      }
    }

    public Vector2 HPBarPosition
    {
      get
      {
      }
    }

    public float AttackCastDelay
    {
      get
      {
      }
    }

    public float AttackDelay
    {
      get
      {
      }
    }

    public Vector3 InfoComponentBasePosition
    {
      get
      {
      }
    }

    public Vector3 ServerPosition
    {
      get
      {
      }
    }

    public GameObject Pet
    {
      get
      {
      }
    }

    public InventorySlot[] InventoryItems
    {
      get
      {
      }
    }

    public SpellData BasicAttack
    {
      get
      {
      }
    }

    public BuffInstance[] Buffs
    {
      get
      {
	  }
    }

    public string BaseSkinName
    {
      get
      {
      }
    }

    public bool IsPacified
    {
      get
      {
      }
    }

    public bool IsStunned
    {
      get
      {
      }
    }

    public bool IsRooted
    {
      get
      {
      }
    }

    public bool IsDisableAmbientXP
    {
      get
      {
      }
    }

    public bool IsDisableAmbientGold
    {
      get
      {
      }
    }

    public bool IsImmovable
    {
      get
      {
      }
    }

    public bool CanMove
    {
      get
      {
      }
    }

    public bool CanCast
    {
      get
      {
      }
    }

    public bool CanAttack
    {
      get
      {
      }
    }

    public Spellbook Spellbook
    {
      get
      {
      }
    }

    public Vector3[] Path
    {
      get
      {
	  }
    }

    public bool IsMoving
    {
      get
      {
      }
    }

    public int AutoAttackTargetingFlags
    {
      get
      {
      }
    }

    public float DeathDuration
    {
      get
      {
      }
    }

    public Vector3 LastPausePosition
    {
      get
      {
      }
    }

    public Vector3 FearLeashPoint
    {
      get
      {
	  }
    }

    public float PetReturnRadius
    {
      get
      {
      }
    }

    public GameObjectCombatType CombatType
    {
      get
      {
      }
    }

    public float Gold
    {
      get
      {
      }
    }

    public int AI_LastPetSpawnedID
    {
      get
      {
      }
    }

    public bool SpellCastBlockingAI
    {
      get
      {
      }
    }

    public GameObjectCharacterState CharacterState
    {
      get
      {
      }
    }

    public float ExpGiveRadius
    {
      get
      {
      }
    }

    public float ScriptGoldGiven
    {
      get
      {
      }
    }

    public float ScriptExpGiven
    {
      get
      {
      }
    }

    public float ScriptHealthBonus
    {
      get
      {
      }
    }

    public float ScriptDamageBonus
    {
      get
      {
      }
    }

    public bool PlayerControlled
    {
      get
      {
      }
    }

    public string SkinName
    {
      get
      {
      }
    }

    public bool IsHoldingPosition
    {
      get
      {
      }
    }

    public bool IsWindingUp
    {
      get
      {
      }
    }

    public bool IsMinion
    {
      get
      {
      }
    }

    public static event GameObjectTeleport OnTeleport;

    public static event GameObjectIssueOrder OnIssueOrder;

    public static event GameObjectNewPath OnNewPath;

    public static event GameObjectProcessSpellCast OnProcessSpellCast;

    public static event GameObjectPlayAnimation OnPlayAnimation;

    static Obj_AI_Base()
    {
    }

    public Obj_AI_Base(ushort index, uint networkId)
      : base(index, networkId)
    {
    }

    public Obj_AI_Base()
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    internal bool CheckRayCast(Vector3 start, Vector3 end, [Out] float distance)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool HasBuffOfType(BuffType buff)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool IssueOrder(GameObjectOrder order, Vector3 targetPos, [MarshalAs(UnmanagedType.U1)] bool triggerEvent)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool IssueOrder(GameObjectOrder order, Vector3 targetPos)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool IssueOrder(GameObjectOrder order, GameObject targetUnit, [MarshalAs(UnmanagedType.U1)] bool triggerEvent)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool IssueOrder(GameObjectOrder order, GameObject targetUnit)
    {
    }

    public Vector3[] GetPath(Vector3 end)
    {
    }
  }
}
