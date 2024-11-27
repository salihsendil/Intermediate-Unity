using System;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    public static PlayerInputController Instance { get; private set; }

    public event EventHandler RayHitSomething;

    private IClickable _clickable;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        RayHitSomething += ClickedObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 10f);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                _clickable = hit.transform.gameObject.GetComponent<IClickable>();
                if (_clickable != null)
                {
                    RayHitSomething?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }

    void ClickedObject(object sender, EventArgs e)
    {
        _clickable.Click(sender, e);
        _clickable = null;
    }
}