using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : LoboBehaviour
{
    [SerializeField] protected Rigidbody rb;
    [SerializeField] protected Vector3 velocity = new Vector3(0f, 0f,0f);
    [SerializeField] protected float autoSpeedRight = 0.1f;
    [SerializeField] protected float speedVertical = 0.5f;
    protected override void LoadComponents()
    {
        this.rb = GetComponentInParent<Rigidbody>();
        this.rb.useGravity = false;
    }
    protected virtual void FixedUpdate()
    {
        this.UpdatePosition();
    }
    protected virtual void UpdatePosition()
    {
        this.PlayerAutoRunRight();
        this.PlayerVerticalMovement();
        this.rb.MovePosition(this.rb.position + this.velocity * Time.fixedDeltaTime);
    }
    protected virtual void PlayerAutoRunRight()
    {
        this.velocity.x = this.autoSpeedRight;
        this.autoSpeedRight += transform.position.x / 1000;
    }
    protected virtual void PlayerVerticalMovement()
    {
        this.velocity.y = this.speedVertical * InputManager.Instance.pressVertical;
    }
}
