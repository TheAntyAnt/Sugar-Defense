using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SugerMainMenu : MonoBehaviour
{
    

public string firstLevel;
public float targetTime;
public string secondlevel;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{

}

public void StartGame()
{

    SceneManager.LoadScene(firstLevel);

}


public void QuitGame()
{
    Application.Quit();
    Debug.Log("Quittign");
}



public void menu()
{

    SceneManager.LoadScene(secondlevel);

}
}

