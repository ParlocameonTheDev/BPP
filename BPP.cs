using System;
using System.Collections;
using BepInEx;
using HarmonyLib;
using BPP.Cards;
using Jotunn.Utils;
using UnboundLib;
using UnboundLib.Cards;
using UnboundLib.GameModes;
using UnityEngine;

namespace BPP
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]

    [BepInPlugin(ModId, ModName, Version)]

    [BepInProcess("Rounds.exe")]
    public class BPP : BaseUnityPlugin
    {
        private const string ModId = "com.binarypenialporty.rounds.bpp";
        private const string ModName = "BPP";
        public const string Version = "1.2.3";
        public const string ModInitials = "BPP";
        internal static AssetBundle ArtAssets;

        public static BPP instance { get; private set; }

        //Setting up card art.

        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("bppart", typeof(BPP).Assembly);

        public static GameObject CardNameArt = Bundle.LoadAsset<GameObject>("C_AA12");
        public static GameObject CardNameArt2 = Bundle.LoadAsset<GameObject>("C_AcceleratedBackHopping");
        public static GameObject CardNameArt3 = Bundle.LoadAsset<GameObject>("C_Dash");
        public static GameObject CardNameArt4 = Bundle.LoadAsset<GameObject>("C_DashMK2");
        public static GameObject CardNameArt5 = Bundle.LoadAsset<GameObject>("C_SwiftReactions");
        public static GameObject CardNameArt6 = Bundle.LoadAsset<GameObject>("C_CondensedShot");
        public static GameObject CardNameArt7 = Bundle.LoadAsset<GameObject>("C_DesignatedMarksmanRifle");
        public static GameObject CardNameArt8 = Bundle.LoadAsset<GameObject>("C_HighPowerScope");
        public static GameObject CardNameArt9 = Bundle.LoadAsset<GameObject>("C_Minigun");
        public static GameObject CardNameArt10 = Bundle.LoadAsset<GameObject>("C_Nailgun");
        public static GameObject CardNameArt11 = Bundle.LoadAsset<GameObject>("C_NoScope");
        public static GameObject CardNameArt12 = Bundle.LoadAsset<GameObject>("C_P90");
        public static GameObject CardNameArt13 = Bundle.LoadAsset<GameObject>("C_PumpAction");
        public static GameObject CardNameArt14 = Bundle.LoadAsset<GameObject>("C_SpeedTape");
        public static GameObject CardNameArt15 = Bundle.LoadAsset<GameObject>("C_TacticalGloves");
        public static GameObject CardNameArt16 = Bundle.LoadAsset<GameObject>("C_MunitionsPack");
        public static GameObject CardNameArt17 = Bundle.LoadAsset<GameObject>("C_BluePill");
        public static GameObject CardNameArt18 = Bundle.LoadAsset<GameObject>("C_GreenPill");
        public static GameObject CardNameArt19 = Bundle.LoadAsset<GameObject>("C_RedPill");
        public static GameObject CardNameArt20 = Bundle.LoadAsset<GameObject>("C_Nuclear");
        public static GameObject CardNameArt21 = Bundle.LoadAsset<GameObject>("C_TrustyPan");
        public static GameObject CardNameArt22 = Bundle.LoadAsset<GameObject>("C_TrustyPanUltraSuperXL");
        public static GameObject CardNameArt23 = Bundle.LoadAsset<GameObject>("C_GroundPound");



        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;

            //Setting up the code for the credits tab of the mod.

            Unbound.RegisterCredits("<b><color=#ffd900>BPP</b></color>", new string[]
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

            //Added a class specifically for initializing cards, because it was getting messy.

            Initialize.Cards();


        }
    }
}
