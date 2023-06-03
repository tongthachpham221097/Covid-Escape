using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : BaseButton
{
    protected override void OnClick()
    {
        Time.timeScale = 1f;
        UICtrl.Instance.pauseMenu.SetActive(false);
    }

}
