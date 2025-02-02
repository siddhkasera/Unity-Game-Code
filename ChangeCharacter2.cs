using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter2 : MonoBehaviour
{
    public GameObject avatarOne;
    public GameObject avatarTwo;
    public GameObject swordWeapon;
    public GameObject shield;

    void Start()
    {
        avatarOne.gameObject.SetActive(false);
        avatarTwo.gameObject.SetActive(false);

    }

    public void  OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.name == "sword"){
            swordWeapon.SetActive(false);
            avatarOne.SetActive(true);
        }
        if(collision.gameObject.name == "shield"){
            shield.SetActive(false);
            avatarTwo.SetActive(true);
        }

    }


}