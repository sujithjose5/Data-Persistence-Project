using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string playerName; //Current player name
    public string highScoreName; // Player with the highest score
    public int highScoreValue; // Highest score

    private void Awake()
    {
        if (Instance!= null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string highScoreName;
        public int highScoreValue;

    }

    // Method to save highscore in json file
    public void SaveHighScore(string currentPlayer, int currentScore)
    {
        SaveData data = new SaveData();
        data.highScoreName = currentPlayer;
        data.highScoreValue = currentScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    // Method to load highscore from json file
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScoreName = data.highScoreName;
            highScoreValue = data.highScoreValue;
        }

    }
}
