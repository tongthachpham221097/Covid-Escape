using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : BaseButton
{
    protected override void OnClick()
    {
        GameManager.Instance.PlayGame();
    }
}
