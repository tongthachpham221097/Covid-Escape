using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreTextGameOver : BaseText
{
    public virtual void SetTextGameOver()
    {
        this.text.text = ((int)UICtrl.Instance.scoreText.score).ToString();
    }
}
