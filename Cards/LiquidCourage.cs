using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPP.MonoBehaviors;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;

namespace BPP.Cards
{
    class LiquidCourage : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            cardInfo.allowMultiple = false;

            //Positive Stats
            gun.numberOfProjectiles = 3;
            gun.ammo = 3;
            gun.knockback = 3f;

            UnityEngine.Debug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been setup.");
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            player.gameObject.AddComponent<Alcoholic>();

            //Edits values on player when card is selected

            //Negative Stats
            gun.spread /= 3f;
            gun.reloadTime /= 3f;
            gun.attackSpeed /= 3f;

            UnityEngine.Debug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");
        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            GameObject.Destroy(player.gameObject.GetComponent<Alcoholic>());

            //Run when the card is removed from the player
            UnityEngine.Debug.Log($"[{BPP.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");
        }
        protected override string GetTitle()
        {
            return "Liquid Courage";
        }
        protected override string GetDescription()
        {
            return "TRIPLES(negative and positive depending on effect to player) your gun's stats, but inverts your controls(NOT JUST MOVEMENT) every 5-10 seconds for 6 seconds.\n\"WHERE THE HELL AM I?!?!?!?\"";
        }
        protected override GameObject GetCardArt()
        {
            return null;
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
                    stat = "Everything",
                    amount = "3x",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.MagicPink;
        }
        public override string GetModName()
        {
            return BPP.ModInitials;
        }
    }
}