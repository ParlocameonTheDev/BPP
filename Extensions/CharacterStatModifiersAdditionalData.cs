using System;

namespace BPP.Extensions
{
	public class CharacterStatModifiersAdditionalData
	{
		public CharacterStatModifiersAdditionalData()
		{
			this.useNewRespawnTime = false;
			this.newRespawnTime = 0f;
		}

		public bool useNewRespawnTime;

		public float newRespawnTime;
	}
}