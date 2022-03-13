using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using UnboundLib.Cards;
using UnboundLib.GameModes;
using BPP.Cards;
using BPP.MonoBehaviours;
using UnityEngine;

namespace BPP
{
    internal class Initialize
    {

        public static void Cards()
        {
            CustomCard.BuildCard<AcceleratedBackHopping>();
            CustomCard.BuildCard<Dash>();
            CustomCard.BuildCard<DashMk2>();
            CustomCard.BuildCard<DesignatedMarksmanRifle>();
            CustomCard.BuildCard<MuzzleBoost>();
            CustomCard.BuildCard<MakeshiftFullAuto>();
            CustomCard.BuildCard<AtomicAmmunition>();
            CustomCard.BuildCard<BloodAmmunition>();
            CustomCard.BuildCard<Weights>();
            CustomCard.BuildCard<Minigun>();
            CustomCard.BuildCard<HighPowerScope>();
            CustomCard.BuildCard<SwiftReactions>();
            CustomCard.BuildCard<MunitionsPack>();
            CustomCard.BuildCard<RedPill>();
            CustomCard.BuildCard<BluePill>();
            CustomCard.BuildCard<GreenPill>();
            CustomCard.BuildCard<ButtStock>();
            CustomCard.BuildCard<BlackTarHeroin>();
            CustomCard.BuildCard<EnlargedMagazine>();
            CustomCard.BuildCard<OverlyConfident>();
            CustomCard.BuildCard<OverlyDefensive>();
            CustomCard.BuildCard<Sparatic>();
            CustomCard.BuildCard<NoScope>();
            CustomCard.BuildCard<BankShot>();
            CustomCard.BuildCard<Nuclear>();
            CustomCard.BuildCard<BigBang>();
            CustomCard.BuildCard<CondensedShot>();
            CustomCard.BuildCard<DoubleShot>();
            CustomCard.BuildCard<TrustyPan>();
            CustomCard.BuildCard<TrustyPanUltraSuperXL>();
            CustomCard.BuildCard<Coilgun>();
            CustomCard.BuildCard<Splatter>();
            CustomCard.BuildCard<Nailgun>();
            CustomCard.BuildCard<SpeedTape>();
            CustomCard.BuildCard<AA12>();
            CustomCard.BuildCard<GroundPound>();
            CustomCard.BuildCard<PumpAction>();
            CustomCard.BuildCard<P90>();
            CustomCard.BuildCard<OldFashioned>();
            CustomCard.BuildCard<GamerAmmunition>();
            CustomCard.BuildCard<Intervention>();
            CustomCard.BuildCard<TacticalGloves>();
            CustomCard.BuildCard<RiggedSlippers>();
            CustomCard.BuildCard<SurgicalKit>();
            CustomCard.BuildCard<SteelAmmunition>();
            CustomCard.BuildCard<Inversion>();
            CustomCard.BuildCard<Hoverboard>();
            CustomCard.BuildCard<Escapist>();
            CustomCard.BuildCard<AngelicBurst>();
            CustomCard.BuildCard<FuturisticMagazine>();
            CustomCard.BuildCard<AmmoEnthusiast>();
            CustomCard.BuildCard<Parry>();
            CustomCard.BuildCard<Stockpile>();
            CustomCard.BuildCard<CounterIntuitive>();
            CustomCard.BuildCard<SixShooter>();
            CustomCard.BuildCard<Horizon>();
            CustomCard.BuildCard<Stimulants>();
            CustomCard.BuildCard<Slugs>();
            CustomCard.BuildCard<YellowPill>();
            CustomCard.BuildCard<PurplePill>();
            CustomCard.BuildCard<WhitePill>();
            CustomCard.BuildCard<WoundingAmmunition>();
            CustomCard.BuildCard<SpaciousAmmunition>();
            CustomCard.BuildCard<GravityGun>();
            CustomCard.BuildCard<M249>();
            CustomCard.BuildCard<FlexSeal>();
            CustomCard.BuildCard<Fisticuffs>();
            CustomCard.BuildCard<Compression>();
            CustomCard.BuildCard<Vector>();
            CustomCard.BuildCard<AntiMaterialRifle>();
            CustomCard.BuildCard<PepperGun>();
            CustomCard.BuildCard<ArmsDealer>();

            //      Disabled cards, either they aren't finished, they brokey, or are heavily unbalanced.
            // CustomCard.BuildCard<LiquidCourage>();
            // CustomCard.BuildCard<VineBoom>();
            // CustomCard.BuildCard<Ascension>();
        }

