using UnityEngine;

public class ObstacleDespawn : LoboBehaviour
{
    private void Update()
    {
        this.Spawning();
    }

    void Spawning()
    {
        Vector3 pos = this.GetPosPlayer();
        if (pos.x - transform.position.x < 30) return;
        ObstacleSpawner.Instance.Despawn(transform.parent);
    }

    Vector3 GetPosPlayer()
    {
        Vector3 pos = PlayerCtrl.Instance.transform.position;
        return pos;
    }
}
