using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : LoboBehaviour
{
    [SerializeField] protected Transform playerCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPlayerCtrl();
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GameObject.Find("PlayerCtrl").transform;
        Debug.LogWarning(transform.name + ": LoadPlayerCtrl", gameObject);
    }
}
