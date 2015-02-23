namespace LeagueSharp
{
    /// <summary>
    ///     Every buff can be grouped into a certain type. This enum defines these.
    /// </summary>
    public enum BuffType
    {
        /// <summary>
        ///     Internal (Buff Type)
        ///     A unit that holds an internal buff indicates it's a buff that is connected towards the set range of champions only.
        /// </summary>
        Internal,

        /// <summary>
        ///     Aura (Buff Type)
        ///     Passive modifier to units that are near the aura source, which may be a champion that has the aura thanks to an
        ///     ability of his own or to an item he is holding, or an object, which can only be placed by a champion.
        /// </summary>
        Aura,

        /// <summary>
        ///     Combat Enchancer (Buff Type)
        ///     A unit that holds the combat enchancer buff is temporarily boosted during an active combat, the source of the buff
        ///     indicates which values are enhanced.
        /// </summary>
        CombatEnchancer,

        /// <summary>
        ///     Combat Dehancer (Buff Type)
        ///     A unit that holds the combat dehancer buff is temporarily deboosted during an active combat, the source of the buff
        ///     indicates which values are weaken.
        /// </summary>
        CombatDehancer,

        /// <summary>
        ///     Spell Shield (Buff Type)
        ///     Game mechanic which grants temporary health to a unit for some time. These shields absorb a set amount of
        ///     damage before it disappears, whether because it reached its capacity of damage absorption or because its duration
        ///     ran out. It is marked by an extra white bar in the unit's health bar.
        /// </summary>
        SpellShield,

        /// <summary>
        ///     Stun (Buff Type)
        ///     A unit that is stunned is unable to move, attack or cast abilities for the duration.
        /// </summary>
        Stun,

        /// <summary>
        ///     Invisibility (Buff Type)
        ///     Stealth is the mechanic by which some units become invisible for a determined period of time.
        /// </summary>
        Invisibility,

        /// <summary>
        ///     Silence (Buff Type)
        ///     A unit that is silenced cannot cast abilities or activate items for the duration.
        /// </summary>
        Silence,

        /// <summary>
        ///     Taunt (Buff Type)
        ///     A unit that is taunted will attempt to Autoattack the source of the taunt for the duration.
        /// </summary>
        Taunt,

        /// <summary>
        ///     Polymorph (Buff Type)
        ///     A combination of Disarm and Silence (aka Pacify). The only example also reduces movement speed for the duration.
        /// </summary>
        Polymorph,

        /// <summary>
        ///     Slow (Buff Type)
        ///     A unit that is slowed has reduced movement and/or attack speed for the duration.
        /// </summary>
        Slow,

        /// <summary>
        ///     Snare (Buff Type)
        ///     A unit that is rooted is unable to control its movement for the duration (occasionally referred to as a Snare).
        /// </summary>
        Snare,

        /// <summary>
        ///     Damage (Buff Type)
        ///     Damage is a property of autoattacks, abilities and on-hit effects in League of Legends that can, in its rawest
        ///     form, be viewed as the aftermath of an attack on a unit or structure.
        /// </summary>
        Damage,

        /// <summary>
        ///     Heal (Buff Type)
        ///     A unit that has the heal buff would regenerate an additional fixed amount of health points based on the given value
        ///     by the heal source.
        /// </summary>
        Heal,

        /// <summary>
        ///     Haste (Buff Type)
        ///     A unit that has haste would temporarily have more movement speed that decays over time.
        /// </summary>
        Haste,

        /// <summary>
        ///     Spell Immunity (Buff Type)
        ///     A unit that has spell immunity would ignore all damage or effects that can be blocked by the spell.
        /// </summary>
        SpellImmunity,

        /// <summary>
        ///     Physical Immunity (Buff Type)
        ///     A unit that has physical immunity would ignore all damage from a physical source.
        /// </summary>
        PhysicalImmunity,

        /// <summary>
        ///     Invulnerability (Buff Type)
        ///     Invulnerability reduces all damage taken to 0 and is the only form of damage reduction that affects true damage.
        ///     Drain effects, such as life steal, will have no effect against invulnerability.
        /// </summary>
        Invulnerability,

        /// <summary>
        ///     Sleep (Buff Type)
        ///     A unit that has the sleep buff has fell asleep and is unable to cast any spells or move for a set amount of time.
        /// </summary>
        Sleep,

        /// <summary>
        ///     Near Sight (Buff Type)
        ///     A unit that has the near sight buff would scout a set distance from the unit's location, the given distance and
        ///     true sight is defined by the source of the buff.
        /// </summary>
        NearSight,

        /// <summary>
        ///     Frenzy (Buff Type)
        ///     Frenzy is a tier 5 offense mastery with 1 rank, critical strikes increase your attack speed by 5% for 3 seconds,
        ///     stacking up to 3 times.
        /// </summary>
        Frenzy,

        /// <summary>
        ///     Fear (Buff Type)
        ///     A unit that is feared move around randomly at reduced movement speed for the duration. There are currently no
        ///     examples of Fear that affect champions.
        /// </summary>
        Fear,

        /// <summary>
        ///     Charm (Buff Type)
        ///     A unit that is charmed will move toward the source for the duration.
        /// </summary>
        Charm,

        /// <summary>
        ///     Poison (Buff Type)
        ///     Damage over time (DoT) is a term used to describe a single spell or attack which deals full damage not instantly
        ///     but over a period of time, dealing a portion of its total damage at regular intervals. The damage is often done
        ///     every second or every half-second, and each instant in which it is dealt is called a "tick."
        /// </summary>
        Poison,

        /// <summary>
        ///     Suppression (Buff Type)
        ///     A unit that is suppressed is unable to control its movement, attack, cast abilities or use spells (including
        ///     Cleanse). The duration is also unaffected by crowd control reduction.
        /// </summary>
        Suppression,

        /// <summary>
        ///     Blind (Buff Type)
        ///     A unit that is blind will miss its auto-attacks for the duration. Miss occurs on-hit, and does not prevent attacks
        ///     from being declared.
        /// </summary>
        Blind,

        /// <summary>
        ///     Counter (Buff Type)
        ///     A unit that holds the counter buff will counter any set damage or effect that is indicated by the source of the
        ///     buff.
        /// </summary>
        Counter,

        /// <summary>
        ///     Shred (Buff Type)
        ///     A unit that has the shred buff is actively playing an audio around the unit's position in a fixed range, and scales
        ///     with it's casts.
        ///     This buff is intended for Sona.
        /// </summary>
        Shred,

        /// <summary>
        ///     Flee (Buff Type)
        ///     A unit that is fleeing will move directly away from the source with reduced movement speed for the duration.
        /// </summary>
        Flee,

        /// <summary>
        ///     Knockup (Buff Type)
        ///     A knockup causes the target to be made airborne on the spot. The duration depends on how high is the target thrown
        ///     into the air, from 0.75 seconds (Rammus' Powerball) to 1.5 (Lulu's Wild Growth).
        /// </summary>
        Knockup,

        /// <summary>
        ///     Knockback (Buff Type)
        ///     A knockback causes the target to be made airborne in a direction away from the point of cast.The duration depends
        ///     on how far the target travels, from 0.75 seconds (Rammus' Powerball) to 1.5 (Lulu's Wild Growth).
        /// </summary>
        Knockback,

        /// <summary>
        ///     Disarm (Buff Type)
        ///     A unit that is disarmed cannot declare attacks for the duration. There are currently no examples of Disarm as a
        ///     standalone crowd control type.
        /// </summary>
        Disarm
    }
}