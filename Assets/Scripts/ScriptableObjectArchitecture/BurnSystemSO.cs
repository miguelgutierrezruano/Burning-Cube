using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace so
{
    /// <summary>
    /// BurningSystem class decreases an IntVariable over time when StartBurning method is called
    /// </summary>
    public class BurnSystemSO : MonoBehaviour
    {
        /// <summary>
        /// IntVariable which should be decreased
        /// </summary>
        [SerializeField] private IntVariable affectedHealth;

        /// <summary>
        /// Event thrown on every hit of the BurningSystem
        /// </summary>
        [SerializeField] private GameEvent onHitEvent;

        /// <summary>
        /// Event thrown when affectedHealth goes below 0
        /// </summary>
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
}

