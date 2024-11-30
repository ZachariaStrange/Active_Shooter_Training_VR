using UnityEngine;

public class PlayerWalkingSound : MonoBehaviour
{
    public AudioSource walkingAudioSource; // Reference to the AudioSource
    public AudioClip walkingClip;          // Walking sound clip
    public float movementThreshold = 0.1f; // Minimum movement speed to trigger sound

    private CharacterController characterController;

    void Start()
    {
        // Get the CharacterController component
        characterController = GetComponent<CharacterController>();

        // Assign the walking clip to the AudioSource
        walkingAudioSource.clip = walkingClip;
        walkingAudioSource.loop = true; // Loop the walking sound
    }

    void Update()
    {
        // Check player movement
        if (characterController != null)
        {
            // Determine if the player is moving
            if (characterController.velocity.magnitude > movementThreshold)
            {
                // Play the sound if it's not already playing
                if (!walkingAudioSource.isPlaying)
                {
                    walkingAudioSource.Play();
                }
            }
            else
            {
                // Stop the sound if the player stops moving
                if (walkingAudioSource.isPlaying)
                {
                    walkingAudioSource.Stop();
                }
            }
        }
    }
}
