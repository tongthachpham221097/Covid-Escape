using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : LoboBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get => _instance; }

    public bool isGameOvering = false;


    protected override void Awake()
    {
        base.Awake();
        if (GameManager._instance != null) Debug.LogError("only 1 GameManager allow to exist");
        GameManager._instance = this;
    }

    private void Start()
    {
        this.StartingGame();
    }

    private void Update()
    {
        this.CheckGameOver();
    }

    void CheckGameOver()
    {
        if(this.isGameOvering) return;
        if (PlayerCtrl.Instance.PlayerCollider.isGameOver == true) this.GameOver();
    }

    public virtual  void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    void StartingGame()
    {
        SoundManager.Instance.SoundStartGame.PlaySound();
        UIManager.Instance.UIStartGame();
    }

    public void PlayGame()
    {
        UICtrl.Instance.mainMenu.gameObject.SetActive(false);
        UICtrl.Instance.scoreText.gameObject.SetActive(true);
        ObstacleSpawner.Instance.gameObject.SetActive(true);
        PlayerCtrl.Instance.PlayerMovement.speedHorizontal = 0.5f;
        SoundManager.Instance.SoundBG.PlaySound();
        SoundManager.Instance.SoundStartGame.audioSource.mute = true;
        InputManager.Instance.gameObject.SetActive(true);
    }

    public virtual void GameOver()
    {
        this.isGameOvering = true;
        UICtrl.Instance.scoreTextGameOver.SetTextGameOver();
        UICtrl.Instance.gameOverMenu.SetActive(true);
        UICtrl.Instance.scoreText.gameObject.SetActive(false);
        ObstacleSpawner.Instance.gameObject.SetActive(false);
        ToggleMute(SoundManager.Instance.SoundBG.audioSource);
        AudioSource audioSourceSoundFX = SoundManager.Instance.SoundFX.audioSource;
        AudioClip soundFX = audioSourceSoundFX.clip;
        SoundManager.Instance.SoundFX.audioSource.PlayOneShot(soundFX);
        Invoke(nameof(PlaySoundGameOver), 1f);
    }

    public void ToggleMute(AudioSource audioSource)
    {
        audioSource.mute = !audioSource.mute;
    }
    void PlaySoundGameOver()
    {
        SoundManager.Instance.SoundGameOver.PlaySound();
    }
}
