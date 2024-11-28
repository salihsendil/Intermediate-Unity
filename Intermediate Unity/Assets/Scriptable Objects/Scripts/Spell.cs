using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{
    public SpellsSO SpellCard
    {
        get => _spellCard;
        set
        {
            _spellCard = value;
            UpdateUI();
        }
    }

    [SerializeField] private SpellsSO _spellCard;
    [SerializeField] private TMP_Text _mana;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private Image _spellImage;
    [SerializeField] private TMP_Text _defense;
    [SerializeField] private TMP_Text _attack;

    void UpdateUI()
    {
        _mana.text = _spellCard.manaValue.ToString();
        _name.text = _spellCard.spellName;
        _description.text = _spellCard.description;
        _spellImage.sprite = _spellCard.image;
        _defense.text = _spellCard.defense.ToString();
        _attack.text = _spellCard.attack.ToString();
    }
}
