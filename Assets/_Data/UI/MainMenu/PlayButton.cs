using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : BaseButton
{
    protected override void OnClick()
    {
        UICtrl.Instance.mainMenu.gameObject.SetActive(false);
        UICtrl.Instance.scoreText.gameObject.SetActive(true);
        ObstacleSpawner.Instance.gameObject.SetActive(true);
        PlayerCtrl.Instance.PlayerMovement.speedHorizontal = 0.5f;
    }
}
