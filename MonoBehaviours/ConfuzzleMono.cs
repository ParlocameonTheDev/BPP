using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UnboundLib;
using UnboundLib.GameModes;
using UnityEngine;
using BPP.Cards;
using ModdingUtils.Extensions;
using ModdingUtils.Utils;
using ModdingUtils.MonoBehaviours;

namespace BPP.MonoBehaviours
{
    internal class ConfuzzleMono : ReversibleEffect
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

            duration = 2f;
        }

        public override void OnStart()
        {   
            characterStatModifiersModifier.movementSpeed_mult = 2f;
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