using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new GameObject Variable", menuName = "Variables/GameObject")]

/// ScriptableObject that saves a GameObject variable
public class GameObjectVariable : Variable<GameObject>
{
}
