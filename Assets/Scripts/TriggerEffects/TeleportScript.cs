using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    
    public GameObject to;
    public SoundtrackScript sts;
    public SoundEffectScript ses;
    LogicScript logicScript;

  void Start ()
    {
    logicScript = FindFirstObjectByType<LogicScript>();

    }
    void Teleport()
    {
              GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = to.transform.position;
        logicScript.insideHouse =!logicScript.insideHouse;
        if (sts != null)
        {
            sts.togglesound();
            ses.windowEffect();
        }
    }
}
