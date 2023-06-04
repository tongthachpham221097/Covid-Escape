using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : BaseButton
{
    protected override void OnClick()
    {
        UICtrl.Instance.optionMenu.SetActive(false);
        UICtrl.Instance.mainMenu.SetActive(true);
    }
}
