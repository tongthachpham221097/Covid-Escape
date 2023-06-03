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
        this.UpdatePosition();
    }
    protected virtual void UpdatePosition()
    {
        this.PlayerVerticalMovement();
        this.PlayerAutoRunRight();
        this.rb2d.velocity = this.velocity;
        this.CheckPlayerPosition();
    }
    protected virtual void PlayerAutoRunRight()
    {
        this.velocity.x += this.speedHorizontal * Time.deltaTime;
    }
    protected virtual void PlayerVerticalMovement()
    {

        //float parentPosY = transform.parent.position.y;
        //float clampedPosY = Mathf.Clamp(parentPosY, minPlayerPosY, maxPlayerPosY);

        this.velocity.y = this.speedVertical * InputManager.Instance.pressVertical;
        //transform.parent.position = new Vector3(transform.parent.position.x, clampedPosY, transform.parent.position.z);
    }
    protected virtual void CheckPlayerPosition()
    {
        Vector3 Pos = transform.parent.position;
        if(Pos.y > this.maxPlayerPosY) Pos.y = this.maxPlayerPosY;
        if (Pos.y < this.minPlayerPosY) Pos.y = this.minPlayerPosY;
        transform.parent.position = Pos;
    }
}
