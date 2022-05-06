using System;
using System.Collections;
using System.Collections.Generic;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using BPP.Cards;
using BPP.MonoBehaviours;
using Jotunn.Utils;
using Sonigon;
using TMPro;
using UnboundLib;
using UnboundLib.Cards;
using UnboundLib.GameModes;
using UnboundLib.Utils;
using UnboundLib.Utils.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BPP
{
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("root.classes.manager.reborn", BepInDependency.DependencyFlags.HardDependency)]
    [BepInPlugin("com.binarypenialporty.rounds.bpp", "BPP", "3.0.0")]
    [BepInProcess("Rounds.exe")]
    public class BPP : BaseUnityPlugin
    {
        public const string AbbrModName = "BPP";
        private const string ModId = "com.binarypenialporty.rounds.bpp";
        private const string ModName = "BPP";
        public const string Version = "3.0.0";
        public const string ModInitials = "BPP";
        public static Dictionary<String, GameObject> CardArt = new Dictionary<String, GameObject>();
        public static Dictionary<String, AudioClip> CustomAudio = new Dictionary<String, AudioClip>();
        public static ConfigEntry<float> globalVolMute;
        public static SoundEvent fieldsound;
        private SoundParameterIntensity soundParameterIntensity = new SoundParameterIntensity(1f, UpdateMode.Continuous);

        public static BPP instance { get; private set; }

        void Awake()
        {
            var harmony = new Harmony("com.binarypenialporty.rounds.bpp");
            harmony.PatchAll();
            BPP.globalVolMute = base.Config.Bind<float>("BPP", "Volume for BPP SFX", 100f, "Volume for BPP SFX");
            GameModeManager.AddHook("GameStart", new Func<IGameModeHandler, IEnumerator>(this.ResetEffects));
            GameModeManager.AddHook("GameEnd", new Func<IGameModeHandler, IEnumerator>(this.ResetEffects));
        }

        private IEnumerator ResetEffects(IGameModeHandler gm)
        {
            this.DestroyAll<AcceleratedBackHoppingMono>();
            this.DestroyAll<AMRHealthMono>();
            this.DestroyAll<AMRMono>();
            this.DestroyAll<DashMK2Mono>();
            this.DestroyAll<DashMono>();
            this.DestroyAll<GroundPoundMono>();
            this.DestroyAll<HorizonMono>();
            this.DestroyAll<ParryMono>();
            this.DestroyAll<SwiftReactionsMono>();
            yield break;
        }

        private void DestroyAll<T>() where T : UnityEngine.Object
        {
            T[] array = UnityEngine.Object.FindObjectsOfType<T>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                UnityEngine.Object.Destroy(array[i]);
            }
        }

        void Start()
        {
            BPP.instance = this;
            // Credits
            UnityEngine.Debug.Log("BPP credits have been loaded into the client successfully!");
            Unbound.RegisterCredits("<b><color=#ffd900>BPP v3.0.0</b></color>", new string[]
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
                // Mod Settings
                UnityEngine.Debug.Log("BPP settings have been loaded into the client successfully!");
                Unbound.RegisterMenu("<b>BPP Settings</b>", delegate ()
                {
                }, new Action<GameObject>(this.NewGUI), null, true);
                // Added a class specifically for initializing cards, because it was getting messy.
                Initialize.Cards();
                CardArt = Initialize.CardArtDictionary();
                CustomAudio = Initialize.AudioClipDictionary();
        }

        private void GlobalVolAction(float val)
        {
            BPP.globalVolMute.Value = val;
        }

        private void NewGUI(GameObject menu)
        {
            TextMeshProUGUI textMeshProUGUI;
            MenuHandler.CreateText("BPP Settings", menu, out textMeshProUGUI, 60, true, null, null, null, null);
            Slider slider;
            MenuHandler.CreateSlider("SFX Volume", menu, 50, 0f, 1f, BPP.globalVolMute.Value, new UnityAction<float>(this.GlobalVolAction), out slider, false, null, Slider.Direction.LeftToRight, true, null, null, null, null);
            GameObject toggle = MenuHandler.CreateToggle(BPP.settingsDebugModeToggle, "Debug Mode", menu, delegate (bool value)
            {
                BPP.settingsDebugModeToggle = value;
            }, 50, true, null, null, null, null);
            MenuHandler.CreateText("<b><color=#ff0000>^^</b></color>(game restart required for some forms of debugging)<b><color=#ff0000>^^</b></color>", menu, out textMeshProUGUI, 20, true, null, null, null, null);
            MenuHandler.CreateButton("Reset all settings to default", menu, delegate ()
            {
                UnityEngine.Debug.Log("All BPP settings we're reset to their default values.");
                BPP.globalVolMute.Value = 1f;
            }, 40, true, null, null, null, null);
            MenuHandler.CreateText("You are playing with <b><color=#ffd900>BPP v3.0.0</b></color>", menu, out textMeshProUGUI, 20, true, null, null, null, null);
        }

        public static bool settingsDebugModeToggle
        {
            get
            {
                return PlayerPrefs.GetInt(BPP.GetConfigKey("settingsDebugModeToggle"), 0) == 1;
            }
            set
            {
                PlayerPrefs.SetInt(BPP.GetConfigKey("settingsDebugModeToggle"), value ? 1 : 0);
            }
        }

        private static string GetConfigKey(string key)
        {
            return "BPP_" + key;
        }
    }
}