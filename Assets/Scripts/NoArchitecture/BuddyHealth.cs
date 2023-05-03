using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyHealth : MonoBehaviour
{
    public int maxHP { get; private set; }
    public int hp;

    private void Start()
    {
        maxHP = 10;
        hp = maxHP;
    }
}
