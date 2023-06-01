using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }

    [SerializeField] public float pressVertical;
    protected virtual void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("only 1 InputManager allow to exist");
        InputManager.instance = this;
    }
    protected virtual void FixedUpdate()
    {
        this.pressVertical = Input.GetAxis("Vertical");
    }
}
