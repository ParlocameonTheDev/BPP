using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using BPP.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;

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
        public const string Version = "0.1.0";
        public const string ModInitials = "BPP";

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
            CustomCard.BuildCard<AcceleratedBackHopping>();
            CustomCard.BuildCard<Dash>();
            CustomCard.BuildCard<DashMk2>();
            CustomCard.BuildCard<DesignatedMarksmanRifle>();
            CustomCard.BuildCard<RapidFire>();
            CustomCard.BuildCard<MakeshiftFullAuto>();
            CustomCard.BuildCard<AtomicAmmunition>();
            CustomCard.BuildCard<DamascusAmmunition>();
            CustomCard.BuildCard<Weights>();
            CustomCard.BuildCard<Minigun>();
            CustomCard.BuildCard<TrustyPan>();
            CustomCard.BuildCard<HighPowerScope>();
            CustomCard.BuildCard<SwiftReactions>();
            CustomCard.BuildCard<MunitionsCase>();
            CustomCard.BuildCard<Intervention>();
            CustomCard.BuildCard<RedPill>();
            CustomCard.BuildCard<BluePill>();
            CustomCard.BuildCard<GreenPill>();
            CustomCard.BuildCard<ButtStock>();
            CustomCard.BuildCard<BlackTarHeroin>();
            CustomCard.BuildCard<ExtendedMagizine>();
            CustomCard.BuildCard<AvidVenter>();
            CustomCard.BuildCard<OverlyConfident>();
            CustomCard.BuildCard<OverlyDefensive>();
        }
    }
}
