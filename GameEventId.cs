namespace LeagueSharp
{
    /// <summary>
    ///     GameEventId enum, contains an identity/type for each game event.
    /// </summary>
    public enum GameEventId
    {
        /// <summary>
        ///     On GameObject Delete Event.
        /// </summary>
        OnDelete,

        /// <summary>
        ///     On GameObject Spawn Event.
        /// </summary>
        OnSpawn,

        /// <summary>
        ///     On GameObject Die Event.
        /// </summary>
        OnDie,

        /// <summary>
        ///     On GameObject Kill Event.
        /// </summary>
        OnKill,

        /// <summary>
        ///     On Champion GameObject Die Event.
        /// </summary>
        OnChampionDie,

        /// <summary>
        ///     On Champion GameObject Before Kill Event.
        /// </summary>
        OnChampionKillPre,

        /// <summary>
        ///     On Champion GameObject Kill Event.
        /// </summary>
        OnChampionKill,

        /// <summary>
        ///     On Champion GameObject After Kill Event.
        /// </summary>
        OnChampionKillPost,

        /// <summary>
        ///     On Champion GameObject Single Kill Event.
        /// </summary>
        OnChampionSingleKill,

        /// <summary>
        ///     On Champion GameObject Double Kill Event.
        /// </summary>
        OnChampionDoubleKill,

        /// <summary>
        ///     On Champion GameObject Triple Kill Event.
        /// </summary>
        OnChampionTripleKill,

        /// <summary>
        ///     On Champion GameObject Quadra Kill Event.
        /// </summary>
        OnChampionQuadraKill,

        /// <summary>
        ///     On Champion GameObject Penta Kill Event.
        /// </summary>
        OnChampionPentaKill,

        /// <summary>
        ///     On Champion GameObject Over-Penta kill Event.
        /// </summary>
        OnChampionUnrealKill,

        /// <summary>
        ///     On GameObject First Blood Event.
        /// </summary>
        OnFirstBlood,

        /// <summary>
        ///     On GameObject Take Damage Event.
        /// </summary>
        OnDamageTaken,

        /// <summary>
        ///     On GameObject Give Damage Event.
        /// </summary>
        OnDamageGiven,

        /// <summary>
        ///     On GameObject Index 1 Spell Cast Event.
        /// </summary>
        OnSpellCast1,

        /// <summary>
        ///     On GameObject Index 2 Spell Cast Event.
        /// </summary>
        OnSpellCast2,

        /// <summary>
        ///     On GameObject Index 3 Spell Cast Event.
        /// </summary>
        OnSpellCast3,

        /// <summary>
        ///     On GameObject Index 4 Spell Cast Event.
        /// </summary>
        OnSpellCast4,

        /// <summary>
        ///     On GameObject Spell Avatar Cast, Index 1 (Event).
        /// </summary>
        OnSpellAvatarCast1,

        /// <summary>
        ///     On GameObject Spell Avatar Cast, Index 2 (Event).
        /// </summary>
        OnSpellAvatarCast2,

        /// <summary>
        ///     On GameObject Spend Gold Event.
        /// </summary>
        OnGoldSpent,

        /// <summary>
        ///     On GameObject Earn Gold Event.
        /// </summary>
        OnGoldEarned,

        /// <summary>
        ///     On GameObject Consume Item Purchase Event.
        /// </summary>
        OnItemConsumeablePurchased,

        /// <summary>
        ///     On GameObject Critical Strike Event.
        /// </summary>
        OnCriticalStrike,

        /// <summary>
        ///     On GameObject Ace Event.
        /// </summary>
        OnAce,

        /// <summary>
        ///     On GameObject Reincarnate Event.
        /// </summary>
        OnReincarnate,

        /// <summary>
        ///     On GameObject Kill Dempener (Inhibitor) Event.
        /// </summary>
        OnDampenerKill,

        /// <summary>
        ///     On Dampener GameObject (Inhibitor) Death Event.
        /// </summary>
        OnDampenerDie,

        /// <summary>
        ///     On Dampener GameObject (Inhibitor) Respawn Soon Event.
        /// </summary>
        OnDampenerRespawnSoon,

        /// <summary>
        ///     On Dampener GameObject (Inhibitor) Respawn Event.
        /// </summary>
        OnDampenerRespawn,

        /// <summary>
        ///     On Dampener GameObject (Inhibitor) Take Damage Event.
        /// </summary>
        OnDampenerDamage,

        /// <summary>
        ///     On GameObject Kill Turret Event.
        /// </summary>
        OnTurretKill,

        /// <summary>
        ///     On Turret GameObject Death Event.
        /// </summary>
        OnTurretDie,

        /// <summary>
        ///     On Turret GameObject Take Damage Event.
        /// </summary>
        OnTurretDamage,

        /// <summary>
        ///     On GameObject Kill Minion Event.
        /// </summary>
        OnMinionKill,

        /// <summary>
        ///     On Minion GameObject Deny Event.
        /// </summary>
        OnMinionDenied,

        /// <summary>
        ///     On GameObject Kill Neutral Minion Event.
        /// </summary>
        OnNeutralMinionKill,

        /// <summary>
        ///     On GameObject Kill Super Monster (Minion) Event.
        /// </summary>
        OnSuperMonsterKill,

        /// <summary>
        ///     On GameObject Acquire Red Buff from Neutral GameObject Event.
        /// </summary>
        OnAcquireRedBuffFromNeutral,

        /// <summary>
        ///     On GameObject Acquire Blue Buff from Neutral GameObject Event.
        /// </summary>
        OnAcquireBlueBuffFromNeutral,

        /// <summary>
        ///     On GameObject Kill HQ (Nexus) Event.
        /// </summary>
        OnHQKill,

        /// <summary>
        ///     On HQ (Nexus) GameObject Death Event.
        /// </summary>
        OnHQDie,

        /// <summary>
        ///     On GameObject Heal Event.
        /// </summary>
        OnHeal,

        /// <summary>
        ///     On GameObject Cast Heal Event.
        /// </summary>
        OnCastHeal,

        /// <summary>
        ///     On GameObject Receieve Buff Event.
        /// </summary>
        OnBuff,

        /// <summary>
        ///     On GameObject Crowd Control Duration End / Dealt Event.
        /// </summary>
        OnCrowdControlDealt,

        /// <summary>
        ///     On GameObject Killing Spree (index 0) Event.
        /// </summary>
        OnKillingSpree,

        /// <summary>
        ///     On GameObject Killing Spree (index 1) Event.
        /// </summary>
        OnKillingSpreeSet1,

        /// <summary>
        ///     On GameObject Killing Spree (index 2) Event.
        /// </summary>
        OnKillingSpreeSet2,

        /// <summary>
        ///     On GameObject Killing Spree (index 3) Event.
        /// </summary>
        OnKillingSpreeSet3,

        /// <summary>
        ///     On GameObject Killing Spree (index 4) Event.
        /// </summary>
        OnKillingSpreeSet4,

        /// <summary>
        ///     On GameObject Killing Spree (index 5) Event.
        /// </summary>
        OnKillingSpreeSet5,

        /// <summary>
        ///     On GameObject Killing Spree (index 6) Event.
        /// </summary>
        OnKillingSpreeSet6,

        /// <summary>
        ///     On Killed GameObject Killing Spree (index 0) Event.
        /// </summary>
        OnKilledUnitOnKillingSpree,

        /// <summary>
        ///     On Killed GameObject Killing Spree (index 1) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeSet1,

        /// <summary>
        ///     On Killed GameObject Killing Spree (index 2) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeSet2,

        /// <summary>
        ///     On Killed GameObject Killing Spree (index 3) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeSet3,

        /// <summary>
        ///     On Killed GameObject Killing Spree (index 4) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeSet4,

        /// <summary>
        ///     On Killed GameObject Killing Spree (index 5) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeSet5,

        /// <summary>
        ///     On Killed GameObject Killing Spree (index 6) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeSet6,

        /// <summary>
        ///     On Killed GameObject Killing Spree (Double Kill) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeDoubleKill,

        /// <summary>
        ///     On Killed GameObject Killing Spree (Triple Kill) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeTripleKill,

        /// <summary>
        ///     On Killed GameObject Killing Spree (Quadra Kill) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeQuadraKill,

        /// <summary>
        ///     On Killed GameObject Killing Spree (Penta Kill) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreePentaKill,

        /// <summary>
        ///     On Killed GameObject Killing Spree (Over-Penta Kill) Event.
        /// </summary>
        OnKilledUnitOnKillingSpreeUnrealKill,

        /// <summary>
        ///     On GameObject Deah Assist Event.
        /// </summary>
        OnDeathAssist,

        /// <summary>
        ///     On GameObject Quit Event.
        /// </summary>
        OnQuit,

        /// <summary>
        ///     On GameObject Leave Event.
        /// </summary>
        OnLeave,

        /// <summary>
        ///     On GameObject Reconnect Event.
        /// </summary>
        OnReconnect,

        /// <summary>
        ///     On Game GameObject Start Event.
        /// </summary>
        OnGameStart,

        /// <summary>
        ///     On GameObject Assisting Spree (index 1) Event.
        /// </summary>
        OnAssistingSpreeSet1,

        /// <summary>
        ///     On GameObject Assisting Spree (index 2) Event.
        /// </summary>
        OnAssistingSpreeSet2,

        /// <summary>
        ///     On Champion GameObject Assisting Spree (Triple Assist) Event.
        /// </summary>
        OnChampionTripleAssist,

        /// <summary>
        ///     On Champion GameObject Assisting Spree (Penta Assist) Event.
        /// </summary>
        OnChampionPentaAssist,

        /// <summary>
        ///     On Ping GameObject Event.
        /// </summary>
        OnPing,

        /// <summary>
        ///     On Player Ping GameObject Event.
        /// </summary>
        OnPingPlayer,

        /// <summary>
        ///     On Building Ping GameObject Event.
        /// </summary>
        OnPingBuilding,

        /// <summary>
        ///     On Other Ping GameObject Event.
        /// </summary>
        OnPingOther,

        /// <summary>
        ///     On Game GameObject End Event.
        /// </summary>
        OnEndGame,

        /// <summary>
        ///     On GameObject Spell Levelup (index 1) Event.
        /// </summary>
        OnSpellLevelup1,

        /// <summary>
        ///     On GameObject Spell Levelup (index 2) Event.
        /// </summary>
        OnSpellLevelup2,

        /// <summary>
        ///     On GameObject Spell Levelup (index 3) Event.
        /// </summary>
        OnSpellLevelup3,

        /// <summary>
        ///     On GameObject Spell Levelup (index 4) Event.
        /// </summary>
        OnSpellLevelup4,

        /// <summary>
        ///     On Item GameObject Purchase Event Event.
        /// </summary>
        OnItemPurchased,

        /// <summary>
        ///     On Item GameObject Sell Event.
        /// </summary>
        OnItemSold,

        /// <summary>
        ///     On Item GameObject Remove Event.
        /// </summary>
        OnItemRemoved,

        /// <summary>
        ///     On Item GameObject Callout Event.
        /// </summary>
        OnItemCallout,

        /// <summary>
        ///     On Item GameObject Change Event.
        /// </summary>
        OnItemChange,

        /// <summary>
        ///     On GameObject Undo Enable Change Event.
        /// </summary>
        OnUndoEnabledChange,

        /// <summary>
        ///     On Shop Item GameObject Substitution Change Event.
        /// </summary>
        OnShopItemSubstitutionChange,

        /// <summary>
        ///     On Surrender GameObject Vote Start Event.
        /// </summary>
        OnSurrenderVoteStart,

        /// <summary>
        ///     On Surrender GameObject Vote Event.
        /// </summary>
        OnSurrenderVote,

        /// <summary>
        ///     On Surrender GameObject Voted Already Event.
        /// </summary>
        OnSurrenderVoteAlready,

        /// <summary>
        ///     On Surrender GameObject Failed Votes Event.
        /// </summary>
        OnSurrenderFailedVotes,

        /// <summary>
        ///     On Surrender GameObject Too Early Event.
        /// </summary>
        OnSurrenderTooEarly,

        /// <summary>
        ///     On Surrender GameObject Vote Agreed Event.
        /// </summary>
        OnSurrenderAgreed,

        /// <summary>
        ///     On Surrender GameObject Spam Event.
        /// </summary>
        OnSurrenderSpam,

        /// <summary>
        ///     On Equalize GameObject Vote Start Event.
        /// </summary>
        OnEqualizeVoteStart,

        /// <summary>
        ///     On Equalize GameObject Vote Event.
        /// </summary>
        OnEqualizeVote,

        /// <summary>
        ///     On Equalize GameObject Voted Already Event.
        /// </summary>
        OnEqualizeVoteAlready,

        /// <summary>
        ///     On Equalize GameObject Failed Votes Event.
        /// </summary>
        OnEqualizeFailedVotes,

        /// <summary>
        ///     On Equalize GameObject Too Early Event.
        /// </summary>
        OnEqualizeTooEarly,

        /// <summary>
        ///     On Equalize GameObject Not Enough Gold Event.
        /// </summary>
        OnEqualizeNotEnoughGold,

        /// <summary>
        ///     On Equalize GameObject Not Enough Levels Event.
        /// </summary>
        OnEqualizeNotEnoughLevels,

        /// <summary>
        ///     On Equalize GameObject Vote Agreed Event.
        /// </summary>
        OnEqualizeAgreed,

        /// <summary>
        ///     On Equalize GameObject Spam Event.
        /// </summary>
        OnEqualizeSpam,

        /// <summary>
        ///     On Game GameObject Pause Event.
        /// </summary>
        OnPause,

        /// <summary>
        ///     On Game GameObject Pause Resume Event.
        /// </summary>
        OnPauseResume,

        /// <summary>
        ///     On Game GameObject Minions Spawn Event.
        /// </summary>
        OnMinionsSpawn,

        /// <summary>
        ///     On Game GameObject start message (index 1) Event.
        /// </summary>
        OnStartGameMessage1,

        /// <summary>
        ///     On Game GameObject start message (index 2) Event.
        /// </summary>
        OnStartGameMessage2,

        /// <summary>
        ///     On Game GameObject start message (index 3) Event.
        /// </summary>
        OnStartGameMessage3,

        /// <summary>
        ///     On Game GameObject start message (index 4) Event.
        /// </summary>
        OnStartGameMessage4,

        /// <summary>
        ///     On Game GameObject start message (index 5) Event.
        /// </summary>
        OnStartGameMessage5,

        /// <summary>
        ///     On Game GameObject Alert Event.
        /// </summary>
        OnAlert,

        /// <summary>
        ///     On Scoreboard GameObject Open Event.
        /// </summary>
        OnScoreboardOpen,

        /// <summary>
        ///     On Audio GameObject Finish Event.
        /// </summary>
        OnAudioEventFinished,

        /// <summary>
        ///     On Nexus GameObject Cyrstal Start Event.
        /// </summary>
        OnNexusCrystalStart,

        /// <summary>
        ///     On CapturePoint GameObject Neutralized Event (index A).
        /// </summary>
        OnCapturePointNeutralized_A,

        /// <summary>
        ///     On CapturePoint GameObject Neutralized Event (index B).
        /// </summary>
        OnCapturePointNeutralized_B,

        /// <summary>
        ///     On CapturePoint GameObject Neutralized Event (index C).
        /// </summary>
        OnCapturePointNeutralized_C,

        /// <summary>
        ///     On CapturePoint GameObject Neutralized Event (index D).
        /// </summary>
        OnCapturePointNeutralized_D,

        /// <summary>
        ///     On CapturePoint GameObject Neutralized Event (index E).
        /// </summary>
        OnCapturePointNeutralized_E,

        /// <summary>
        ///     On CapturePoint GameObject Captured Event (index A).
        /// </summary>
        OnCapturePointCaptured_A,

        /// <summary>
        ///     On CapturePoint GameObject Captured Event (index B).
        /// </summary>
        OnCapturePointCaptured_B,

        /// <summary>
        ///     On CapturePoint GameObject Captured Event (index C).
        /// </summary>
        OnCapturePointCaptured_C,

        /// <summary>
        ///     On CapturePoint GameObject Captured Event (index D).
        /// </summary>
        OnCapturePointCaptured_D,

        /// <summary>
        ///     On CapturePoint GameObject Captured Event (index E).
        /// </summary>
        OnCapturePointCaptured_E,

        /// <summary>
        ///     On CapturePoint GameObject Captured Five Cap Event.
        /// </summary>
        OnCapturePointFiveCap,

        /// <summary>
        ///     On VictoryPoint GameObject Threshold Event (index 1).
        /// </summary>
        OnVictoryPointThreshold1,

        /// <summary>
        ///     On VictoryPoint GameObject Threshold Event (index 2).
        /// </summary>
        OnVictoryPointThreshold2,

        /// <summary>
        ///     On VictoryPoint GameObject Threshold Event (index 3).
        /// </summary>
        OnVictoryPointThreshold3,

        /// <summary>
        ///     On VictoryPoint GameObject Threshold Event (index 4).
        /// </summary>
        OnVictoryPointThreshold4,

        /// <summary>
        ///     On Minion GameObject Kill Victory Threshold Event (index 1).
        /// </summary>
        OnMinionKillVictoryThreshold1,

        /// <summary>
        ///     On Minion GameObject Kill Victory Threshold Event (index 2).
        /// </summary>
        OnMinionKillVictoryThreshold2,

        /// <summary>
        ///     On Replay GameObject Fast Forward Start Event.
        /// </summary>
        OnReplayFastForwardStart,

        /// <summary>
        ///     On Replay GameObject Fast Forward Start End Event.
        /// </summary>
        OnReplayFastForwardEnd,

        /// <summary>
        ///     On Replay GameObject Keyframe Finished Event.
        /// </summary>
        OnReplayOnKeyframeFinished,

        /// <summary>
        ///     On GameObject Kill Dragon Event.
        /// </summary>
        OnKillDragon,

        /// <summary>
        ///     On GameObject Kill Dragon Spectator Event.
        /// </summary>
        OnKillDragon_Spectator,

        /// <summary>
        ///     On GameObject Dragon Steal (Kill) Event.
        /// </summary>
        OnKillDragonSteal,

        /// <summary>
        ///     On GameObject Kill Worm Event.
        /// </summary>
        OnKillWorm,

        /// <summary>
        ///     On GameObject Kill Worm Spectator Event.
        /// </summary>
        OnKillWorm_Spectator,

        /// <summary>
        ///     On GameObject Steal Worm (Kill) Event.
        /// </summary>
        OnKillWormSteal,

        /// <summary>
        ///     On GameObject Kill Spider Boss Event.
        /// </summary>
        OnKillSpiderBoss,

        /// <summary>
        ///     On GameObject Kill Spider Boss Spectator Event.
        /// </summary>
        OnKillSpiderBoss_Spectator,

        /// <summary>
        ///     On GameObject Capture Altar Event.
        /// </summary>
        OnCaptureAltar,

        /// <summary>
        ///     On GameObject Capture Altar Spectator Event.
        /// </summary>
        OnCaptureAltar_Spectator,

        /// <summary>
        ///     On GameObject Place Ward Event.
        /// </summary>
        OnPlaceWard,

        /// <summary>
        ///     On GameObject Kill Ward Event.
        /// </summary>
        OnKillWard
    }
}