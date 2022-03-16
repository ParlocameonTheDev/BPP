using System;
using System.Collections.Generic;
using ModdingUtils.RoundsEffects;
using Sonigon;
using Sonigon.Internal;
using UnityEngine;

namespace BPP.RoundsEffects
{
	internal class BankShotEffect : HitSurfaceEffect
	{
		public override void Hit(Vector2 position, Vector2 normal, Vector2 velocity)
		{
			this.player = base.gameObject.GetComponent<Player>();
			this.soundParameterIntensity.intensity = 0.66f;
			SoundContainer soundContainer = ScriptableObject.CreateInstance<SoundContainer>();
			soundContainer.setting.volumeIntensityEnable = true;
			soundContainer.audioClip[0] = BPP.CustomAudio["BankShotAudio"];
			SoundEvent soundEvent = ScriptableObject.CreateInstance<SoundEvent>();
			soundEvent.soundContainerArray[0] = soundContainer;
			this.soundParameterIntensity.intensity *= BPP.globalVolMute.Value;
			SoundManager.Instance.Play(soundEvent, base.transform, new SoundParameterBase[]
			{
				this.soundParameterIntensity
			});
		}

		private Player player;

		private SoundParameterIntensity soundParameterIntensity = new SoundParameterIntensity(0f, UpdateMode.Continuous);
	}
}