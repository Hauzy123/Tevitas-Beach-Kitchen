using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WaveSound : MonoBehaviour
{
      public void SoundWave()
	{
		AudioManager.Instance.PlaySFX("Wave");
	}
}
