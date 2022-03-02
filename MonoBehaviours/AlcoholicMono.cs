using UnityEngine;
using ModdingUtils.MonoBehaviours;
using UnboundLib.Cards;
using UnboundLib;
using ModdingUtils.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using BPP.Cards;

namespace BPP.MonoBehaviours
{
	internal class Alcoholic : ReversibleEffect
	{
		private float duration = 0;
		public override void OnStart()
		{
			base.OnStart();
			base.SetLivesToEffect(int.MaxValue);
		}

		public override void OnUpdate()
        {

        }
		public Alcoholic()
		{

		}

		private bool inverted = false;
	}
}