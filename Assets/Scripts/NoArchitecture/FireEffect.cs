using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    [SerializeField] private GameObject fireEffect;

    public void SetFireActive(bool active)
    {
        fireEffect.SetActive(active);
    }
}
