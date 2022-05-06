using ClassesManagerReborn.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using BPP.MonoBehaviours;
using BPP.RoundsEffects;
using BPP.Utilities;
using UnboundLib.Cards;
using UnityEngine;

namespace BPP.Cards
{
    class Clumsy : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            foreach (Player player2 in PlayerManager.instance.players)
            {
                bool flag = player2.playerID != player.playerID;
                if (flag)
                {
                    player2.GetComponent<CharacterStatModifiers>().jump *= 0.75f;
                }
            }
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }

        internal static CardInfo Card = null;

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }
        protected override string GetTitle()
        {
            return "Clumsy";
        }
        protected override string GetDescription()
        {
            return "Make every player other than have less jump height.";
        }
        protected override GameObject GetCardArt()
        {
            return BPP.CardArt["Sabotager"];
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Other players jump height",
                    amount = "-25%",
                    simepleAmount = CardInfoStat.SimpleAmount.lower
                },
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.FirepowerYellow;
        }
        public override string GetModName()
        {
            return BPP.ModInitials;
        }
    }
}