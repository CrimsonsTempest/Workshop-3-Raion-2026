using UnityEngine;

public class TeleportScript : EffectScript
{
    
    public GameObject to;
    public SoundtrackScript sts;
    public SoundEffectScript ses;
    LogicScript logicScript;




void Start ()
    {
    logicScript = FindObjectOfType<LogicScript>();

    }

    public override void EffectTrigger()
    {
        Teleport();
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
