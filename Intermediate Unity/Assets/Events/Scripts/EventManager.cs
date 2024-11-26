using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance { get; private set; }

    public event EventHandler OnKeyPressed;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        OnKeyPressed += TestingKeyPressed; //subscribe olma
    }

    private void TestingKeyPressed(object sender, EventArgs e)
    {
        Debug.Log("Space Key Pressed");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnKeyPressed?.Invoke(this, EventArgs.Empty);
        }
    }

}
