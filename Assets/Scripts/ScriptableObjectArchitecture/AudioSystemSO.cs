using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace so
{
    /// <summary>
    /// The AudioSystemSO class contains a method to play a damage sound using an AudioSource.
    /// </summary>
    public class AudioSystemSO : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;

        public void PlayDamageSound()
        {
            audioSource.Play();
        }
    }
}
