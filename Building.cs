using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private Light[] lights;
    
    public bool isBought = false;
    private SpriteRenderer sprite;
  
    private void Start() {
        lights = GetComponentsInChildren<Light>();
        sprite = GetComponentInParent<SpriteRenderer>();
     
      
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag ==  "Hunter") {
            sprite.enabled = true;
            
            if(lights.Length > 1) {
            if(isBought) {
                for(int i = 0; i < lights.Length; i++) {
                
                lights[i].enabled = true;

                
                }
            }
        }else {
            if(isBought) {
                lights[0].enabled = true;
            }
          
            
        }
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag ==  "Hunter") {
            sprite.enabled = false;
            if(lights.Length > 1) {
            for(int i = 0; i < lights.Length; i++) {
                lights[i].enabled = false;
            }
        }else {
            lights[0].enabled = false;
            
        }
        }
    }

   
  
}
