using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    static public Timer S;

    public float timeValue = 240f;
    public TMP_Text timerTxt;
    public bool reset;

    // Start is called before the first frame update
    void Start()
    {
        S = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0) {
            reset = false;
            timeValue -= Time.deltaTime;
        }
        else {
            timeValue = 0f;
            
            if(!reset) {
                SceneManager.LoadScene("GameOver");
                reset = true;
            }
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeDis) {
            
        if(timeDis < 0) {
            timeDis = 0;
            Score.S.ClearScore();
        }

        float minutes = Mathf.FloorToInt(timeDis/60);
        float seconds = Mathf.FloorToInt(timeDis % 60);

        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void NewTime()
    {
        timeValue = 240f;
    }
}
