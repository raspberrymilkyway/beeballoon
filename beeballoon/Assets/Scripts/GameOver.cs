using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    [Header("Set Me")]
    public TMP_Text displayScore;
    public TMP_Text displayLevel;

    [Header("Set by Start")]
    public TMP_Text score;
    public TMP_Text level;

    void Awake()
    {
        GameObject[] txt = GameObject.FindGameObjectsWithTag("ui");
        score = txt[0].GetComponent<TMP_Text>();
        level = txt[1].GetComponent<TMP_Text>();
        string sc = GameObject.Find("DontDestroy").transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).GetComponent<TMP_Text>().text;
        string lv = GameObject.Find("DontDestroy").transform.GetChild(1).transform.GetChild(0).transform.GetChild(1).GetComponent<TMP_Text>().text;
        //Debug.Log(sc);
        //Debug.Log(lv);

        displayScore.text = displayScore.text + sc;
        displayLevel.text = displayLevel.text + lv;
    }
}
