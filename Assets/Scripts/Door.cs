using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator door;
    private bool unlocked = false;
    private bool open = false;
    public void unlock(){
        unlocked = true;
        Debug.Log("Door Unlocked");
    }
    public void openClose(){
        if (!open && unlocked){
            door.SetBool("character_nearby", true);
            open = true;
        }
        else{
            door.SetBool("character_nearby", false);
            open = false;
        }
    }
}
