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

    public void StartGame()
    {
        // SceneManager.LoadScene(GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("First_Story");
    }

    public void Options()
    {

    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ExitGame()
    {
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
