using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : BaseMovement
{
    [SerializeField] protected float maxPlayerPosY = 4.5f;
    public float MaxPlayerPosY => maxPlayerPosY;

    [SerializeField] protected float minPlayerPosY = -4.2f;
    public float MinPlayerPosY => minPlayerPosY;

    [SerializeField] protected float timer = 0f;
    [SerializeField] protected float delay = 0f;

    protected override void ResetValue()
    {
        base.ResetValue();
        this.speedHorizontal = 0.01f;
        this.speedVertical = 5f;
    }

    private void Start()
    {
        Invoke(nameof(this.SetDelay), 10f);
    }
    protected virtual void Update()
    {
        this.Moving();
    }
    protected virtual void Moving()
    {
        this.AutoMoveRight();
        this.velocity.y = this.speedVertical * InputManager.Instance.pressVertical;
        this.rb2d.velocity = this.velocity;
        this.CheckPlayerPosition();
    }

    protected virtual void AutoMoveRight()
    {
        this.timer += Time.deltaTime;
        if (this.timer < this.delay) return;
        this.timer = 0f;
        this.velocity.x += this.speedHorizontal * Time.deltaTime;
    }

    protected virtual void CheckPlayerPosition()
    {
        Vector3 Pos = transform.parent.position;
        if(Pos.y > this.maxPlayerPosY) Pos.y = this.maxPlayerPosY;
        if (Pos.y < this.minPlayerPosY) Pos.y = this.minPlayerPosY;
        transform.parent.position = Pos;
    }

    void SetDelay()
    {
        this.delay = 1f;
    }

}
