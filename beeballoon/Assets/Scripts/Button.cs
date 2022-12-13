using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public void pleasePause(){
        Debug.Log("pause button pressed");
    }

    public void audioToggle(){
        Image audioOn = GameObject.Find("audioOn").GetComponent<Image>();
        //Debug.Log("found audioOn");
        Image audioOff = GameObject.Find("audioOff").GetComponent<Image>();
        //Debug.Log("found audioOff");

        if (audioOff.enabled){
            audioOn.enabled = true;
            audioOff.enabled = false;
        }
        else{
            audioOn.enabled = false;
            audioOff.enabled = true;
        }
    }
}
