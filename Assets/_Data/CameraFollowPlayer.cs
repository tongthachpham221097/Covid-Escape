using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : FollowPlayer
{
    protected float defaultPositionZ = -10f;
    protected float defaultPlayerPositionX = 8f;
    protected virtual void Update()
    {
        Transform target = this.playerCtrl.transform;
        float newPosX = target.position.x + this.defaultPlayerPositionX;
        transform.position = new Vector3(newPosX, 0, this.defaultPositionZ);
    }
}
