using System;
using UnityEngine;

public class Sphere : MonoBehaviour, IClickable
{
    private Color _newColor;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        _newColor = renderer.material.color;
    }

    void Update()
    {
        renderer.material.color = _newColor;
    }

    public void Click(object sender, EventArgs e)
    {
        _newColor = UnityEngine.Random.ColorHSV();
    }
}
