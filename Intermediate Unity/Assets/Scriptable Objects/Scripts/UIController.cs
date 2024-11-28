using UnityEngine;
using UnityEngine.UI;
public class UIController : MonoBehaviour
{
    public static UIController Instance { get; private set; }
    private GameObject _spellUI;
    private Spell _spell;


    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        foreach (var button in FindObjectsByType<SpellButton>(FindObjectsSortMode.None))
        {
            button.OnSpellSelected.AddListener(UpdateSpellUI);
        }
    }

    private void Start()
    {
        _spellUI = GetComponentInChildren<Spell>().gameObject;
        _spellUI.SetActive(false);
        _spell = _spellUI.GetComponentInChildren<Spell>();
    }

    public void UpdateSpellUI(SpellsSO spellSO)
    {
        _spell.SpellCard = spellSO;
        _spellUI.SetActive(true);
    }

    public void CloseSpellUI()
    {
        _spellUI.SetActive(false);
    }
}
