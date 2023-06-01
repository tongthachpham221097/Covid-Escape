using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCollider : LoboBehaviour
{
    [SerializeField] public bool isGameOver = false;
    // set BoxCollider2D.size.x = 1.5
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        this.isGameOver = true;
        Time.timeScale = 0f;
    }
}
