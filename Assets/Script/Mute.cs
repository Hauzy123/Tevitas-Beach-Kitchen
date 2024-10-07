using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
            AudioManager.Instance.PlaySFX("Click");
        }

        else 
        {
            AudioListener.volume = 1;
            AudioManager.Instance.PlaySFX("Click");
        }
        
    }
}
