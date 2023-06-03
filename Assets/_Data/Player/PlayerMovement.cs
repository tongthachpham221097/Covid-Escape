using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : BaseMovement
{
    [SerializeField] public float maxPlayerPosY = 4.5f;
    [SerializeField] public float minPlayerPosY = -4.2f;

    protected override void ResetValue()
    {
        base.ResetValue();
        this.speedHorizontal = 0.5f;
        this.speedVertical = 5f;
    }
    protected virtual void Update()
    {
        this.Moving();
    }
    protected virtual void Moving()
    {
        this.velocity.x += this.speedHorizontal * Time.deltaTime;
        this.velocity.y = this.speedVertical * InputManager.Instance.pressVertical;
        this.rb2d.velocity = this.velocity;
        this.CheckPlayerPosition();
    }
    protected virtual void CheckPlayerPosition()
    {
        Vector3 Pos = transform.parent.position;
        if(Pos.y > this.maxPlayerPosY) Pos.y = this.maxPlayerPosY;
        if (Pos.y < this.minPlayerPosY) Pos.y = this.minPlayerPosY;
        transform.parent.position = Pos;
    }
}
