using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using BPP.MonoBehaviours;
using BPP.RoundsEffects;
using BPP.Utilities;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace BPP.Cards
{
    class MakeshiftFullAuto : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.categories = new CardCategory[]
            {
                CustomCardCategories.instance.CardCategory("Guns")
            };
            cardInfo.allowMultiple = false;
            gun.attackSpeed = 0.20f;
            gun.reloadTimeAdd = 0.35f;
            gun.damage = 0.30f;
            gun.projectileSpeed = 0.65f;
            gun.knockback = 0.65f;
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
            return "Makeshift Full Auto";
        }
        protected override string GetDescription()
        {
            return "Greatly increases fire rate, if you are willing to suffer the consequences.";
        }
        protected override GameObject GetCardArt()
        {
            return BPP.CardArt["MakeshiftFullAuto"];
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
                    stat = "ATKSPD",
                    amount = "+80%",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Damage",
                    amount = "-70%",
                    simepleAmount = CardInfoStat.SimpleAmount.aLotLower
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload Time",
                    amount = "+0.35s",
                    simepleAmount = CardInfoStat.SimpleAmount.Some
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Bullet Speed",
                    amount = "-35%",
                    simepleAmount = CardInfoStat.SimpleAmount.lower
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Knockback",
                    amount = "-35%",
                    simepleAmount = CardInfoStat.SimpleAmount.lower
                }
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