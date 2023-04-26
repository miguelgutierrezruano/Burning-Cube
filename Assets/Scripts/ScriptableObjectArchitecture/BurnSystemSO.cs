using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnSystemSO : MonoBehaviour
{
    [SerializeField] private IntVariable affectedHealth;

    [SerializeField] private GameEvent onHitEvent;

    // Time to apply damage
    private float tickTime = 1f;

    // Damage on tick
    private int tickDamage = 1;

    public void StartBurning()
    {
        StartCoroutine(BurnOverTime(tickTime, tickDamage));
    }

    private IEnumerator BurnOverTime(float time, int damage)
    {
        while (affectedHealth.Value > 0)
        {
            affectedHealth.Value -= damage;
            onHitEvent.Raise();

            yield return new WaitForSeconds(time);
        }

        affectedHealth.SetValue(0);
        // Throw dead event
    }
}
