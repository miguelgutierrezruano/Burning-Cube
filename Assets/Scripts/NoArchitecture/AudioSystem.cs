using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public void PlayDamageSound()
    {
        audioSource.Play();
    }
}
