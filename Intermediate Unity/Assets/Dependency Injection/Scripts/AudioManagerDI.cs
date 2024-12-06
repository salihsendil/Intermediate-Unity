    using UnityEngine;

public class AudioManagerDI : MonoBehaviour
{
    [SerializeField] private AudioClip _coinCollectSfx;
    private AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayCoinCollectSound()
    {
        if (_audioSource != null)
        {
            _audioSource.Play();
        }
    }
}
