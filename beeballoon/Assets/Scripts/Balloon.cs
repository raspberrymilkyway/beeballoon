using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Balloon : MonoBehaviour
{
    public GameObject renter;
    public int childs;
    public GameObject beeBalloon;

    Scene sen;
    string senam;

    void Start()
    {
        sen = SceneManager.GetActiveScene();
        senam = sen.name;

        beeBalloon.SetActive(false);
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
            if(senam == "LevelOne") SceneManager.LoadScene("LevelTwo");
            if(senam == "LevelTwo") SceneManager.LoadScene("LevelThree");
            if(senam == "LevelThree") SceneManager.LoadScene("LevelFour");
            if(senam == "LevelFour") SceneManager.LoadScene("GameOver");
        }
    }


}
