using System;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public static PlayerInputHandler Instance { get; private set; }
    public event EventHandler LMBClicked;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    void Start()
    {
        LMBClicked += FireBall;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LMBClicked?.Invoke(this, EventArgs.Empty);
        }
    }

    void FireBall(object sender, EventArgs e)
    {
        ObjectPoolingManager.Instance.GetBallFromPool();
    }

}
