using UnityEngine;
using System;

public class EventSubscriber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EventManager.Instance.OnKeyPressed += TestingComminicateWithClasses;
    }

    private void TestingComminicateWithClasses(object sender, EventArgs e)
    {
        Debug.Log("ba�ka s�n�ftan eri�tim");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
