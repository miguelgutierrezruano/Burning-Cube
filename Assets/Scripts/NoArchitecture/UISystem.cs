using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UISystem class updates a HealthBar when method UpdateUI gets called
/// </summary>
public class UISystem : MonoBehaviour
{
    /// <summary>
    /// BuddyHealth to display
    /// </summary>
    [SerializeField] private BuddyHealth buddyHealth;

    /// <summary>
    /// Fill image of the health bar
    /// </summary>
    [SerializeField] private Image healthBar;

    public void UpdateUI()
    {
        healthBar.fillAmount = (float)buddyHealth.hp / buddyHealth.maxHP;
    }
}
