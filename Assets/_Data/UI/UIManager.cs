using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] protected bool isPausing = false;

    public virtual void Start()
    {
        UICtrl.Instance.pauseMenu.SetActive(false);
        UICtrl.Instance.optionMenu.SetActive(false);
        UICtrl.Instance.scoreText.SetActive(false);
        ObstacleSpawner.Instance.gameObject.SetActive(false);
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
    }
    void DisabelPauseMenu()
    {
        UICtrl.Instance.pauseMenu.SetActive(false);
        this.isPausing = false;
    }
    
}
