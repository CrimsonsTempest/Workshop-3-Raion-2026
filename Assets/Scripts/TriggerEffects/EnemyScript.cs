using System.Collections;
using UnityEngine;

public class EnemyScript : EffectScript
{
    LogicScript ls;
    public bool beingAttacked = false;
    public PlayerMovement playerMovement;
    [SerializeField] private Animator animator;
    public GameObject QTE;

    public override void EffectTrigger()
    {
        Attack();
    }

    void Attack() //main effect
    {
          QTE.SetActive(true);
        ls = FindObjectOfType<LogicScript>();
        beingAttacked = true;
        {
            playerMovement.canMove = false;
            Debug.Log("Setfalse");
        }
        StartCoroutine(Attacked());
    }

    private IEnumerator Attacked()
    {
        while (beingAttacked)
        {
            ls.HealthEdit(-1, name);
            animator.SetTrigger("Attacked");

            yield return new WaitForSeconds(1f);
        }
    }
}
