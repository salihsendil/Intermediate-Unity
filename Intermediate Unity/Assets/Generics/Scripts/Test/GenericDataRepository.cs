using UnityEngine;

public class GenericDataRepository<T>
{
    private T _data;

    public void SaveData(T value)
    {
        _data = value;
    }

    public T GetData()
    {
        Debug.Log("Data: " + _data);
        return _data;
    }

    public void ClearData()
    {
        _data = default;
        Debug.Log("Data Deleted!");
    }
}
