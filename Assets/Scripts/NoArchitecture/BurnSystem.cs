using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Quitar referencias en NoArchitecture, quitar eventos en SOs
public class BurnSystem : MonoBehaviour
{
    [SerializeField] private BuddyHealth buddyHealth;
    [SerializeField] private AudioSystem audioSystem;
    [SerializeField] private UISystem uiSystem;

    // Time to apply damage
    private float tickTime = 1f;

    // Damage on tick
    private int tickDamage = 1;

    private bool burning = false;

    public void StartBurning()
    {
        if (!burning)
            StartCoroutine(BurnOverTime(tickTime, tickDamage));
    }

    private IEnumerator BurnOverTime(float time, int damage)
    {
        burning = true;

        while (buddyHealth.hp > 0)
        {
            buddyHealth.hp -= damage;

            uiSystem.UpdateUI();
            audioSystem.PlayDamageSound();

            yield return new WaitForSeconds(time);
        }

        burning = false;
        buddyHealth.hp = 0;
    }
}
