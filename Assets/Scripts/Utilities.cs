using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utilities
{
    public static int playerDeaths = 0;
    public static string UpdateDeathCount(ref int countReference)
    {
        countReference += 1;
        return "Next time you'll be at number " + countReference;
    }
    public static void RestartLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        Debug.Log("Player deaths: " + playerDeaths);
        string message = UpdateDeathCount(ref playerDeaths);
        Debug.Log("Player deaths: " + playerDeaths);
    }
    public static bool RestartLevel(int sceneIndex)
    {
        if (sceneIndex < 0)
        {
            // 2
            throw new System.ArgumentException("Scene index cannot be negative");
        }
        // 2
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1.0f;
        // 3
        return true;
    }


    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

        
}
