using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private bool soundActive;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter()
    {
        if (!soundActive) return;
        _audioSource.Play();
    }
}
