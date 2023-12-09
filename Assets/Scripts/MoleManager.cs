using UnityEngine;

public class MoleCollision : MonoBehaviour
{
    private AudioSource _audioSource;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.Rotate(Vector3.back, 1);
    }
}
