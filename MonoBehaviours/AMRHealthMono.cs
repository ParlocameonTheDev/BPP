using UnityEngine;
using ModdingUtils.MonoBehaviours;
using UnboundLib.Cards;
using UnboundLib;
using ModdingUtils.Extensions;
using Sonigon;
using Sonigon.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using BPP.Cards;

namespace BPP.MonoBehaviours
{
	public class AMRHealthMono : ReversibleEffect
	{

		public override void OnStart()
		{
			this.characterDataModifier.health_mult *= 0.5f;
			this.ResetEffectTimer();
			this.ResetTimer();
		}

		public override void OnUpdate()
		{
			if (Time.time >= this.startTime + this.updateDelay)
			{
				this.ResetTimer();
				if (Time.time >= this.timeOfLastEffect + this.effectCooldown)
				{
					base.Destroy();
				}
				if (base.GetComponent<Player>().data.dead || base.GetComponent<Player>().data.health <= 0f || !base.GetComponent<Player>().gameObject.activeInHierarchy)
				{
					this.ResetTimer();
					base.Destroy();
				}
			}
		}

		public override void OnOnDisable()
		{
			this.ResetEffectTimer();
			this.ResetTimer();
		}

		public override void OnOnDestroy()
		{
			this.ResetEffectTimer();
			this.ResetTimer();
		}

		private void ResetTimer()
		{
			this.startTime = Time.time;
		}
		private void ResetEffectTimer()
		{
			this.timeOfLastEffect = Time.time;
		}

		private readonly float updateDelay = 0.1f;

		private readonly float effectCooldown = 5f;

		private float startTime;

		private float timeOfLastEffect;
	}
}