using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    //https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html
    void Awake()
    {
        GameObject[] music = GameObject.FindGameObjectsWithTag("music");
        
        if (music.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
