using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BaseSound : LoboBehaviour
{
    public AudioSource audioSource;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadAudioSource();
    }

    void LoadAudioSource()
    {
        if (this.audioSource != null) return;
        this.audioSource = GetComponent<AudioSource>();
        Debug.LogWarning(transform.name + ": LoadAudioSource", gameObject);
    }

}
