using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    [SerializeField] private Material onMat;
    [SerializeField] private Material offMat;
    [SerializeField] private GameObject content;
    [SerializeField] private GameObject homeScreen;
    [SerializeField] private GameObject doorMenu;
    private bool isOff = true;
    public void PowerOn(){
        if (isOff){
            var renderer = GetComponent<MeshRenderer>();
            Material[] materials = renderer.sharedMaterials;
            materials[1] = onMat;
            doorMenu.SetActive(false);
            content.SetActive(true);
            homeScreen.SetActive(true);
            isOff = false;
        }
    }
    public void PowerOff(){
        isOff = true;
        var renderer = GetComponent<MeshRenderer>();
        Material[] materials = renderer.sharedMaterials;
        materials[1] = offMat;
            content.SetActive(false);
        renderer.sharedMaterials = materials;
    }
    public void DoorMenu(){
        homeScreen.SetActive(false);
        doorMenu.SetActive(true);
    }
    public void Menu(){
        doorMenu.SetActive(false);
        homeScreen.SetActive(true);
    }
}
