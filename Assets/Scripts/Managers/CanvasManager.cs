using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CanvasManager : MonoBehaviour
{
    public Button startButton;
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        if (startButton)
            startButton.onClick.AddListener(StartApp);

        if (backButton)
            backButton.onClick.AddListener(BackToStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartApp()
    {
        SceneManager.LoadScene("ARScene");
    }

    void BackToStart()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
