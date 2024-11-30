using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    public event EventHandler IsCollectedItem;
    ICollectable _collectableItem;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit2d = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward, Mathf.Infinity);
            Debug.DrawRay(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward * 100, Color.red, 10f);
            if (hit2d)
            {
                _collectableItem = hit2d.collider.gameObject.GetComponent<ICollectable>();
                if (_collectableItem != null)
                {
                    IsCollectedItem?.Invoke(_collectableItem, EventArgs.Empty);
                    _collectableItem.Collect();
                    _collectableItem = null;
                }
            }
        }
    }
}
