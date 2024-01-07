using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuUI;
    static float pause = 0f, resume = 1f;
    string MainMenu = "Main Menu";
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //audioSource.ignoreListenerPause = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale != 0)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }
    public void Pause()
    {
        Time.timeScale = pause;
        pauseMenuUI.SetActive(true);
        Debug.Log("P was pressed: " + pause);
    }

    public void Resume()
    {
        Time.timeScale = resume;
        pauseMenuUI.SetActive(false);
        Debug.Log("P was pressed, or Resume was clicked: " + pause);
    }

    public void MainMenuReturn()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
