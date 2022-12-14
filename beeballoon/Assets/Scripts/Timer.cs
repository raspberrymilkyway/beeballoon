using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public float timeValue = 240f;
    public TMP_Text timerTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeValue > 0) {
            
            timeValue -= Time.deltaTime;
        }
        else {
            
            timeValue = 0f;
            SceneManager.LoadScene("GameOver");
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeDis) {
            
        if(timeDis < 0) {
            timeDis = 0;
        }

        float minutes = Mathf.FloorToInt(timeDis/60);
        float seconds = Mathf.FloorToInt(timeDis % 60);

        timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
