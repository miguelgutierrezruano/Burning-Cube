using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace so
{
    /// <summary>
    /// The BuddyHealthSO class defines the current Health Points of an object
    /// </summary>
    public class BuddyHealthSO : MonoBehaviour
    {
        /// <summary>
        /// IntVariable representing the health of an object
        /// </summary>
        [SerializeField] private IntVariable health;

        /// <summary>
        /// IntVariable representing the starting health of an object
        /// </summary>
        [SerializeField] private IntVariable initialHealth;

        private void Start()
        {
            health.Value = initialHealth.Value;
        }
    }
}

