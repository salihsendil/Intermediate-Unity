using System;
using UnityEngine;

public class Capsule : MonoBehaviour, IClickable
{

    void Start()
    {
    }

    void Update()
    {
    }

    public void Click(object sender, EventArgs e)
    {
        transform.Rotate(new Vector3(0, 0, 30));
    }


}
