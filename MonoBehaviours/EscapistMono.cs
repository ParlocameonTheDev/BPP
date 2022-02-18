using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using BPP.Cards;
using ModdingUtils.MonoBehaviours;

namespace BPP.MonoBehaviours
{
    internal class EscapistMono : ReversibleEffect
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

            // 0.5 might need to be increased, gotta test how powerful the card is though.
            // duration = 0.5f;
            // (it was too little :[ )

            duration = 0.75f;

        }

        public override void OnStart()
        {
            characterStatModifiersModifier.movementSpeed_mult = 4f;
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