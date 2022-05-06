using System;
using System.Collections.Generic;
using System.Linq;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using BPP.MonoBehaviours;
using BPP.Utilities;
using UnboundLib.Cards;
using UnityEngine;

namespace BPP.Cards
{
    class AntiMaterialRifle : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            cardInfo.categories = new CardCategory[]
            {
                CustomCardCategories.instance.CardCategory("Guns")
            };
            cardInfo.allowMultiple = false;
            gun.reloadTime = 4.00f;
            gun.damage = 4.00f;
            gun.knockback = 4.00f;
            gun.destroyBulletAfter = 20.00f;
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            List<ObjectsToSpawn> list = gun.objectsToSpawn.ToList<ObjectsToSpawn>();
            list.Add(new ObjectsToSpawn
            {
                AddToProjectile = new GameObject("A_Golden", new Type[]
                {
                    typeof(AMRMono)
                })
            });
            gun.objectsToSpawn = list.ToArray();

            gun.spread = 0f;
            gunAmmo.maxAmmo = 1;
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            BPPDebug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }
        protected override string GetTitle()
        {
            return "Anti Material Rifle";
        }
        protected override string GetDescription()
        {
            return "Bullets halve the players health for 5 seconds.";
        }
        protected override GameObject GetCardArt()
        {
            return BPP.CardArt["AntiMaterialRifle"];
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Damage",
                    amount = "+300%",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Knockback",
                    amount = "+300%",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
                },
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Bullet Range",
                    amount = "Reset",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Max Ammo",
                    amount = "1",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Reload Time",
                    amount = "+300%",
                    simepleAmount = CardInfoStat.SimpleAmount.aHugeAmountOf
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