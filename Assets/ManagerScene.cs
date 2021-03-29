using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    Scene scene;
    public Button startButton;
    public Button quitButton;
    // Start is called before the first frame update
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        startButton.onClick.AddListener(StartUp);
        startButton.onClick.AddListener(Quit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartUp ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    void Quit ()
    {
        Application.Quit();
    }
}
