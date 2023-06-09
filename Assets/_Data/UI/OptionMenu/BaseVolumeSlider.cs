using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseVolumeSlider : LoboBehaviour
{
    [Header("Base Volume Slider")]
    public Slider volumeSlider;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSlider();
    }
    protected virtual void LoadSlider()
    {
        this.volumeSlider = GetComponent<Slider>();
    }
}
