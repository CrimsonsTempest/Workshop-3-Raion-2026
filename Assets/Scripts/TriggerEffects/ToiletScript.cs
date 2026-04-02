using UnityEngine;

public class ToiletScript : MonoBehaviour
{
    LogicScript ls;
    public SoundEffectScript ses;


     void DrinkFromToilet()
    {
        ls = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        ses.toiletEffect();
        ls.HealthEdit(-2, name);
    }
}
