using UnityEngine;

public class ToiletScript : EffectScript
{
    LogicScript ls;
    public SoundEffectScript ses;


    public override void EffectTrigger()
    {
DrinkFromToilet();
    }
     void DrinkFromToilet()
    {
        ls = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        ses.toiletEffect();
        ls.HealthEdit(-2, name);
    }
}
