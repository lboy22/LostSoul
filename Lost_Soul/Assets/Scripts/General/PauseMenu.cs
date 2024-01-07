using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] string MainMenu;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.ignoreListenerPause = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {

        }
    }

    private void Resume()
    {

    }

    private void MainMenuReturn()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
