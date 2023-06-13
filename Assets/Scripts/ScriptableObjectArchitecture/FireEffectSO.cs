using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace so
{
    /// <summary>
    /// Class to manage fire enable and disable
    /// </summary>
    public class FireEffectSO : MonoBehaviour
    {
        [SerializeField] private GameObject fireEffect;

        public void SetFireActive(bool active)
        {
            fireEffect.SetActive(active);
        }
    }
}


