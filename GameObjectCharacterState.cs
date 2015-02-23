using System;

namespace LeagueSharp
{
    /// <summary>
    ///     GameObjectCharacterState enum, holds types of states for the character (champion).
    /// </summary>
    [Flags]
    public enum GameObjectCharacterState
    {
        /// <summary>
        ///     CanAttack state.
        ///     Character holding this state is able to attack.
        /// </summary>
        CanAttack = 1,

        /// <summary>
        ///     CanCast state.
        ///     Character holding this state is able to cast.
        /// </summary>
        CanCast = 2,

        /// <summary>
        ///     CanMove state.
        ///     Character holding this state is able to mvoe.
        /// </summary>
        CanMove = 4,

        /// <summary>
        ///     Immovable state.
        ///     Character holding this state is unable to move or be moved.
        /// </summary>
        Immovable = 8,

        /// <summary>
        ///     RevealSpecificUnit state.
        ///     Character holding this state is visible to other GameObjects.
        /// </summary>
        RevealSpecificUnit = 32,

        /// <summary>
        ///     Taunted state.
        ///     Character holding this state would be buffed with the taunt state.
        ///     <seealso cref="BuffType.Taunt" />
        /// </summary>
        Taunted = 64,

        /// <summary>
        ///     Feared state.
        ///     Character holding this state would be buffed with the fear state.
        ///     <seealso cref="BuffType.Fear" />
        /// </summary>
        Feared = 128,

        /// <summary>
        ///     Fleeing state.
        ///     Character holding this state would be buffed with the flee state.
        ///     <seealso cref="BuffType.Flee" />
        /// </summary>
        Fleeing = 256,

        /// <summary>
        ///     Taunted state.
        ///     Character holding this state would be buffed with the suppression state.
        ///     <seealso cref="BuffType.Suppression" />
        /// </summary>
        Surpressed = 512,

        /// <summary>
        ///     Taunted state.
        ///     Character holding this state would be buffed with the sleep state.
        ///     <seealso cref="BuffType.Sleep" />
        /// </summary>
        Asleep = 1024,

        /// <summary>
        ///     Taunted state.
        ///     Character holding this state would be buffed with the near sight state.
        ///     <seealso cref="BuffType.NearSight" />
        /// </summary>
        NearSight = 2048,

        /// <summary>
        ///     Ghosted state.
        ///     Character holding this state is ghosted.
        /// </summary>
        Ghosted = 4096,

        /// <summary>
        ///     Ghosted Proof state.
        ///     Character holding this state is ghosted-proof and is unable to be ghosted.
        /// </summary>
        GhostProof = 8192,

        /// <summary>
        ///     Taunted state.
        ///     Character holding this state would be buffed with the charm state.
        ///     <seealso cref="BuffType.Charm" />
        /// </summary>
        Charmed = 16384,

        /// <summary>
        ///     No Render state.
        ///     Character holding this state will not be graphically rendered.
        /// </summary>
        NoRender = 32768,

        /// <summary>
        ///     Dodge Piercing state.
        ///     Character holding this state will dodge piercing caused by other GameObjects.
        /// </summary>
        DodgePiercing = 131072,

        /// <summary>
        ///     Disable Ambient Gold state.
        ///     Character holding this state will stop receiving gold from ambient passive.
        /// </summary>
        DisableAmbientGold = 262144,

        /// <summary>
        ///     Disable Ambiet XP state.
        ///     Character holding this state will stop receiving XP from ambient passive.
        /// </summary>
        DisableAmbientXP = 524288,

        /// <summary>
        ///     Force Render Particles
        ///     Character holding this state will be forced to have graphically rendered particles.
        /// </summary>
        ForceRenderParticles = 65536
    }
}