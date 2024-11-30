using System.Collections;
using UnityEngine;

public class PlaySoundsSequentially : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip sound1;        // First sound clip
    public AudioClip sound2;        // Second sound clip

    void Start()
    {
        // Start the sequence of playing sounds
        StartCoroutine(PlaySounds());
    }

    private IEnumerator PlaySounds()
    {
        if (audioSource != null)
        {
            // Play the first sound
            audioSource.clip = sound1;
            audioSource.Play();
            // Wait until the first sound finishes
            yield return new WaitForSeconds(audioSource.clip.length);

            // Play the second sound
            audioSource.clip = sound2;
            audioSource.Play();
        }
    }
}
