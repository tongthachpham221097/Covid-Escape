using UnityEngine;

public class LoboBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.ResetValue();
        this.LoadComponents();
    }

    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void LoadComponents()
    {
        //For override
    }
    protected virtual void ResetValue()
    {
        //For override
    }
}