        public static void Managers()
        {
            //  Not being used yet, hehehe ha
        }

        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("bppart", typeof(BPP).Assembly);

    public static Dictionary<String, GameObject> CardArtDictionary()
        {
            Dictionary<String, GameObject> cardArt = new Dictionary<String, GameObject>();

            cardArt.Add("AA12", Bundle.LoadAsset<GameObject>("C_AA12"));
            cardArt.Add("AcceleratedBackHopping", Bundle.LoadAsset<GameObject>("C_AcceleratedBackHopping"));
            cardArt.Add("Dash", Bundle.LoadAsset<GameObject>("C_Dash"));
            cardArt.Add("DashMK2", Bundle.LoadAsset<GameObject>("C_DashMK2"));
            cardArt.Add("SwiftReactions", Bundle.LoadAsset<GameObject>("C_SwiftReactions"));
            cardArt.Add("CondensedShot", Bundle.LoadAsset<GameObject>("C_CondensedShot"));
            cardArt.Add("DesignatedMarksmanRifle", Bundle.LoadAsset<GameObject>("C_DesignatedMarksmanRifle"));
            cardArt.Add("HighPowerScope", Bundle.LoadAsset<GameObject>("C_HighPowerScope"));
            cardArt.Add("Minigun", Bundle.LoadAsset<GameObject>("C_Minigun"));
            cardArt.Add("Nailgun", Bundle.LoadAsset<GameObject>("C_Nailgun"));
            cardArt.Add("NoScope", Bundle.LoadAsset<GameObject>("C_NoScope"));
            cardArt.Add("P90", Bundle.LoadAsset<GameObject>("C_P90"));
            cardArt.Add("PumpAction", Bundle.LoadAsset<GameObject>("C_PumpAction"));
            cardArt.Add("SpeedTape", Bundle.LoadAsset<GameObject>("C_SpeedTape"));
            cardArt.Add("TacticalGloves", Bundle.LoadAsset<GameObject>("C_TacticalGloves"));
            cardArt.Add("MunitionsPack", Bundle.LoadAsset<GameObject>("C_MunitionsPack"));
            cardArt.Add("BluePill", Bundle.LoadAsset<GameObject>("C_BluePill"));
            cardArt.Add("GreenPill", Bundle.LoadAsset<GameObject>("C_GreenPill"));
            cardArt.Add("RedPill", Bundle.LoadAsset<GameObject>("C_RedPill"));
            cardArt.Add("Nuclear", Bundle.LoadAsset<GameObject>("C_Nuclear"));
            cardArt.Add("TrustyPan", Bundle.LoadAsset<GameObject>("C_TrustyPan"));
            cardArt.Add("TrustyPanUltraSuperXL", Bundle.LoadAsset<GameObject>("C_TrustyPanUltraSuperXL"));
            cardArt.Add("GroundPound", Bundle.LoadAsset<GameObject>("C_GroundPound"));
            cardArt.Add("Weights", Bundle.LoadAsset<GameObject>("C_Weights"));
            cardArt.Add("ButtStock", Bundle.LoadAsset<GameObject>("C_ButtStock"));
            cardArt.Add("OldFashioned", Bundle.LoadAsset<GameObject>("C_OldFashioned"));
            cardArt.Add("DoubleShot", Bundle.LoadAsset<GameObject>("C_DoubleShot"));
            cardArt.Add("BlackTarHeroin", Bundle.LoadAsset<GameObject>("C_BlackTarHeroin"));
            cardArt.Add("Coilgun", Bundle.LoadAsset<GameObject>("C_Coilgun"));
            cardArt.Add("MakeshiftFullAuto", Bundle.LoadAsset<GameObject>("C_MakeshiftFullAuto"));
            cardArt.Add("LiquidCourage", Bundle.LoadAsset<GameObject>("C_LiquidCourage"));
            cardArt.Add("ExtendedMagizine", Bundle.LoadAsset<GameObject>("C_ExtendedMagizine"));
            cardArt.Add("AtomicAmmunition", Bundle.LoadAsset<GameObject>("C_AtomicAmmunition"));
            cardArt.Add("BloodAmmunition", Bundle.LoadAsset<GameObject>("C_BloodAmmunition"));
            cardArt.Add("GamerAmmunition", Bundle.LoadAsset<GameObject>("C_GamerAmmunition"));
            cardArt.Add("BankShot", Bundle.LoadAsset<GameObject>("C_BankShot"));
            cardArt.Add("BigBang", Bundle.LoadAsset<GameObject>("C_BigBang"));
            cardArt.Add("OverlyConfident", Bundle.LoadAsset<GameObject>("C_OverlyConfident"));
            cardArt.Add("OverlyDefensive", Bundle.LoadAsset<GameObject>("C_OverlyDefensive"));
            cardArt.Add("RapidFire", Bundle.LoadAsset<GameObject>("C_RapidFire"));
            cardArt.Add("Sparatic", Bundle.LoadAsset<GameObject>("C_Sparatic"));
            cardArt.Add("Splatter", Bundle.LoadAsset<GameObject>("C_Splatter"));
            cardArt.Add("Intervention", Bundle.LoadAsset<GameObject>("C_Intervention"));
            cardArt.Add("RiggedSlippers", Bundle.LoadAsset<GameObject>("C_RiggedSlippers"));
            cardArt.Add("SurgicalKit", Bundle.LoadAsset<GameObject>("C_SurgicalKit"));
            cardArt.Add("SteelAmmunition", Bundle.LoadAsset<GameObject>("C_SteelAmmunition"));
            cardArt.Add("Inversion", Bundle.LoadAsset<GameObject>("C_Inversion"));
            cardArt.Add("Ascension", Bundle.LoadAsset<GameObject>("C_Ascension"));
            cardArt.Add("Escapist", Bundle.LoadAsset<GameObject>("C_Escapist"));
            cardArt.Add("Hoverboard", Bundle.LoadAsset<GameObject>("C_Hoverboard"));
            cardArt.Add("AngelicBurst", Bundle.LoadAsset<GameObject>("C_AngelicBurst"));
            cardArt.Add("FuturisticMagazine", Bundle.LoadAsset<GameObject>("C_FuturisticMagazine"));
            cardArt.Add("AmmoEnthusiast", Bundle.LoadAsset<GameObject>("C_AmmoEnthusiast"));
            cardArt.Add("Parry", Bundle.LoadAsset<GameObject>("C_Parry"));
            cardArt.Add("Stockpile", Bundle.LoadAsset<GameObject>("C_Stockpile"));
            cardArt.Add("CounterIntuitive", Bundle.LoadAsset<GameObject>("C_CounterIntuitive"));
            cardArt.Add("VineBoom", Bundle.LoadAsset<GameObject>("C_VineBoom"));
            cardArt.Add("SixShooter", Bundle.LoadAsset<GameObject>("C_SixShooter"));
            cardArt.Add("Horizon", Bundle.LoadAsset<GameObject>("C_Horizon"));
            cardArt.Add("Stimulants", Bundle.LoadAsset<GameObject>("C_Stimulants"));
            cardArt.Add("Slugs", Bundle.LoadAsset<GameObject>("C_Slugs"));
            cardArt.Add("YellowPill", Bundle.LoadAsset<GameObject>("C_YellowPill"));
            cardArt.Add("PurplePill", Bundle.LoadAsset<GameObject>("C_PurplePill"));
            cardArt.Add("WhitePill", Bundle.LoadAsset<GameObject>("C_WhitePill"));
            cardArt.Add("WoundingAmmunition", Bundle.LoadAsset<GameObject>("C_WoundingAmmunition"));
            cardArt.Add("SpaciousAmmunition", Bundle.LoadAsset<GameObject>("C_SpaciousAmmunition"));
            cardArt.Add("GravityGun", Bundle.LoadAsset<GameObject>("C_GravityGun"));
            cardArt.Add("M249", Bundle.LoadAsset<GameObject>("C_M249"));
            cardArt.Add("FlexSeal", Bundle.LoadAsset<GameObject>("C_FlexSeal"));
            cardArt.Add("Fisticuffs", Bundle.LoadAsset<GameObject>("C_Fisticuffs"));
            cardArt.Add("Compression", Bundle.LoadAsset<GameObject>("C_Compression"));
            cardArt.Add("Vector", Bundle.LoadAsset<GameObject>("C_Vector"));
            cardArt.Add("AntiMaterialRifle", Bundle.LoadAsset<GameObject>("C_AntiMaterialRifle"));
            cardArt.Add("PepperGun", Bundle.LoadAsset<GameObject>("C_PepperGun"));
            cardArt.Add("ArmsDealer", Bundle.LoadAsset<GameObject>("C_ArmsDealer"));

            return cardArt;

        }

        public static Dictionary<String, AudioClip> AudioClipDictionary()
        {
            Dictionary<String, AudioClip> audioClip = new Dictionary<String, AudioClip>();

            audioClip.Add("VineBoomAudio", Bundle.LoadAsset<AudioClip>("A_VineBoom"));

            return audioClip;

        }

    }
}
