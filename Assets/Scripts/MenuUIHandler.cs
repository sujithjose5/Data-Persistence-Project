using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
    using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateHighScoreTextInMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method for Start button
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Method to call when Name is entered in the field
    public void NewPlayerSelected(string name)
    {
        // Save name in MenuManager Instance so that it can be accessed from main scene
        MenuManager.Instance.playerName = name;
       
    }

    // Method to update high score in the main menu
    public void UpdateHighScoreTextInMenu()
    {
        ScoreText.text = "Best Score:" +  MenuManager.Instance.highScoreName + "  Score:" + MenuManager.Instance.highScoreValue;
    }

    // Method for Exit button
    public void QuitGame()
    {
#if UNITY_EDITOR
    EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
