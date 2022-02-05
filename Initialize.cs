using System;
using System.Collections.Generic;
using System.Text;
using UnboundLib.Cards;
using BPP.Cards;
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
            
            CustomCard.BuildCard<RapidFire>();
            
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
            
            CustomCard.BuildCard<ExtendedMagizine>();
            
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

            CustomCard.BuildCard<TacticalGloves>();

            //Potentially bugged? Disable/Comment before release until confirmed working
            //CustomCard.BuildCard<LiquidCourage>();
        }

        //Initializes Card Art

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

            return cardArt;

        }

    }
}
