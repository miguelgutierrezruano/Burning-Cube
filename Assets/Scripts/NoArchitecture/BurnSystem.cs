using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnSystem : MonoBehaviour
{
    [SerializeField] private BuddyHealth buddyHealth;
    [SerializeField] private FireEffect fireEffect;

    // Time to apply damage
    private float tickTime = 1f;

    // Damage on tick
    private int tickDamage = 1;

    private bool burning = false;

    public void StartBurning()
    {
        if (!burning)
        {
            StartCoroutine(BurnOverTime(tickTime, tickDamage));
            fireEffect.SetFireActive(true);
        }
    }

    private IEnumerator BurnOverTime(float time, int damage)
    {
        burning = true;

        while (buddyHealth.hp > 0)
        {
            buddyHealth.hp -= damage;

            if (buddyHealth.hp > 0)
                yield return new WaitForSeconds(time);
        }

        burning = false;
        buddyHealth.hp = 0;
        buddyHealth.gameObject.SetActive(false);
        fireEffect.SetFireActive(false);
    }
}
