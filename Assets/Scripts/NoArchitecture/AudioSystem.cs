using UnityEngine;

/// <summary>
/// The AudioSystem class contains a method to play a damage sound using an AudioSource.
/// </summary>
public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    public void PlayDamageSound()
    {
        audioSource.Play();
    }
}
