using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboBehaviour
{
    private static UICtrl _instance;
    public static UICtrl Instance { get => _instance; }

    public GameObject pauseMenu;
    protected override void Awake()
    {
        if (UICtrl._instance != null) Debug.LogError("only 1 UIManager allow to exist");
        UICtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPauseMenu();
    }
    void LoadPauseMenu()
    {
        if (this.pauseMenu != null) return;
        this.pauseMenu = GameObject.Find("PauseMenu");
        Debug.LogWarning(transform.name + ": LoadPlayerCollider", gameObject);
    }
}
