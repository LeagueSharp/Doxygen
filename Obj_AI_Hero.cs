using LeagueSharp.Native;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeagueSharp
{
  public class Obj_AI_Hero : Obj_AI_Base
  {
    public float TotalHeal
    {
      get
      {
      }
    }

    public float MagicDamageTaken
    {
      get
      {
      }
    }

    public float PhysicalDamageTaken
    {
      get
      {
      }
    }

    public float MagicDamageDealtPlayer
    {
      get
      {
      }
    }

    public float PhysicalDamageDealtPlayer
    {
      get
      {
      }
    }

    public float CombatPlayerScore
    {
      get
	  {
      }
    }

    public float ObjectivePlayerScore
    {
      get
      {
      }
    }

    public float TotalPlayerScore
    {
      get
      {
      }
    }

    public float LargestCriticalStrike
    {
      get
      {
      }
    }

    public int UnrealKills
    {
      get
      {
      }
    }

    public int PentaKills
    {
      get
      {
      }
    }

    public int QuadraKills
    {
      get
      {
      }
    }

    public int TripleKills
    {
      get
      {
      }
    }

    public int DoubleKills
    {
      get
      {
      }
    }

    public int HQKilled
    {
      get
      {
      }
    }

    public int WardsPlaced
    {
      get
      {
	  }
    }

    public int SuperMonsterKilled
    {
      get
      {
      }
    }

    public int TurretsKilled
    {
      get
      {
      }
    }

    public int BarracksKilled
    {
      get
      {
      }
    }

    public float LongestTimeSpentLiving
    {
      get
      {
      }
    }

    public int LargestKillingSpree
    {
      get
      {
      }
    }

    public float Score
    {
      get
      {
      }
    }

    public int NodesNeutralized
    {
      get
      {
      }
    }

    public int NodesCaptured
    {
      get
      {
      }
    }

    public float GoldCurrent
    {
      get
      {
      }
    }

    public float GoldEarned
    {
      get
      {
      }
    }

    public int Assists
    {
      get
      {
      }
    }

    public int Deaths
    {
      get
      {
      }
    }

    public int ChampionsKilled
    {
      get
      {
      }
    }

    public int WardsKilled
    {
      get
      {
      }
    }

    public int NeutralMinionsKilled
    {
      get
      {
      }
    }

    public int MinionsKilled
    {
      get
      {
      }
    }

    public float TotalTimeCrowdControlDealt
    {
      get
      {
      }
    }

    public int VisionWardsBought
    {
      get
      {
      }
    }

    public int SightWardsBought
    {
      get
      {
      }
    }

    public string ChampionName
    {
      get
      {
      }
    }

    public ItemId[] Runes
    {
      get
      {
      }
    }

    public Mastery[] Masteries
    {
      get
      {
      }
    }

    public int LevelCap
    {
      get
      {
	  }
    }

    public int SpellTrainingPoints
    {
      get
      {
      }
    }

    public int Level
    {
      get
      {
      }
    }

    public float Experience
    {
      get
      {
      }
    }

    public bool HasBotAI
    {
      get
      {
      }
    }

    public bool IsBot
    {
      get
      {
      }
    }

    static Obj_AI_Hero()
    {
    }

    public Obj_AI_Hero(ushort index, uint networkId)
      : base(index, networkId)
    {
    }

    public Obj_AI_Hero()
    {
    }

    internal new static void DomainUnloadEventHandler(object sender, EventArgs e)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool BuyItem(ItemId id)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool SellItem(int slot, [MarshalAs(UnmanagedType.U1)] bool grandItem)
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool SellItem(int slot)
    {
    }

    public void UndoBuy()
    {
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public bool SwapItem(int slot1, int slot2)
    {
    }
  }
}
