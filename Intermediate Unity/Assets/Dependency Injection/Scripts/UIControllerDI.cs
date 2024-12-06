using TMPro;
using UnityEngine;

public class UIControllerDI : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinText;
    public void SetCoinText(int amount)
    {
        if (_coinText!=null)
        {
            _coinText.text = "Coin: " + amount;
        }
    }
}
