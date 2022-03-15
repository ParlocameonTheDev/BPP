using System;
using System.Collections;
using BepInEx;
using HarmonyLib;
using BPP.Cards;
using BPP.MonoBehaviours;
using Jotunn.Utils;
using UnboundLib;
using UnboundLib.Cards;
using UnboundLib.GameModes;
using UnboundLib.Utils;
using UnityEngine;
using System.Collections.Generic;

namespace BPP
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin("com.binarypenialporty.rounds.bpp", "BPP", "2.1.0")]
    [BepInProcess("Rounds.exe")]
    public class BPP : BaseUnityPlugin
    {
        public const string AbbrModName = "BPP";
        private const string ModId = "com.binarypenialporty.rounds.bpp";
        private const string ModName = "BPP";
        public const string Version = "2.1.0";
        public const string ModInitials = "BPP";
        public static Dictionary<String, GameObject> CardArt = new Dictionary<String, GameObject>();
        public static Dictionary<String, AudioClip> CustomAudio = new Dictionary<String, AudioClip>();

        public static BPP instance { get; private set; }

        void Awake()
        {
            var harmony = new Harmony("com.binarypenialporty.rounds.bpp");
            harmony.PatchAll();
            GameModeManager.AddHook("GameEnd", new Func<IGameModeHandler, IEnumerator>(this.ResetEffects));
        }

        private IEnumerator ResetEffects(IGameModeHandler gm)
        {
            // Nothing to see here (yet)

            yield break;
        }

        void Start()
        {
            BPP.instance = this;

            Unbound.RegisterCredits("<b><color=#ffd900>BPP v2.1.0</b></color>", new string[]
{
                "BinaryAssault, Penial, and Porty."
}, new string[]
{
                "<b><color=#ff00df>GitHub (Source Code)</b></color>",
                "Binary's Steam Profile",
                "Penial's Steam Profile",
                "Porty's Steam Profile"
}, new string[]
{
                "https://github.com/ParlocameonTheDev/BPP",
                "https://steamcommunity.com/id/Parlocameon",
                "https://steamcommunity.com/id/penialsteamlol",
                "https://steamcommunity.com/id/portmens"
});

            // Added a class specifically for initializing cards, because it was getting messy.
            Initialize.Cards();
            Initialize.Managers();
            CardArt = Initialize.CardArtDictionary();
            CustomAudio = Initialize.AudioClipDictionary();
        }
    }
}