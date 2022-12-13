using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Button : MonoBehaviour
{
    public void pauseToggle(){
        Image play = GameObject.Find("play").GetComponent<Image>();
        TMP_Text pause = GameObject.Find("pause").GetComponent<TMP_Text>();
        
        if (play.enabled){
            //Debug.Log("play button pressed");
            Time.timeScale = 1;
            play.enabled = false;
            pause.text = "||";
        }
        else{
            //Debug.Log("pause button pressed");
            Time.timeScale = 0;
            play.enabled = true;
            pause.text = "";
        }
    }

    public void audioToggle(){
        Image audioOn = GameObject.Find("audioOn").GetComponent<Image>();
        //Debug.Log("found audioOn");
        Image audioOff = GameObject.Find("audioOff").GetComponent<Image>();
        //Debug.Log("found audioOff");
        AudioSource music = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();

        if (audioOff.enabled){
            audioOn.enabled = true;
            audioOff.enabled = false;
            music.mute = false;
        }
        else{
            audioOn.enabled = false;
            audioOff.enabled = true;
            music.mute = true;
        }
    }

    public void changeScene(string scene){
        SceneManager.LoadScene(scene);
    }
    public void quitGame(){
        Application.Quit();
    }

    //these could be done with .activeSelf but i'm frustrated and this works
    // apparently full paths are absolutely necessary to do this.
    public void instructions(){
        GameObject.Find("Panel").transform.Find("Inst").gameObject.SetActive(true);
        GameObject.Find("Panel").transform.Find("Init").gameObject.SetActive(false);
    }
    public void credits(){
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
