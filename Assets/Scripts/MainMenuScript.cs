using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{


    public Button playButton;
    public Button exitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        //subscribe pakai Event.AddListener(Method);
    }

    void OnDisable()
    {
    //unsubscribe pakai Event.RemoveListener(Method);

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
