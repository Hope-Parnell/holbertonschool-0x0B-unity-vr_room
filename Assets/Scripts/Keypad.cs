using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Keypad : MonoBehaviour
{
    public UnityEvent DoorUnlocked;
    [SerializeField] private TMP_Text input;
    [SerializeField] private string passcode;
    private int i = 0;
    private bool passcodeEntered = false;
    private void FixedUpdate() {
        if (passcodeEntered){
            passcodeEntered = false;
            StartCoroutine(CheckPasscode());
        }
    }
    public void keyPress(int key){
        char[] tmp = input.text.ToCharArray();
        if (i < 4){
            if (key == -1){
                if (i > 0)
                    i--;
                tmp[i] = '_';
            } else{
                tmp[i] = (char)(key + '0');
                i++;
            }
        }
        if (i >= 4)
            passcodeEntered = true;
        input.text = tmp.ArrayToString();
    }
    IEnumerator CheckPasscode(){
        yield return new WaitForSeconds(2f);
        if(input.text == passcode){
            input.text = "Access Granted";
            DoorUnlocked.Invoke();
        } else {
            input.text = "Try Again";
            yield return new WaitForSeconds(3f);
            i = 0;
            input.text = "____";
        }
    }
}
