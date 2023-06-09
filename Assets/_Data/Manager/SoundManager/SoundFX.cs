using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : BaseSound
{
    public void PlaySound()
    {
        this.audioSource.Play();
    }
}
