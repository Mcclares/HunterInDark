
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class HelloWorld : MonoBehaviour
{
    #if UNITY_EDITOR
    [MenuItem("GameObject/ Create HelloWorld")]
    private static void CreateHelloWorld() {
        if(EditorUtility.DisplayDialog("Hello world", "Do you really want to do this?", "Create","Cancel" )) 
        {
            new GameObject("HelloWorld");

        }
    }
    #endif
}
