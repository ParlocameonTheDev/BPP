using BPP.MonoBehaviours;
using BPP.Utilities;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace BPP.Cards
{
    class SwiftReactions : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            block.forceToAddUp = 10.0f;
            block.cdAdd = 0.50f;
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            var mono = player.gameObject.GetOrAddComponent<SwiftReactionsMono>();
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            var mono = player.gameObject.GetOrAddComponent<SwiftReactionsMono>();
            UnityEngine.GameObject.Destroy(mono);
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }
        protected override string GetTitle()
        {
            return "Swift Reactions";
        }
        protected override string GetDescription()
        {
            return "Dashes you upwards when you block, allowing for a swift escape.";
        }
        protected override GameObject GetCardArt()
        {
            return BPP.CardArt["SwiftReactions"];
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
                    stat = "Upward force while dashing",
                    amount = "+10",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Block Cooldown",
                    amount = "+0.50s",
                    simepleAmount = CardInfoStat.SimpleAmount.Some
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.DefensiveBlue;
        }
        public override string GetModName()
        {
            return BPP.ModInitials;
        }
    }
}