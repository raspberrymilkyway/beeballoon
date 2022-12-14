using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    static public Score S;

    public TMP_Text scoreTxt;
    public int currScore;

    // Start is called before the first frame update
    void Start()
    {
        S = this;

        currScore = 0;
    }

    public void BeeBalloon() {
        currScore += 10;
        scoreTxt.text = currScore.ToString();
    }
}
