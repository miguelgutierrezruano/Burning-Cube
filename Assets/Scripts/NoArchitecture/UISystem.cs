using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystem : MonoBehaviour
{
    [SerializeField] private BuddyHealth buddyHealth;

    [SerializeField] private Image healthBar;

    public void UpdateUI()
    {
        healthBar.fillAmount = (float)buddyHealth.hp / buddyHealth.maxHP;
    }
}
