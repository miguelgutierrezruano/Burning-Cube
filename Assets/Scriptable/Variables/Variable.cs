using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Variable<T> : ScriptableObject
{
    public T Value;

    public void SetValue(T newValue)
    {
        Value = newValue;
    }
}
