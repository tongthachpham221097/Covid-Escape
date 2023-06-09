using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : LoboBehaviour
{
    private static SoundManager _instance;
    public static SoundManager Instance { get => _instance; }

    [SerializeField] private SoundBG _soundBG;
    public SoundBG SoundBG { get => _soundBG; }

    [SerializeField] private SoundStartGame _soundStartGame;
    public SoundStartGame SoundStartGame { get => _soundStartGame; }

    [SerializeField] private SoundGameOver _soundGameOver;
    public SoundGameOver SoundGameOver { get => _soundGameOver; }

    [SerializeField] private SoundFX _soundFX;
    public SoundFX SoundFX { get => _soundFX; }

    protected override void Awake()
    {
        if (SoundManager._instance != null) Debug.LogError("only 1 InputManager allow to exist");
        SoundManager._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSoundBG();
        this.LoadSoundStartGame();
        this.LoadSoundGameOver();
        this.LoadSoundFX();
    }

    void LoadSoundBG()
    {
        if (this._soundBG != null) return;
        this._soundBG = GetComponentInChildren<SoundBG>();
        Debug.LogWarning(transform.name + ": LoadSoundBG", gameObject);
    }

    void LoadSoundStartGame()
    {
        if (this._soundStartGame != null) return;
        this._soundStartGame = GetComponentInChildren<SoundStartGame>();
        Debug.LogWarning(transform.name + ": LoadSoundStartGame", gameObject);
    }

    void LoadSoundGameOver()
    {
        if (this._soundGameOver != null) return;
        this._soundGameOver = GetComponentInChildren<SoundGameOver>();
        Debug.LogWarning(transform.name + ": LoadSoundGameOver", gameObject);
    }

    void LoadSoundFX()
    {
        if (this._soundFX != null) return;
        this._soundFX = GetComponentInChildren<SoundFX>();
        Debug.LogWarning(transform.name + ": LoadSoundFX", gameObject);
    }
}
