using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class BgManager : LoboBehaviour
{
    [SerializeField] protected SpriteRenderer spriteRenderer;
    [SerializeField] protected GameObject playerCtrl;
    [SerializeField] protected GameObject currentBg;

    [SerializeField] protected Vector3 playerPosition;
    [SerializeField] protected float distance;
    [SerializeField] protected float scrollSpeed = 1f;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpriteRenderer();
        this.LoadPlayerCtrl();
        this.LoadCurrentBg();
    }
    protected virtual void LoadSpriteRenderer()
    {
        if (this.spriteRenderer != null) return;
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.LogWarning(transform.name + ": LoadSpriteRenderer", gameObject);
    }
    protected virtual void LoadPlayerCtrl()
    {
        if (this.playerCtrl != null) return;
        this.playerCtrl = GameObject.Find("PlayerCtrl");
        Debug.LogWarning(transform.name + ": LoadPlayerCtrl", gameObject);
    }
    protected virtual void LoadCurrentBg()
    {
        if (this.currentBg != null) return;

        if (transform.name == "Background_1") this.currentBg = GameObject.Find("Background_2");
        if(transform.name == "Background_2") this.currentBg = GameObject.Find("Background_1");
        Debug.LogWarning(transform.name + ": LoadCurrentBg", gameObject);
    }
    protected virtual void Update()
    {
        this.Looping();
    }
    protected virtual void Looping()
    {
        this.MoveLeft();
        this.GetPlayerPosition();
        this.DistanceWithPlayer();
    }
    protected virtual void MoveLeft()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);
    }
    protected virtual void GetPlayerPosition()
    {
        this.playerPosition = this.playerCtrl.transform.position;
    }
    protected virtual void DistanceWithPlayer()
    {
        this.distance = this.playerPosition.x - transform.position.x;
        if (this.distance >= 9) this.RePosition();
    }
    protected virtual void RePosition()
    {
        Camera mainCamera = Camera.main;
        float cameraHeight = 2f * mainCamera.orthographicSize;
        transform.position = new Vector3(this.currentBg.transform.position.x + 17f, 0f, 0f);
    }
}

