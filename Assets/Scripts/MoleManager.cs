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

    private void OnCollisionEnter()
    {
        _audioSource.Play();
        _spriteRenderer.enabled = false;
    }

    private void Update()
    {
        transform.Rotate(Vector3.back, 1);
    }

    private void OnCollisionExit()
    {
        _spriteRenderer.enabled = true;
    }
}
