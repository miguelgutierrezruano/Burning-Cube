using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystemSO : MonoBehaviour
{
    [SerializeField] private IntVariable health;
    [SerializeField] private IntVariable initialHealth;

    [SerializeField] private Image healthBar;
    
    public void UpdateUI()
    {
        healthBar.fillAmount = (float)health.Value / initialHealth.Value;
    }
}
