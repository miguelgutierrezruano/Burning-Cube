using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace so
{
    public class AudioSystemSO : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;

        public void PlayDamageSound()
        {
            audioSource.Play();
        }
    }
}
