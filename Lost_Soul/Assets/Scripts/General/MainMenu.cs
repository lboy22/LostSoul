using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string firstStory, options, credits;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartGame()
    {
        // SceneManager.LoadScene(GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Story_One");
    }

    private void Options()
    {

    }

    private void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
