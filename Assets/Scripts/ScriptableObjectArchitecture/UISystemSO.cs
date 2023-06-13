using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace so
{
    /// <summary>
    /// UISystem class updates a HealthBar when method UpdateUI gets called
    /// </summary>
    public class UISystemSO : MonoBehaviour
    {
        /// <summary>
        /// IntVariable representing current health
        /// </summary>
        [SerializeField] private IntVariable health;

        /// <summary>
        /// IntVariable representing initialHealth
        /// </summary>
        [SerializeField] private IntVariable initialHealth;

        /// <summary>
        /// Fill image of the health bar
        /// </summary>
        [SerializeField] private Image healthBar;
    
        public void UpdateUI()
        {
            healthBar.fillAmount = (float)health.Value / initialHealth.Value;
        }
    }
}

