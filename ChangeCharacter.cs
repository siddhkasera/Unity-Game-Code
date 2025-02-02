using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacter : MonoBehaviour
{
    public GameObject avatar1, avatar2;
    public GameObject sword;

    // avatar2.gameObject.SetActive(false);
    int whichAvatarIsOn = 1;

    void Start()
    {
        avatar1.gameObject.SetActive(true);
        avatar2.gameObject.SetActive(false);
        sword.gameObject.SetActive(true);

    }

    // Update is called once per frame
    public void SwitchAvatar()
    {
        if(avatar1){
            avatar2.SetActive(true);
            avatar1.SetActive(false);
            sword.SetActive(false);
        }

    }

    }