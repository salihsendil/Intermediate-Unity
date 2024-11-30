using UnityEngine;

public class Gold : MonoBehaviour, ICollectable
{
    ValuableItemsGeneric<Gold> _item;
    private int _value = 45;

    void Start()
    {
        _item = new ValuableItemsGeneric<Gold>(this, _value);
    }

    void Update()
    {

    }

    public void Collect()
    {
        Debug.Log($"Gold collected with value: {_item.Value}");
    }

    public int GetValue()
    {
        return _item.Value;
    }
}
