using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace so
{
    public class BuddyHealthSO : MonoBehaviour
    {
        // Health variable
        [SerializeField] private IntVariable health;
        [SerializeField] private IntVariable initialHealth;

        private void Start()
        {
            health.Value = initialHealth.Value;
        }
    }
}

