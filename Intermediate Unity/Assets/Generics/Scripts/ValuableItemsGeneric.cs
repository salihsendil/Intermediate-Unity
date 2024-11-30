using UnityEngine;

public class ValuableItemsGeneric<T>
{
    private T _data;
    private int _value;
    public int Value { get; private set; }

    public ValuableItemsGeneric(T data, int value)
    {
        _data = data;
        _value = value;
        Value = value; 
        Debug.Log("Item Created: " + _data + " Value is: " + _value);
    }

}
