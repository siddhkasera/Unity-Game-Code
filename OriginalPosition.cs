using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalPosition : MonoBehaviour
{
    public Vector3 originalPosition; // Store the original position of the character

    void Start()
    {
        // Save the original position of the character when the game starts
        originalPosition = transform.position;
    }

    void Update()
    {
        // Example condition to trigger the character to move back
        if (Input.GetKeyDown(KeyCode.R)) // Replace with your desired condition
        {
            MoveToOriginalPosition();
        }
    }

    // Method to move the character back to its original position
    private void MoveToOriginalPosition()
    {
        transform.position = originalPosition;
    }
}
