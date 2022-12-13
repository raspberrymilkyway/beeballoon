using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public void changeScene(string scene){
        SceneManager.LoadScene(scene);
    }

    public void quitGame(){
        Application.Quit();
    }

    public void instructions(){
        // GameObject inst = GameObject.FindWithTag("instructions");
        // GameObject init = GameObject.FindWithTag("init");
        // inst.SetActive(true);
        // init.SetActive(false);

        GameObject.Find("Panel").transform.Find("Inst").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Init").gameObject.SetActive(false);
    }

    public void credits(){
        // GameObject cred = GameObject.FindWithTag("credits");
        // GameObject init = GameObject.FindWithTag("init");
        // cred.SetActive(true);
        // init.SetActive(false);

        GameObject.Find("Panel").transform.Find("Cred").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Init").gameObject.SetActive(false);
    }

    public void iniCred(){
        GameObject.Find("Panel").transform.Find("Init").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Cred").gameObject.SetActive(false);
    }
    public void iniInst(){
        GameObject.Find("Panel").transform.Find("Init").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Inst").gameObject.SetActive(false);
    }
}
