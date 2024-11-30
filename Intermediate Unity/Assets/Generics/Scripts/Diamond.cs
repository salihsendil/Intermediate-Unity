using UnityEngine;

public class Diamond : MonoBehaviour, ICollectable
{
    ValuableItemsGeneric<Diamond> _item;
    private int _value = 85;

    void Start()
    {
        _item = new ValuableItemsGeneric<Diamond>(this, _value);
    }

    void Update()
    {

    }

    public void Collect()
    {
        Debug.Log($"Diamond collected with value: {_item.Value}");
    }

    public int GetValue()
    {
        return _item.Value;
    }
}
