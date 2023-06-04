using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICtrl : LoboBehaviour
{
    private static UICtrl _instance;
    public static UICtrl Instance { get => _instance; }

    public GameObject pauseMenu;
    public GameObject mainMenu;
    public GameObject scoreText;
    public GameObject optionMenu;
    protected override void Awake()
    {
        if (UICtrl._instance != null) Debug.LogError("only 1 UIManager allow to exist");
        UICtrl._instance = this;
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPauseMenu();
        this.LoadMainMenu();
        this.LoadScoreText();
        this.LoadOptionMenu();
    }

    void LoadPauseMenu()
    {
        if (this.pauseMenu != null) return;
        this.pauseMenu = GameObject.Find("PauseMenu");
        Debug.LogWarning(transform.name + ": LoadPauseMenu", gameObject);
    }

    void LoadMainMenu()
    {
        if (this.mainMenu != null) return;
        this.mainMenu = GameObject.Find("MainMenu");
        Debug.LogWarning(transform.name + ": LoadMainMenu", gameObject);
    }

    void LoadScoreText()
    {
        if (this.scoreText != null) return;
        this.scoreText = GameObject.Find("ScoreText");
        Debug.LogWarning(transform.name + ": LoadScoreText", gameObject);
    }

    void LoadOptionMenu()
    {
        if (this.optionMenu != null) return;
        this.optionMenu = GameObject.Find("OptionMenu");
        Debug.LogWarning(transform.name + ": LoadOptionMenu", gameObject);
    }
}
