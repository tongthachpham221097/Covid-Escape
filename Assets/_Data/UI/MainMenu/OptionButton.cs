using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : BaseButton
{
    protected override void OnClick()
    {
        UICtrl.Instance.mainMenu.SetActive(false);
        UICtrl.Instance.optionMenu.SetActive(true);
    }
}
