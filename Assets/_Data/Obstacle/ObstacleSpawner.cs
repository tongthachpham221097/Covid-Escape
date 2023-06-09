using UnityEngine;

public class ObstacleSpawner : Spawner
{
    private static ObstacleSpawner _instance;
    public static ObstacleSpawner Instance { get => _instance; }

    public static string obstacleOne = "prefab_1";

    [SerializeField] protected float randomDelay = 5f;
    [SerializeField] protected float randomTimer = 0f;
    [SerializeField] protected float spawnOffsetX = 20f;

    protected override void Awake()
    {
        base.Awake();
        if (ObstacleSpawner._instance != null) Debug.LogError("only 1 ObstacleSpawner allow to exist");
        ObstacleSpawner._instance = this;
    }
    protected virtual void FixedUpdate()
    {
        this.ObstacleSpawning();
    }
    protected virtual void ObstacleSpawning()
    {
        if(this.TimeDelay()) return;

        Vector3 pos = this.GetPosition();
        
        Quaternion rot = transform.rotation;
        
        Transform prefab = this.RandomPrefab();
        Transform obj = this.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
    }
    protected virtual bool TimeDelay()
    {
        this.randomTimer += Time.fixedDeltaTime;
        if (this.randomTimer < this.randomDelay) return true;
        this.randomTimer = 0;
        return false;
    }
    protected virtual Vector3 GetPosition()
    {
        Vector3 pos = PlayerCtrl.Instance.transform.position;
        pos.x += this.spawnOffsetX;
        pos.y = this.RamdomPositionY();
        return pos;
    }
    protected virtual float RamdomPositionY()
    {
        float minPosY = PlayerCtrl.Instance.PlayerMovement.MinPlayerPosY;
        float maxPosY = PlayerCtrl.Instance.PlayerMovement.MaxPlayerPosY;
        return Random.Range(minPosY, maxPosY);
    }
}
