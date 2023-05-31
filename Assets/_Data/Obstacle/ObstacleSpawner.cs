using UnityEngine;

public class ObstacleSpawner : Spawner
{
    public static string obstacleOne = "prefab_1";

    [SerializeField] protected float randomDelay = 1f;
    [SerializeField] protected float randomTimer = 0f;
    [SerializeField] protected float spawnOffsetX = 10f;
    protected virtual void FixedUpdate()
    {
        this.ObstacleSpawning();
    }
    protected virtual void ObstacleSpawning()
    {
        this.randomTimer += Time.fixedDeltaTime;
        if (this.randomTimer < this.randomDelay) return;
        this.randomTimer = 0;

        Transform ranPoint = PlayerCtrl.Instance.transform;
        Vector3 pos = ranPoint.position;
        pos.x += this.spawnOffsetX;
        float minPosY = PlayerCtrl.Instance.PlayerMovement.minPlayerPosY;
        float maxPosY = PlayerCtrl.Instance.PlayerMovement.maxPlayerPosY;
        pos.y = Random.Range(minPosY, maxPosY);
        Quaternion rot = transform.rotation;

        Transform prefab = this.RandomPrefab();
        Transform obj = this.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }
}
