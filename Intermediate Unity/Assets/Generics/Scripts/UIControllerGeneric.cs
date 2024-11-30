using System;
using TMPro;
using UnityEngine;

public class UIControllerGeneric : MonoBehaviour
{
    public static UIControllerGeneric Instance { get; private set; }

    [SerializeField] TMP_Text _valueText;

    private int totalValue = 0;


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
    void Start()
    {
        if (InputManager.Instance != null)
        {
            InputManager.Instance.IsCollectedItem += UpdateUI;
        }
        else
        {
            Debug.LogError("InputManager.Instance is null!");
        }
        _valueText.text = $"Total Value: {totalValue}";
    }

    void UpdateUI(object sender, EventArgs e)
    {
        if (sender is ICollectable collectable)
        {
            int value = collectable.GetValue();
            totalValue += value;
            _valueText.text = $"Total Value: {totalValue}";
            Debug.Log($"UI Updated: Total Value = {totalValue}");
        }
    }
}
