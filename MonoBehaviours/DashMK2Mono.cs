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
    internal class DashMK2Mono : ReversibleEffect
    {
        private float duration = 0;
        public override void OnOnDestroy()
        {
            block.BlockAction = (Action<BlockTrigger.BlockTriggerType>)Delegate.Remove(block.BlockAction, new Action<BlockTrigger.BlockTriggerType>(OnBlock));
        }
        private void OnBlock(BlockTrigger.BlockTriggerType trigger)
        {
            if (duration <= 0)
            {
                ApplyModifiers();
            }

            duration = 0.20f;

            this.player = base.gameObject.GetComponent<Player>();
            this.soundParameterIntensity.intensity = 0.8f;
            SoundContainer soundContainer = ScriptableObject.CreateInstance<SoundContainer>();
            soundContainer.setting.volumeIntensityEnable = true;
            soundContainer.audioClip[0] = BPP.CustomAudio["DashAudio"];
            SoundEvent soundEvent = ScriptableObject.CreateInstance<SoundEvent>();
            soundEvent.soundContainerArray[0] = soundContainer;
            this.soundParameterIntensity.intensity = base.transform.localScale.x * Optionshandler.vol_Sfx / 1f * BPP.globalVolMute.Value * Optionshandler.vol_Master;
            SoundManager.Instance.Play(soundEvent, base.transform, new SoundParameterBase[]
            {
                this.soundParameterIntensity
            });
        }

        public override void OnStart()
        {
            characterStatModifiersModifier.movementSpeed_mult = 1.66f;
            block.BlockAction = (Action<BlockTrigger.BlockTriggerType>)Delegate.Combine(block.BlockAction, new Action<BlockTrigger.BlockTriggerType>(OnBlock));
            SetLivesToEffect(int.MaxValue);
        }
        public override void OnUpdate()
        {
            if (!(duration <= 0))
            {
                duration -= TimeHandler.deltaTime;
            }
            else
            {
                ClearModifiers();
            }
        }

        private Player player;

        private SoundParameterIntensity soundParameterIntensity = new SoundParameterIntensity(0f, UpdateMode.Continuous);
    }
}