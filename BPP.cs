using System;
using System.Collections;
using BepInEx;
using HarmonyLib;
using BPP.Cards;
using BPP.MonoBehaviours;
using ClassesManager;
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

    [BepInPlugin(ModId, ModName, Version)]

    [BepInProcess("Rounds.exe")]
    public class BPP : BaseUnityPlugin
    {
        public const string AbbrModName = "BPP";
        private const string ModId = "com.binarypenialporty.rounds.bpp";
        private const string ModName = "BPP";
        public const string Version = "1.4.2";
        public const string ModInitials = "BPP";

        public static Dictionary<String, GameObject> CardArt = new Dictionary<String, GameObject>();


        public static BPP instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;

            // Setting up the code for the credits tab of the mod.
            Unbound.RegisterCredits("<b><color=#ffd900>BPP v1.4.2</b></color>", new string[]
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
            CardArt = Initialize.CardArtDictionary();
        }
    }
}
