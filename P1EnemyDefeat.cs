using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatEnemyPlay1 : MonoBehaviour
{
    public GameObject player1;

    // public GameObject player2;
    public GameObject enemy;

    public GameObject winText;
    public GameObject swordText;
    public GameObject shieldText;

    public GameObject player1Sword;
    public GameObject player1Shield;
    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
        swordText.gameObject.SetActive(false);
        shieldText.gameObject.SetActive(false);
    }

    // Update is called once per frame


    public void  OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "enemy" && player1Shield.activeSelf && player1Sword.activeSelf){
            enemy.SetActive(false);
            winText.gameObject.SetActive(true);
            shieldText.gameObject.SetActive(false);
            swordText.gameObject.SetActive(false);


        }
        if(collision.gameObject.name == "enemy" && !player1Shield.activeSelf && player1Sword.activeSelf){
            // enemy.SetActive(false);
            // Debug.Log("Player 1 does not have shield");
            shieldText.gameObject.SetActive(true);
            winText.gameObject.SetActive(false);
            swordText.gameObject.SetActive(false);


        }
        if(collision.gameObject.name == "enemy" && player1Shield.activeSelf && !player1Sword.activeSelf){
            // enemy.SetActive(false);
            // Debug.Log("Player 1 does not have sword");
            swordText.gameObject.SetActive(true);
            winText.gameObject.SetActive(false);
            shieldText.gameObject.SetActive(false);


        }

    }
    void Update(){

        if(!enemy.activeSelf && player1Shield.activeSelf && player1Shield.activeSelf){
            Debug.Log("Player 1 Wins");
        }

    }

}
