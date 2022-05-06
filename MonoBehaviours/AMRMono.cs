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
	public class AMRMono : RayHitEffect
	{
		public override HasToReturn DoHitEffect(HitInfo hit)
		{
			if (!hit.transform)
			{
				return HasToReturn.canContinue;
			}
			CharacterStatModifiers component = hit.transform.GetComponent<CharacterStatModifiers>();
			AMRHealthMono component2 = hit.transform.GetComponent<AMRHealthMono>();
			if (hit.transform.GetComponent<DamageOverTime>())
			{
				if (component)
				{
					component.RPCA_AddSlow(2.2f, true);
				}
				if (!component2)
				{
					hit.transform.gameObject.AddComponent<AMRHealthMono>();
					if (!AMRMono.fieldsound)
					{
						AudioClip audioClip = BPP.CustomAudio["ReflectAudio"];
						SoundContainer soundContainer = ScriptableObject.CreateInstance<SoundContainer>();
						soundContainer.audioClip[0] = audioClip;
						soundContainer.setting.volumeIntensityEnable = true;
						AMRMono.fieldsound = ScriptableObject.CreateInstance<SoundEvent>();
						AMRMono.fieldsound.soundContainerArray[0] = soundContainer;
					}
					this.soundParameterIntensity.intensity = base.transform.localScale.x * Optionshandler.vol_Master * Optionshandler.vol_Sfx / 1f * BPP.globalVolMute.Value;
					SoundManager.Instance.Play(AMRMono.fieldsound, base.transform, new SoundParameterBase[]
					{
						this.soundParameterIntensity
					});
				}
			}
			return HasToReturn.canContinue;
		}

		public void Destroy()
		{
			UnityEngine.Object.Destroy(this);
		}
		public AMRMono()
		{
		}

		public static SoundEvent fieldsound;

		private SoundParameterIntensity soundParameterIntensity = new SoundParameterIntensity(0.7f, UpdateMode.Continuous);
	}
}
