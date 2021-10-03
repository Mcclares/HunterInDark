using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public float Damage;
    private Hunter hunter;
    public static UnityAction<float> takeHealth;

    
    // Start is called before the first frame update
    void Start()
    {
        hunter = FindObjectOfType<Hunter>();
        takeHealth += TakeHealth;
        takeHealth?.Invoke(0);
    }

    // Update is called once per frame
    protected virtual void giveDamage(float myselfdamage,Collision2D collider) {
        if(collider.gameObject.tag == "Hunter"){
            
            takeHealth.Invoke(myselfdamage);
        }
    }
    protected virtual void  TakeDamage(float hunterAttack) {
        
    }
    public void TakeHealth(float damage) {
        hunter.Health -= damage;
    }
    void OnCollisionEnter2D(Collision2D other) {
        
        giveDamage(Damage, other);
    }
    void OnCollisionEnter2D(Collision other) {
        if(other.gameObject.tag == "Hunter") {
            hunter.Health -= Damage;
        }
        
    }
}
