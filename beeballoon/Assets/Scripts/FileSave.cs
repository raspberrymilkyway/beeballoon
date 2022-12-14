using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;
using TMPro;
using System;

[Serializable]
class SaveData{
    public string saveName;
    public string saveFeedback;
    public DateTime saveTime;
    public int saveScore;
    public int saveLevel;
}

public class FileSave : MonoBehaviour
{
    [Header("Set Me")]
    public TMP_Text lastPlayed;

    //https://www.red-gate.com/simple-talk/development/dotnet-development/saving-game-data-with-unity/
    string playName;
    string feedback;
    DateTime time;
    int score;
    int level;

    void Start(){
        load();
        if (level == 0){
            lastPlayed.text = "No level\nlast played.";
        }
        else{
            lastPlayed.text = lastPlayed.text + "\n" + level.ToString();
        }
    }

    public void save(){
        playName = GameObject.Find("PlayerName").transform.GetChild(0).transform.GetChild(2).GetComponent<TMP_Text>().text;
        feedback = GameObject.Find("Feedback").transform.GetChild(0).transform.GetChild(2).GetComponent<TMP_Text>().text;
        //Debug.Log(name.text);
        //Debug.Log(feedback.text);

        time = System.DateTime.Now;
        //Debug.Log(now);

        score = 100;
        level = 1;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/saveData.dat");
        SaveData data = new SaveData();
        data.saveName = playName;
        data.saveFeedback = feedback;
        data.saveTime = time;
        data.saveLevel = level;
        data.saveScore = score;
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("saved data");
    }

    public void load(){
        if (File.Exists(Application.persistentDataPath + "/saveData.dat")){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/saveData.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();
            playName = data.saveName;
            level = data.saveLevel;
            score = data.saveScore;
        }
        else{
            Debug.Log("No save data");
            level = 0;
        }
    }
}
