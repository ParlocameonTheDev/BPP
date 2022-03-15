﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using ModdingUtils.Extensions;
using ModdingUtils.Utils;
using BPP.MonoBehaviours;
using BPP.RoundsEffects;
using BPP.Utilities;
using UnboundLib;
using UnboundLib.Cards;
using UnboundLib.Utils;
using UnityEngine;

namespace BPP.Cards
{
	internal class ArmsDealer : CustomCard
	{
		public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers)
		{
			cardInfo.GetAdditionalData().canBeReassigned = false;
			cardInfo.categories = new CardCategory[]
			{
				CustomCardCategories.instance.CardCategory("CardManipulation")
			};
		}

		public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
		{
			CardInfo cardInfo = ModdingUtils.Utils.Cards.instance.NORARITY_GetRandomCardWithCondition(player, gun, gunAmmo, data, health, gravity, block, characterStats, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			bool flag = cardInfo == null;
			if (flag)
			{
				CardInfo[] cardsToDrawFrom = ((ObservableCollection<CardInfo>)typeof(CardManager).GetField("activeCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToList<CardInfo>().Concat((List<CardInfo>)typeof(CardManager).GetField("inactiveCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToArray<CardInfo>();
				cardInfo = ModdingUtils.Utils.Cards.instance.DrawRandomCardWithCondition(cardsToDrawFrom, player, null, null, null, null, null, null, null, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			}
			ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, cardInfo, false, "", 0f, 0f, true);
			CardBarUtils.instance.ShowAtEndOfPhase(player, cardInfo);
		}

		public override void OnRemoveCard()
		{
		}

		protected override string GetTitle()
		{
			return "Arms Dealer";
		}

		protected override GameObject GetCardArt()
		{
			return BPP.CardArt["ArmsDealer"];
		}

		protected override string GetDescription()
		{
			return "Get a random <b><color=#ff0000>gun-related</b></color> card from BPP.";
		}

		protected override CardInfo.Rarity GetRarity()
		{
			return CardInfo.Rarity.Uncommon;
		}

		protected override CardInfoStat[] GetStats()
		{
			return null;
		}

		protected override CardThemeColor.CardThemeColorType GetTheme()
		{
			return CardThemeColor.CardThemeColorType.FirepowerYellow;
		}

		public override string GetModName()
		{
			return BPP.ModInitials;
		}

		public bool condition(CardInfo card, Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
		{
			return card.categories.Intersect(ArmsDealer.gunCards).Any<CardCategory>();
		}

		public static CardCategory[] gunCards = new CardCategory[]
		{
			CustomCardCategories.instance.CardCategory("Guns")
		};
	}
}