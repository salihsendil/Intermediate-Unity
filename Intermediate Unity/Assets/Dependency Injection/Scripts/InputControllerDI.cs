using UnityEngine;
using Zenject;

public class InputControllerDI : MonoBehaviour
{
    private AudioManagerDI _audioManagerDI;
    private UIControllerDI _uiControllerDI;
    private NotOnSceneScript _notOnSceneScript;

    private int _clickCount;

    [Inject]
    private void ZenjectSetup(AudioManagerDI audioManagerDI, UIControllerDI uiControllerDI, NotOnSceneScript notOnSceneScript)
    {
        _audioManagerDI = audioManagerDI;
        _uiControllerDI = uiControllerDI;
        _notOnSceneScript = notOnSceneScript;
    }

    void Start()
    {

    }

    void Update()
    {
        DetectClickedToCoin();
    }

    void DetectClickedToCoin()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
            {
                if (hit.collider != null)
                {
                    _clickCount++;
                    _audioManagerDI.PlayCoinCollectSound();
                    _uiControllerDI.SetCoinText(_clickCount);
                    _notOnSceneScript.DegubLogMethod();
                }
            }

        }
    }

}
