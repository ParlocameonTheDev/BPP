using System;
using System.Collections.Generic;
using ModdingUtils.RoundsEffects;
using UnboundLib;
using UnityEngine;

namespace BPP.RoundsEffects
{
	internal class VineEffect : HitSurfaceEffect
	{
		public override void Hit(Vector2 position, Vector2 normal, Vector2 velocity)
		{
			this.player = base.gameObject.GetComponent<Player>();
			using (List<CardInfo>.Enumerator enumerator = this.player.data.currentCards.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.cardName.ToLower() == "toxic cloud")
					{
						this.hasToxic = true;
						break;
					}
				}
			}
			AudioSource orAddComponent = ExtensionMethods.GetOrAddComponent<AudioSource>(base.gameObject, false);
			if (this.hasToxic)
			{
				orAddComponent.PlayOneShot(BPP.CustomAudio["VineBoom"], 4f);
			}
			orAddComponent.PlayOneShot(BPP.CustomAudio["VineBoom"], 2f);
		}

		public VineEffect()
		{
		}

		private Player player;

		private bool hasToxic;
	}
}
