
using UnityEngine;

public class pintuScript : effectScript
{
    [SerializeField] GameObject IsiToilet;
    [SerializeField] SoundEffectScript ses;
    public override void InteractTrigger()
    {
        ses.pintuEffect();
        IsiToilet.SetActive(true);
    }
}
