using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int levelToLoad;
    // Start is called before the first frame update
    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    // Update is called once per frame
    public void LevelExit()
    {
        Application.Quit();
    }
}
