using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance { get => _instance; }

    [SerializeField] protected bool isPausing = false;

    protected virtual void Awake()
    {
        if (UIManager._instance != null) Debug.LogError("only 1 InputManager allow to exist");
        UIManager._instance = this;
    }

    public virtual void UIStartGame()
    {
        UICtrl.Instance.pauseMenu.SetActive(false);
        UICtrl.Instance.optionMenu.SetActive(false);
        UICtrl.Instance.scoreText.gameObject.SetActive(false);
        UICtrl.Instance.gameOverMenu.SetActive(false);
        ObstacleSpawner.Instance.gameObject.SetActive(false);
        InputManager.Instance.gameObject.SetActive(false); 
    }

    private void Update()
    {
        if (InputManager.Instance.pressEsc) this.CheckPauseMenu();
    }
    void CheckPauseMenu()
    {
        if (this.isPausing == false) this.OnabelPauseMenu();
        else this.DisabelPauseMenu();
    }

    void OnabelPauseMenu()
    {
        UICtrl.Instance.pauseMenu.SetActive(true);
        this.isPausing = true;
        Time.timeScale = 0f;
    }
    void DisabelPauseMenu()
    {
        UICtrl.Instance.pauseMenu.SetActive(false);
        this.isPausing = false;
        Time.timeScale = 1f;
    }
    
}
