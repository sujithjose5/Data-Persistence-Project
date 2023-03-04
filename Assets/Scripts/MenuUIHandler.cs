using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Method to call when Name is entered in the field
    public void NewPlayerSelected(string name)
    {
        // Save name in MenuManager so that it can be accessed from main scene
        MenuManager.Instance.playerName = name;
        Debug.Log("NewPlayerAssigned with name" + name);
    }
}
