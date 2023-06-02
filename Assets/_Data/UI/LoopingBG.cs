using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBG : MonoBehaviour
{
    public float bgSpeed = 1f;
    public Renderer bgRenderer;
    protected virtual void Update()
    {
        this.bgRenderer.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}
