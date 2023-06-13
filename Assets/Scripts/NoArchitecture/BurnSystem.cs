using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BurningSystem class damages a BuddyHealth object when StartBurning method is called
/// </summary>
public class BurnSystem : MonoBehaviour
{
    /// <summary>
    /// Affected BuddyHealth
    /// </summary>
    [SerializeField] private BuddyHealth buddyHealth;
    [SerializeField] private FireEffect fireEffect;

    /// <summary>
    /// AudioSystem to play damage sounds
    /// </summary>
    [SerializeField] private AudioSystem audioSystem;

    /// <summary>
    /// UI system to update game UI
    /// </summary>
    [SerializeField] private UISystem uiSystem;

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

            audioSystem.PlayDamageSound();
            uiSystem.UpdateUI();

            if (buddyHealth.hp > 0)
                yield return new WaitForSeconds(time);
        }

        burning = false;
        buddyHealth.hp = 0;
        buddyHealth.gameObject.SetActive(false);
        fireEffect.SetFireActive(false);
    }
}
