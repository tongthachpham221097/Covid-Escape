using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] protected bool isPausing = false;
    private void Update()
    {
        if (InputManager.Instance.pressEsc != 0) this.CheckPauseMenu();
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
