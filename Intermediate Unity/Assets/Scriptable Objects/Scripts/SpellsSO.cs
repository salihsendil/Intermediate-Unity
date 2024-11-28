using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "Spell SO")]
public class SpellsSO : ScriptableObject
{
    public string spellName;
    [TextArea(2, 4)]
    public string description;
    public int manaValue;
    public Sprite image;
    public int defense;
    public int attack;
}
