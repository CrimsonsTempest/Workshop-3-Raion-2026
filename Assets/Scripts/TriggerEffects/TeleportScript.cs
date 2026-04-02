using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    
    public GameObject to;
    public SoundtrackScript sts;
    public SoundEffectScript ses;

    void Teleport()
    {
              GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = to.transform.position;
        if (sts != null)
        {
            sts.togglesound();
            ses.windowEffect();
        }
    }
}
