using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Balloon : MonoBehaviour
{
    public GameObject renter;
    public int childs;
    public GameObject beeBalloon;

    Scene sen;
    string senam;

    TMP_Text lvl;

    void Start()
    {
        sen = SceneManager.GetActiveScene();
        senam = sen.name;

        beeBalloon.SetActive(false);

        GameObject[] txt = GameObject.FindGameObjectsWithTag("ui");
        lvl = GameObject.Find("DontDestroy").transform.GetChild(1).transform.GetChild(0).transform.GetChild(1).GetComponent<TMP_Text>();
    }

    
    void Update()
    {
        childs = renter.transform.childCount;

        if(beeBalloon != null) {
            if(childs <= 0) {
                beeBalloon.SetActive(true);
            }
        }
        else {
            int x = int.Parse(lvl.text);
            x++;
            lvl.text = x.ToString();

            if(senam == "LevelOne") {
                SceneManager.LoadScene("LevelTwo");
            }
            if(senam == "LevelTwo") {
                SceneManager.LoadScene("LevelThree");
            }
            if(senam == "LevelThree") {
                SceneManager.LoadScene("LevelFour");
            }
            if(senam == "LevelFour") {
                SceneManager.LoadScene("GameOver");
            }

            Timer.S.NewTime();
            
            if(beeBalloon != null) {
                if(childs > 0) {
                    beeBalloon.SetActive(false);
                }
            }
        }
    }


}
