using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{


    public Button playButton;

    public Button exitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playButton = GameObject.Find("Play").GetComponent<Button>();
        exitButton = GameObject.Find("Exit").GetComponent<Button>();
    }

    void OnEnable()
    {
        playButton.onClick.AddListener(Play);
        exitButton.onClick.AddListener(Exit);
    }

    void OnDisable()
    {
        playButton.onClick.RemoveListener(Play);
        playButton.onClick.RemoveListener(Exit);

    }



    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Settings() { }
    public void Exit()
    {
        Application.Quit();
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
