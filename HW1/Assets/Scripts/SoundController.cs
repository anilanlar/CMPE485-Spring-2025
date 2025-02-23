using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause(); // Pause if playing
            }
            else
            {
                audioSource.Play(); // Resume if paused
            }
        }
    }
}
