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
            UnityEngine.Debug.Log("BPP cards have been loaded into the client successfully!");

            // Freely Available Cards
            CustomCard.BuildCard<AcceleratedBackHopping>();
            CustomCard.BuildCard<Dash>();
            CustomCard.BuildCard<DashMk2>();
            CustomCard.BuildCard<MuzzleBoost>();
            CustomCard.BuildCard<AtomicAmmunition>();
            CustomCard.BuildCard<BloodAmmunition>();
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
            CustomCard.BuildCard<NoScope>();
            CustomCard.BuildCard<Nuclear>();
            CustomCard.BuildCard<BigBang>();
            CustomCard.BuildCard<CondensedShot>();
            CustomCard.BuildCard<DoubleShot>();
            CustomCard.BuildCard<TrustyPan>();
            CustomCard.BuildCard<TrustyPanUltraSuperXL>();
            CustomCard.BuildCard<Coilgun>();
            CustomCard.BuildCard<Splatter>();
            CustomCard.BuildCard<AA12>();
            CustomCard.BuildCard<GroundPound>();
            CustomCard.BuildCard<P90>();
            CustomCard.BuildCard<GamerAmmunition>();
            CustomCard.BuildCard<AngelicBurst>();
            CustomCard.BuildCard<FuturisticMagazine>();
            CustomCard.BuildCard<AmmoEnthusiast>();
            CustomCard.BuildCard<Parry>();
            CustomCard.BuildCard<Stockpile>();
            CustomCard.BuildCard<SixShooter>();
            CustomCard.BuildCard<Horizon>();
            CustomCard.BuildCard<Stimulants>();
            CustomCard.BuildCard<YellowPill>();
            CustomCard.BuildCard<PurplePill>();
            CustomCard.BuildCard<WhitePill>();
            CustomCard.BuildCard<WoundingAmmunition>();
            CustomCard.BuildCard<SpaciousAmmunition>();
            CustomCard.BuildCard<FlexSeal>();
            CustomCard.BuildCard<Fisticuffs>();
            CustomCard.BuildCard<Vector>();
            CustomCard.BuildCard<AntiMaterialRifle>();
            CustomCard.BuildCard<Addict>();
            CustomCard.BuildCard<HatTrick>();
            CustomCard.BuildCard<Ascension>();
            CustomCard.BuildCard<MuzzleBrake>();
            CustomCard.BuildCard<MuzzleFlash>();
            CustomCard.BuildCard<Foregrip>();
            CustomCard.BuildCard<Suppressor>();

            // Sabotager Class
            CustomCard.BuildCard<Sabotager>((card) => Sabotager.Card = card);
            CustomCard.BuildCard<Chained>((card) => Chained.Card = card);
            CustomCard.BuildCard<Culling>((card) => Culling.Card = card);
            CustomCard.BuildCard<Sluggish>((card) => Sluggish.Card = card);
            CustomCard.BuildCard<FakeCaliber>((card) => FakeCaliber.Card = card);
            CustomCard.BuildCard<Clumsy>((card) => Clumsy.Card = card);
        }

        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("bppart", typeof(BPP).Assembly);


    public static Dictionary<String, GameObject> CardArtDictionary()
        {
            Dictionary<String, GameObject> cardArt = new Dictionary<String, GameObject>();

            UnityEngine.Debug.Log("BPP card art have been loaded into the client successfully!");
            cardArt.Add("AA12", Bundle.LoadAsset<GameObject>("C_AA12"));
            cardArt.Add("AcceleratedBackHopping", Bundle.LoadAsset<GameObject>("C_AcceleratedBackHopping"));
            cardArt.Add("Dash", Bundle.LoadAsset<GameObject>("C_Dash"));
            cardArt.Add("DashMK2", Bundle.LoadAsset<GameObject>("C_DashMK2"));
            cardArt.Add("SwiftReactions", Bundle.LoadAsset<GameObject>("C_SwiftReactions"));
            cardArt.Add("CondensedShot", Bundle.LoadAsset<GameObject>("C_CondensedShot"));
            cardArt.Add("HighPowerScope", Bundle.LoadAsset<GameObject>("C_HighPowerScope"));
            cardArt.Add("NoScope", Bundle.LoadAsset<GameObject>("C_NoScope"));
            cardArt.Add("P90", Bundle.LoadAsset<GameObject>("C_P90"));
            cardArt.Add("MunitionsPack", Bundle.LoadAsset<GameObject>("C_MunitionsPack"));
            cardArt.Add("BluePill", Bundle.LoadAsset<GameObject>("C_BluePill"));
            cardArt.Add("GreenPill", Bundle.LoadAsset<GameObject>("C_GreenPill"));
            cardArt.Add("RedPill", Bundle.LoadAsset<GameObject>("C_RedPill"));
            cardArt.Add("Nuclear", Bundle.LoadAsset<GameObject>("C_Nuclear"));
            cardArt.Add("TrustyPan", Bundle.LoadAsset<GameObject>("C_TrustyPan"));
            cardArt.Add("TrustyPanUltraSuperXL", Bundle.LoadAsset<GameObject>("C_TrustyPanUltraSuperXL"));
            cardArt.Add("GroundPound", Bundle.LoadAsset<GameObject>("C_GroundPound"));
            cardArt.Add("ButtStock", Bundle.LoadAsset<GameObject>("C_ButtStock"));
            cardArt.Add("DoubleShot", Bundle.LoadAsset<GameObject>("C_DoubleShot"));
            cardArt.Add("BlackTarHeroin", Bundle.LoadAsset<GameObject>("C_BlackTarHeroin"));
            cardArt.Add("Coilgun", Bundle.LoadAsset<GameObject>("C_Coilgun"));
            cardArt.Add("ExtendedMagizine", Bundle.LoadAsset<GameObject>("C_ExtendedMagizine"));
            cardArt.Add("AtomicAmmunition", Bundle.LoadAsset<GameObject>("C_AtomicAmmunition"));
            cardArt.Add("BloodAmmunition", Bundle.LoadAsset<GameObject>("C_BloodAmmunition"));
            cardArt.Add("GamerAmmunition", Bundle.LoadAsset<GameObject>("C_GamerAmmunition"));
            cardArt.Add("BigBang", Bundle.LoadAsset<GameObject>("C_BigBang"));
            cardArt.Add("OverlyConfident", Bundle.LoadAsset<GameObject>("C_OverlyConfident"));
            cardArt.Add("OverlyDefensive", Bundle.LoadAsset<GameObject>("C_OverlyDefensive"));
            cardArt.Add("RapidFire", Bundle.LoadAsset<GameObject>("C_RapidFire"));
            cardArt.Add("Splatter", Bundle.LoadAsset<GameObject>("C_Splatter"));
            cardArt.Add("Ascension", Bundle.LoadAsset<GameObject>("C_Ascension"));
            cardArt.Add("AngelicBurst", Bundle.LoadAsset<GameObject>("C_AngelicBurst"));
            cardArt.Add("FuturisticMagazine", Bundle.LoadAsset<GameObject>("C_FuturisticMagazine"));
            cardArt.Add("AmmoEnthusiast", Bundle.LoadAsset<GameObject>("C_AmmoEnthusiast"));
            cardArt.Add("Parry", Bundle.LoadAsset<GameObject>("C_Parry"));
            cardArt.Add("Stockpile", Bundle.LoadAsset<GameObject>("C_Stockpile"));
            cardArt.Add("SixShooter", Bundle.LoadAsset<GameObject>("C_SixShooter"));
            cardArt.Add("Horizon", Bundle.LoadAsset<GameObject>("C_Horizon"));
            cardArt.Add("Stimulants", Bundle.LoadAsset<GameObject>("C_Stimulants"));
            cardArt.Add("YellowPill", Bundle.LoadAsset<GameObject>("C_YellowPill"));
            cardArt.Add("PurplePill", Bundle.LoadAsset<GameObject>("C_PurplePill"));
            cardArt.Add("WhitePill", Bundle.LoadAsset<GameObject>("C_WhitePill"));
            cardArt.Add("WoundingAmmunition", Bundle.LoadAsset<GameObject>("C_WoundingAmmunition"));
            cardArt.Add("SpaciousAmmunition", Bundle.LoadAsset<GameObject>("C_SpaciousAmmunition"));
            cardArt.Add("FlexSeal", Bundle.LoadAsset<GameObject>("C_FlexSeal"));
            cardArt.Add("Fisticuffs", Bundle.LoadAsset<GameObject>("C_Fisticuffs"));
            cardArt.Add("Vector", Bundle.LoadAsset<GameObject>("C_Vector"));
            cardArt.Add("AntiMaterialRifle", Bundle.LoadAsset<GameObject>("C_AntiMaterialRifle"));
            cardArt.Add("Addict", Bundle.LoadAsset<GameObject>("C_Addict"));
            cardArt.Add("HatTrick", Bundle.LoadAsset<GameObject>("C_HatTrick"));
            cardArt.Add("MuzzleBrake", Bundle.LoadAsset<GameObject>("C_MuzzleBrake"));
            cardArt.Add("MuzzleFlash", Bundle.LoadAsset<GameObject>("C_MuzzleFlash"));
            cardArt.Add("Foregrip", Bundle.LoadAsset<GameObject>("C_Foregrip"));
            cardArt.Add("Suppressor", Bundle.LoadAsset<GameObject>("C_Suppressor"));
            cardArt.Add("Sabotager", Bundle.LoadAsset<GameObject>("C_Sabotager"));

            return cardArt;

        }

        public static Dictionary<String, AudioClip> AudioClipDictionary()
        {
            Dictionary<String, AudioClip> audioClip = new Dictionary<String, AudioClip>();

            UnityEngine.Debug.Log("BPP audio have been loaded into the client successfully!");
            audioClip.Add("ReflectAudio", Bundle.LoadAsset<AudioClip>("A_Reflect"));
            audioClip.Add("AtomicAudio", Bundle.LoadAsset<AudioClip>("A_Atomic"));
            audioClip.Add("DashAudio", Bundle.LoadAsset<AudioClip>("A_Dash"));

            return audioClip;

        }

    }
}
