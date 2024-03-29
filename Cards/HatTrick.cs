﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using ModdingUtils.Extensions;
using ModdingUtils.Utils;
using UnboundLib.Cards;
using UnboundLib.Utils;
using UnityEngine;

namespace BPP.Cards
{
    internal class HatTrick : CustomCard
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
			CardInfo cardInfo2 = ModdingUtils.Utils.Cards.instance.NORARITY_GetRandomCardWithCondition(player, gun, gunAmmo, data, health, gravity, block, characterStats, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			bool flag2 = cardInfo2 == null;
			if (flag2)
			{
				CardInfo[] cardsToDrawFrom2 = ((ObservableCollection<CardInfo>)typeof(CardManager).GetField("activeCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToList<CardInfo>().Concat((List<CardInfo>)typeof(CardManager).GetField("inactiveCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToArray<CardInfo>();
				cardInfo2 = ModdingUtils.Utils.Cards.instance.DrawRandomCardWithCondition(cardsToDrawFrom2, player, null, null, null, null, null, null, null, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			}
			ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, cardInfo2, false, "", 0f, 0f, true);
			CardBarUtils.instance.ShowAtEndOfPhase(player, cardInfo2);
			CardInfo cardInfo3 = ModdingUtils.Utils.Cards.instance.NORARITY_GetRandomCardWithCondition(player, gun, gunAmmo, data, health, gravity, block, characterStats, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			bool flag3 = cardInfo3 == null;
			if (flag3)
			{
				CardInfo[] cardsToDrawFrom3 = ((ObservableCollection<CardInfo>)typeof(CardManager).GetField("activeCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToList<CardInfo>().Concat((List<CardInfo>)typeof(CardManager).GetField("inactiveCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToArray<CardInfo>();
				cardInfo3 = ModdingUtils.Utils.Cards.instance.DrawRandomCardWithCondition(cardsToDrawFrom3, player, null, null, null, null, null, null, null, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			}
			ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, cardInfo3, false, "", 0f, 0f, true);
			CardBarUtils.instance.ShowAtEndOfPhase(player, cardInfo3);
			CardInfo cardInfo4 = ModdingUtils.Utils.Cards.instance.NORARITY_GetRandomCardWithCondition(player, gun, gunAmmo, data, health, gravity, block, characterStats, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			bool flag4 = cardInfo4 == null;
			if (flag4)
			{
				CardInfo[] cardsToDrawFrom4 = ((ObservableCollection<CardInfo>)typeof(CardManager).GetField("activeCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToList<CardInfo>().Concat((List<CardInfo>)typeof(CardManager).GetField("inactiveCards", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null)).ToArray<CardInfo>();
				cardInfo4 = ModdingUtils.Utils.Cards.instance.DrawRandomCardWithCondition(cardsToDrawFrom4, player, null, null, null, null, null, null, null, new Func<CardInfo, Player, Gun, GunAmmo, CharacterData, HealthHandler, Gravity, Block, CharacterStatModifiers, bool>(this.condition), 1000);
			}
			ModdingUtils.Utils.Cards.instance.AddCardToPlayer(player, cardInfo4, false, "", 0f, 0f, true);
			CardBarUtils.instance.ShowAtEndOfPhase(player, cardInfo4);
		}

		public override void OnRemoveCard()
		{
		}

		protected override string GetTitle()
		{
			return "Hat Trick";
		}

		protected override GameObject GetCardArt()
		{
			return BPP.CardArt["HatTrick"];
		}

		protected override string GetDescription()
		{
			return "Get four random <b>common</b> cards.";
		}

		protected override CardInfo.Rarity GetRarity()
		{
			return CardInfo.Rarity.Rare;
		}

		protected override CardInfoStat[] GetStats()
		{
			return null;
		}

		protected override CardThemeColor.CardThemeColorType GetTheme()
		{
			return CardThemeColor.CardThemeColorType.TechWhite;
		}

		public override string GetModName()
		{
			return BPP.ModInitials;
		}

		public bool condition(CardInfo card, Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
		{
			return card.rarity == CardInfo.Rarity.Common && !card.categories.Intersect(HatTrick.noLotteryCategories).Any<CardCategory>();
		}

		public static CardCategory[] noLotteryCategories = new CardCategory[]
		{
			CustomCardCategories.instance.CardCategory("CardManipulation"),
			CustomCardCategories.instance.CardCategory("NoRandom")
		};
	}
}