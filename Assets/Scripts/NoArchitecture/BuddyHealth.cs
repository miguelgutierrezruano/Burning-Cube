using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The BuddyHealth class defines the current Health Points of an object
/// </summary>
public class BuddyHealth : MonoBehaviour
{
    /// <summary>
    /// Starting HP of an object
    /// </summary>
    public int maxHP { get; private set; }

    /// <summary>
    /// Current HP of an object
    /// </summary>
    public int hp;

    private void Start()
    {
        maxHP = 10;
        hp = maxHP;
    }
}
