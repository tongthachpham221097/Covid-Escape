using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGameOver : BaseSound
{
    public void PlaySound()
    {
        this.audioSource.Play();
    }
}
