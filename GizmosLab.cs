using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosLab : MonoBehaviour
{
    BoxCollider2D box;
    private void OnDrawGizmosSelected() {
        box = GetComponent<BoxCollider2D>();
        Gizmos.color = Color.red;
    
      
    }
  
}
