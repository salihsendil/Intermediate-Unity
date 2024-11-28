using UnityEngine;
using UnityEngine.Events;

public class SpellButton : MonoBehaviour
{
    [SerializeField] private SpellsSO _spellSO;
    public UnityEvent<SpellsSO> OnSpellSelected; 

    public void OnButtonClick()
    {
        OnSpellSelected?.Invoke(_spellSO);
    }
}
