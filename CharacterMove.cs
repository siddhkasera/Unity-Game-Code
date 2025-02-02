using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterMove : MonoBehaviour
{
    public float speed = 5.0f;
    // public Vector3 originalPosition; // Store the original position of the character
    // private float timerDuration = 5f; // Duration of the timer in seconds
    // private float timer; // The timer value
    // private bool timerActive = false; // Flag to control when the timer is active

    // public TMP_Text timerText; // Reference to the UI Text component

    void Start()
    {
        // originalPosition = transform.position;

    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(speed * Time.deltaTime, 0, 0);

        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(-speed * Time.deltaTime, 0, 0);

        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }


        

    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Maze"){

            Debug.Log("Timer Complete! Action Triggered.");

        }

    }

     // Method to trigger the desired action
    // private void TriggerAction()
    // {
    //     Debug.Log("Timer Complete! Action Triggered.");
    // }

     // Method to start the timer
    // public void StartTimer()
    // {
    //     timerActive = true;
    // }
    
    }


