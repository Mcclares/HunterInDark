
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class UnityLifeHack : MonoBehaviour
{
    Hunter hunter;
    private void Start() {
        hunter = FindObjectOfType<Hunter>();
    }
    #if UNITY_EDITOR
    [MenuItem("Tools/ShootCheck")]
    public static void Shoot() {
        
    }
    #endif
    
}
