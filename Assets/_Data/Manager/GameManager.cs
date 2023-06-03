using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : LoboBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get => _instance; }

    protected override void Awake()
    {
        base.Awake();
        if (GameManager._instance != null) Debug.LogError("only 1 GameManager allow to exist");
        GameManager._instance = this;
    }
    public virtual void Start()
    {
        UICtrl.Instance.pauseMenu.SetActive(false);
    }
    public virtual  void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
