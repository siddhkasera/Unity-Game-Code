using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTwoMove : MonoBehaviour
{
    // Start is called before the first frame update

    // public Transform heroObj;

    public float speed = 5.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKey(KeyCode.A)){
            transform.Translate(speed * Time.deltaTime, 0, 0);

        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(-speed * Time.deltaTime, 0, 0);

        }
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Maze"){
            Debug.Log("Wall Hit");
        }
    }
}
