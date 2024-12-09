using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickScramble : MonoBehaviour
{
    public float moveSpeed = 1f;        // Movement speed
    public float moveInterval = 2f;     // Time interval to choose a new target position
    public Vector3 roomMin = new Vector3(-5f, 0f, 0f); // Lower-left-back corner of the room
    public Vector3 roomMax = new Vector3(10f, 0f, 10f);  // Upper-right-front corner of the room

    private Vector3 targetPosition;     // Target position to move towards
    private bool isMoving = false;      // Flag to check if the character is already moving

    private void Start()
    {
        // Start moving immediately when the game starts
        //ChooseNewTargetPosition();
        //InvokeRepeating("ChooseNewTargetPosition", moveInterval, moveInterval);
    }

    private void Update()
    {
        // Move towards the target position
        if (isMoving)
        {
            MoveTowardsTarget();
        }
    }

    // Method to move the character towards the target position
    private void MoveTowardsTarget()
    {
        float step = moveSpeed * Time.deltaTime;  // Calculate step size based on speed and deltaTime
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        // Stop moving if the character reaches the target
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            isMoving = false;
        }
    }

    // Method to choose a new random target position
    public void ScrambleToRandomPosition()
    {
        // Generate a random position within the room's bounds
        float randomX = Random.Range(roomMin.x, roomMax.x);
        float randomZ = Random.Range(roomMin.z, roomMax.z);

        // Set y to 0 to keep the character on the ground
        targetPosition = new Vector3(randomX, 0f, randomZ);

        isMoving = true;  // Start moving to the new target
    }
}
