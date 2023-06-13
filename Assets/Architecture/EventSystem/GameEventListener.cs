using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

/// <summary>
/// Class for a game event listener that responds to a specific game event and invokes a
/// Unity event when the event is raised
/// </summary>
public class GameEventListener: MonoBehaviour
{
    public int priority;
    public bool respondToAll = false;
    public GameObject instance;
    public GameEvent gameEvent;
    [SerializeField] UnityEvent response;

    private void OnEnable()
    {
        if (gameEvent)
            gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        if (gameEvent)
            gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        if (response != null)
            response.Invoke();
    }

}

#if UNITY_EDITOR
[CustomEditor(typeof(GameEventListener))]
public class GameEventListenerEditor : Editor
{
    GameEventListener instanceGameEventListener;

    SerializedProperty priority;
    SerializedProperty respondToAll;
    SerializedProperty instance;
    SerializedProperty gameEvent;
    SerializedProperty response;

    private void OnEnable()
    {
        instanceGameEventListener = (GameEventListener)target;

        priority = serializedObject.FindProperty("priority");
        respondToAll = serializedObject.FindProperty("respondToAll");
        instance = serializedObject.FindProperty("instance");
        gameEvent = serializedObject.FindProperty("gameEvent");
        response = serializedObject.FindProperty("response");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.PropertyField(priority);
        EditorGUILayout.PropertyField(respondToAll);

        // Only show "instance" property if the listener is not set to respond to All
        if (!instanceGameEventListener.respondToAll)
            EditorGUILayout.PropertyField(instance);

        EditorGUILayout.PropertyField(gameEvent);
        EditorGUILayout.PropertyField(response);

        serializedObject.ApplyModifiedProperties();
    }
}
#endif