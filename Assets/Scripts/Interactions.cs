using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private GameObject code;
    private bool doorUnlocked = false;
    private bool flashlightOn = false;
    public void Toggle(GameObject obj){
        if (obj.activeSelf)
            obj.SetActive(false);
        else
            obj.SetActive(true);
    }
    public void flashlight(){
        flashlightOn = !flashlightOn;
        code.GetComponent<Reveal>().enabled = flashlightOn;
    }
}
