using System;
using System.Runtime.CompilerServices;
using HarmonyLib;

namespace BPP.Extensions
{
	public static class CharacterStatModifiersExtension
	{
		public static CharacterStatModifiersAdditionalData GetAdditionalData(this CharacterStatModifiers characterstats)
		{
			return CharacterStatModifiersExtension.data.GetOrCreateValue(characterstats);
		}

		public static void AddData(this CharacterStatModifiers characterstats, CharacterStatModifiersAdditionalData value)
		{
			try
			{
				CharacterStatModifiersExtension.data.Add(characterstats, value);
			}
			catch (Exception)
			{
			}
		}

		static CharacterStatModifiersExtension()
		{
		}

		public static readonly ConditionalWeakTable<CharacterStatModifiers, CharacterStatModifiersAdditionalData> data = new ConditionalWeakTable<CharacterStatModifiers, CharacterStatModifiersAdditionalData>();

		[HarmonyPatch(typeof(CharacterStatModifiers), "ResetStats")]
		private class CharacterStatModifiersPatchResetStats
		{
			private static void Prefix(CharacterStatModifiers __instance)
			{
				__instance.GetAdditionalData().newRespawnTime = 0f;
				__instance.GetAdditionalData().useNewRespawnTime = false;
			}

			public CharacterStatModifiersPatchResetStats()
			{
			}
		}
	}
}