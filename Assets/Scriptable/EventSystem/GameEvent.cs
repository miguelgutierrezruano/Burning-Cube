using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "new Game Event", menuName = "Events/Game Event")]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised();
    }

    public void Raise(GameObject instance)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            if (listeners[i].instance == instance || listeners[i].respondToAll)
                listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(GameEventListener listener)
    {
        listeners.Add(listener);

        listeners.Sort((GameEventListener a, GameEventListener b) =>
        {
            if (a.priority < b.priority) return 1;
            if (a.priority > b.priority) return -1;
            return 0;
        });
    }

    public void UnregisterListener(GameEventListener listener)
    {
        listeners.Remove(listener);
    }
}

#if UNITY_EDITOR
[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
    GameEvent instanceGameEvent;

    private void OnEnable()
    {
        instanceGameEvent = (GameEvent)target;
    }

    public override void OnInspectorGUI()
    {        

        if (GUILayout.Button("Raise"))
        {
            instanceGameEvent.Raise();
        }
    }
}
#endif