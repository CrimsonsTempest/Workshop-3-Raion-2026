using UnityEngine;

public class pintuScript : EffectScript
{
    [SerializeField] GameObject IsiToilet;
    [SerializeField] SoundEffectScript ses;

    public override void EffectTrigger()
    {
        bukaPintu() ; 
}
    void bukaPintu()
    {
         ses.pintuEffect();
        IsiToilet.SetActive(true);
    }
}
