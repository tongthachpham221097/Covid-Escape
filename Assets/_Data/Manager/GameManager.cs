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

    private void Update()
    {
        if(PlayerCtrl.Instance.PlayerCollider.isGameOver == true) this.GameOver();
    }

    public virtual  void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public virtual void GameOver()
    {
        UICtrl.Instance.scoreTextGameOver.SetTextGameOver();
        UICtrl.Instance.gameOverMenu.SetActive(true);
        UICtrl.Instance.scoreText.gameObject.SetActive(false);
        ObstacleSpawner.Instance.gameObject.SetActive(false);
    }
}
