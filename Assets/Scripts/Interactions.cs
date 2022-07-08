using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public void Toggle(GameObject obj){
        if (obj.activeSelf)
            obj.SetActive(false);
        else
            obj.SetActive(true);
    }
}
