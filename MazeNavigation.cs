using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeNavigation : MonoBehaviour
{
    public float speed = 5.0f; // Movement speed of the character
    private float detectionDistance = 1f; // Distance to check for walls
    private Vector3 currentDirection; // The current direction the character is moving in
    private Vector3[] possibleDirections = { Vector3.forward, Vector3.right, Vector3.back, Vector3.left }; // All four directions

    void Start()
    {
        // Start by moving forward
        // currentDirection = Vector3.forward;
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

    // void Update()
    // {
    //     // Move the character in the current direction
    //     transform.Translate(currentDirection * speed * Time.deltaTime);

    //     // Check for walls in front
    //     if (IsWallAhead())
    //     {
    //         // If there's a wall ahead, change direction
    //         ChooseNewDirection();
    //     }
    // }

    // // Check if there's a wall ahead in the current direction
    // private bool IsWallAhead()
    // {
    //     RaycastHit hit;
    //     if (Physics.Raycast(transform.position, transform.TransformDirection(currentDirection), out hit, detectionDistance))
    //     {
    //         // If a wall is detected within the detection distance, return true
    //         return hit.collider.CompareTag("Wall");
    //     }
    //     return false;
    // }

    // // Choose a new direction when a wall is detected
    // private void ChooseNewDirection()
    // {
    //     // Try each of the four possible directions
    //     foreach (Vector3 direction in possibleDirections)
    //     {
    //         // Check if there is a wall in the new direction
    //         if (!Physics.Raycast(transform.position, transform.TransformDirection(direction), detectionDistance))
    //         {
    //             // If there's no wall in this direction, move in that direction
    //             currentDirection = direction;
    //             return;
    //         }
    //     }

    //     // If all directions are blocked, stop or take any other action
    //     speed = 0; // For example, stop the character
    // }
}
