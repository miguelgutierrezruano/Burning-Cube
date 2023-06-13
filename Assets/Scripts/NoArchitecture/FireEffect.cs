using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class to manage fire enable and disable
/// </summary>
public class FireEffect : MonoBehaviour
{
    [SerializeField] private GameObject fireEffect;

    public void SetFireActive(bool active)
    {
        fireEffect.SetActive(active);
    }
}
