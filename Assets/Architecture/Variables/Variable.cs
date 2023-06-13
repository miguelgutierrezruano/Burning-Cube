using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Template class to save a variable
/// </summary>
/// <typeparam name="T">Type of Value variable</typeparam>
public abstract class Variable<T> : ScriptableObject
{
    public T Value;

    public void SetValue(T newValue)
    {
        Value = newValue;
    }
}
