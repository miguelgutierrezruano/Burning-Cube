using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnSystemSO : MonoBehaviour
{
    [SerializeField] private IntVariable affectedHealth;

    [SerializeField] private GameEvent onHitEvent;
    [SerializeField] private GameEvent onDeathEvent;

    // Time to apply damage
    private float tickTime = 1f;

    // Damage on tick
    private int tickDamage = 1;

    private bool burning = false;

    public void StartBurning()
    {
        if(!burning)
            StartCoroutine(BurnOverTime(tickTime, tickDamage));
    }

    private IEnumerator BurnOverTime(float time, int damage)
    {
        burning = true;
        
        while (affectedHealth.Value > 0)
        {
            affectedHealth.Value -= damage;
            onHitEvent.Raise();

            if(affectedHealth.Value > 0)
                yield return new WaitForSeconds(time);
        }

        burning = false;
        affectedHealth.SetValue(0);
        onDeathEvent.Raise();
    }
}
