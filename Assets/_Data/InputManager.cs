using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;
    public static InputManager Instance { get => _instance; }

    [SerializeField] public float pressVertical;
    [SerializeField] public bool pressEsc;
    
    protected virtual void Awake()
    {
        if (InputManager._instance != null) Debug.LogError("only 1 InputManager allow to exist");
        InputManager._instance = this;
    }

    protected virtual void Update()
    {
        this.pressVertical = Input.GetAxis("Vertical");
        this.pressEsc = Input.GetButtonDown("Cancel");
    }
}
