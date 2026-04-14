using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{


    public Button playButton;
    public Button exitButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {

       
       

       
       
    }
    void OnEnable()
    {

        if (exitButton==null){

             var ExitGO = GameObject.Find("Exit");

             if (ExitGO != null)
                exitButton = ExitGO.GetComponent<Button>();
        
        }

        if (playButton == null)
        {
             var PlayGO = GameObject.Find("Play");
        if (PlayGO != null)       {
            playButton = PlayGO.GetComponent<Button>();
        }
        }

        
        playButton?.onClick.AddListener(Play);
        exitButton?.onClick.AddListener(Exit);
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
