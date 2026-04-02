using UnityEngine;

public class pintuScript : MonoBehaviour
{
    [SerializeField] GameObject IsiToilet;
    [SerializeField] SoundEffectScript ses;

    void bukaPintu()
    {
         ses.pintuEffect();
        IsiToilet.SetActive(true);
    }
}
