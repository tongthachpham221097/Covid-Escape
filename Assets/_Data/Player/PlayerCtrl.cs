using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerCtrl : LoboBehaviour
{
    private static PlayerCtrl instance;
    public static PlayerCtrl Instance { get => instance; }

    [SerializeField] protected PlayerCollider playerCollider;
    public PlayerCollider PlayerCollider { get => playerCollider; }

    [SerializeField] protected PlayerMovement playerMovement;
    public PlayerMovement PlayerMovement { get => playerMovement; }
    protected override void Awake()
    {
        base.Awake();
        if (PlayerCtrl.instance != null) Debug.LogError("only 1 PlayerCtrl allow to exist");
        PlayerCtrl.instance = this;
    }
    protected override void LoadComponents()
    {
        this.LoadPlayerCollider();
        this.LoadPlayerMovement();
    }
    protected virtual void LoadPlayerCollider()
    {
        if (this.playerCollider != null) return;
        this.playerCollider = GetComponentInChildren<PlayerCollider>();
        Debug.LogWarning(transform.name + ": LoadPlayerCollider", gameObject);
    }
    protected virtual void LoadPlayerMovement()
    {
        if (this.playerMovement != null) return;
        this.playerMovement = GetComponentInChildren<PlayerMovement>();
        Debug.LogWarning(transform.name + ": LoadPlayerMovement", gameObject);
    }
}
