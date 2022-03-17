using System;
using System.Collections.Generic;
using ModdingUtils.RoundsEffects;
using Sonigon;
using Sonigon.Internal;
using UnityEngine;

namespace BPP.RoundsEffects
{
	internal class VineEffect : HitSurfaceEffect
	{
		public override void Hit(Vector2 position, Vector2 normal, Vector2 velocity)
		{
			this.player = base.gameObject.GetComponent<Player>();
			this.soundParameterIntensity.intensity = 0.8f;
			SoundContainer soundContainer = ScriptableObject.CreateInstance<SoundContainer>();
			soundContainer.setting.volumeIntensityEnable = true;
			soundContainer.audioClip[0] = BPP.CustomAudio["VineBoomAudio"];
			SoundEvent soundEvent = ScriptableObject.CreateInstance<SoundEvent>();
			soundEvent.soundContainerArray[0] = soundContainer;
			this.soundParameterIntensity.intensity = base.transform.localScale.x * Optionshandler.vol_Sfx / 1f * BPP.globalVolMute.Value * Optionshandler.vol_Master;
			SoundManager.Instance.Play(soundEvent, base.transform, new SoundParameterBase[]
			{
				this.soundParameterIntensity
			});
		}

		private Player player;

		private SoundParameterIntensity soundParameterIntensity = new SoundParameterIntensity(0f, UpdateMode.Continuous);
	}
}