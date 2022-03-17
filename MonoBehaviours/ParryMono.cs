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
    internal class ParryMono : ReversibleEffect
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

            duration = 0.01f;
        }

        public override void OnStart()
        {
            gunStatModifier.damage_mult = 2f;
            gunStatModifier.knockback_mult = 2f;
            gunStatModifier.projectileSpeed_mult = 2f;
            gunStatModifier.attackSpeed_mult = 2f;
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
    }
}