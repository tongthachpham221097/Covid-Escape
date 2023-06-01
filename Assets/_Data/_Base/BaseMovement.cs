using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : LoboBehaviour
{
    [Header("Base Movement")]
    [SerializeField] public Rigidbody2D rb2d;
    [SerializeField] protected Vector2 velocity = new Vector2(0f, 0f);
    [SerializeField] protected float speedHorizontal;
    [SerializeField] protected float speedVertical;
    protected override void LoadComponents()
    {
        this.rb2d = GetComponentInParent<Rigidbody2D>();
        this.rb2d.gravityScale = 0f;
    }
}
