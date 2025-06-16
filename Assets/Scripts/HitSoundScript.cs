using UnityEngine;

public class HitSoundScript : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
            else
            {
                Debug.LogError("AudioSource is not assigned.");
            }
        }
    }
}
