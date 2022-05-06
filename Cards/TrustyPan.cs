using BPP.Utilities;
using UnboundLib.Cards;
using UnityEngine;

namespace BPP.Cards
{
    class TrustyPan : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            block.additionalBlocks = 1;
            block.cdAdd = 0.66f;
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }
        protected override string GetTitle()
        {
            return "Trusty Pan";
        }
        protected override string GetDescription()
        {
            return "This world-famous pan can block anything that may be in your way, sometimes, maybe...";
        }
        protected override GameObject GetCardArt()
        {
            return BPP.CardArt["TrustyPan"];
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Additional Blocks",
                    amount = "+1",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "+0.66s",
                    simepleAmount = CardInfoStat.SimpleAmount.aLotOf
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.NatureBrown;
        }
        public override string GetModName()
        {
            return BPP.ModInitials;
        }
    }
}