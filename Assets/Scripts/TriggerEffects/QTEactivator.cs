using UnityEngine;

public class QTEactivator : effectScript
{
    public GameObject QTE;
    public override void InteractTrigger()
    {
        QTE_on();
    }

    void QTE_on()
    {
    QTE.SetActive(true);

    }
}
