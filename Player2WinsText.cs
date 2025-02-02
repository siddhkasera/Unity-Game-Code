 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player2WinsText : MonoBehaviour
{
    // Start is called before the first frame update

    // public GameObject player1;
   public  GameObject player2;


    // public GameObject playerOneSword;
    // public GameObject playerOneShield;
    public GameObject playerTwoSword;
    public GameObject playerTwoShield;
    public GameObject gameText;


    void Start()
    {
        gameText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTwoShield.activeSelf && playerTwoSword.activeSelf){
            gameText.gameObject.SetActive(true);

        }
    }
}
