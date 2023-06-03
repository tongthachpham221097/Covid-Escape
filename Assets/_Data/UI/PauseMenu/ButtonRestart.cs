using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRestart : BaseButton
{
    protected override void OnClick()
    {
        GameManager.Instance.RestartGame();
    }
}
