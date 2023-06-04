using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreText : BaseText
{
    [SerializeField] public float score = 0;
    protected virtual void FixedUpdate()
    {
        this.score += Time.fixedDeltaTime;
        this.text.text = ((int)score).ToString();
    }
}
