using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterTimer : MonoBehaviour
{
    private float timerDuration = 5f; // Duration of the timer in seconds
    private float timer; // The timer value
    private bool timerActive = false; // Flag to control when the timer is active

    public TMP_Text timerText; // Reference to the UI Text component

    public GameObject avatarOne;
    public GameObject avatarTwo;
    public GameObject swordWeapon;
    public GameObject shield;

     public Vector3 originalPosition;


     void Start()
    {
        // Save the original position of the character when the game starts
        originalPosition = transform.position;
    }


    void Update()
    {
        // Check if the timer is active
        if (timerActive)
        {
            // Decrease the timer by the time passed since the last frame
            timer -= Time.deltaTime;

            // Update the UI text with the current timer value
            UpdateTimerUI();

            // When the timer reaches zero, trigger the desired action
            if (timer <= 0)
            {
                timerActive = false; // Stop the timer
                timer = timerDuration; // Reset the timer
                TriggerAction(); // Call the method for the desired action
                UpdateTimerUI(); // Final update to reset the UI text
            }
        }
    }

    // Method to update the timer UI
    private void UpdateTimerUI()
    {
        timerText.text = "Time Left: " + Mathf.Ceil(timer).ToString() + "s";
    }

    // Method to trigger the desired action
    private void TriggerAction()
    {
        Debug.Log("Timer Complete! Action Triggered.");
        MoveToOriginalPosition();

        if(avatarTwo.activeSelf){
            shield.SetActive(true);
            avatarTwo.SetActive(false);
        }
        // timer = timerDuration; // Initialize the timer to the duration value
        // UpdateTimerUI(); // Initial update to the UI text
        // StartTimer();
        // // Add your action logic here


    }

    // Method to start the timer
    public void StartTimer()
    {
        timerActive = true;
    }

     private void OnCollisionEnter2D(Collision2D collision){
    
         if(collision.gameObject.name == "shield"){
            timer = timerDuration; // Initialize the timer to the duration value
            UpdateTimerUI();
            StartTimer();
        }



    }

    private void MoveToOriginalPosition()
    {
        transform.position = originalPosition;
    }


}
