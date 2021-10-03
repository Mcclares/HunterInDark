using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : MonoBehaviour
{
    [SerializeField]
    Hunter hunter;
    BoxCollider2D boxSize;
    Collision2D colliders;
    int directionOfBullet;
    float speed;
    bool OnHourse = false;
    [SerializeField]
    GameObject JustHorse;
    [SerializeField]
    GameObject hunterHorse;
    

    //todo buttons of switching horse
    [SerializeField]
    GameObject onHorse;
     [SerializeField]
    GameObject outHorse;
    private AudioSource audioSource;
    [SerializeField]
    AudioClip _horseWalking;
    AudioClip _hunterWalking;
    

    private void Start() {
        
      boxSize = hunter.GetComponent<BoxCollider2D>();
      audioSource = hunter.GetComponent<AudioSource>();
      _hunterWalking = audioSource.clip;
      
     
    }

    public void incrementSpeed() {
       
    
            
            if(Walking.DirectionBullet == 1) {
       
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x + 1,transform.position.y, transform.position.z ), transform.localScale.x * Vector2.right* 1.5f  );
            Debug.Log(ray2D.collider);
            if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                 onHorse.SetActive(false);
                 outHorse.SetActive(true);
                  audioSource.clip = _horseWalking;
                }

            }
            }
        
           else if (Walking.DirectionBullet == 2) {
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x - 1,transform.position.y, transform.position.z ), hunter.transform.localScale.x * Vector2.left * 1.5f  );
            Debug.Log(ray2D.collider);
               if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                onHorse.SetActive(false);
                outHorse.SetActive(true);
                 audioSource.clip = _horseWalking;
                   }
                }
           }
             if(Walking.DirectionBullet == 4) {
       
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x ,transform.position.y + 1, transform.position.z ), transform.localScale.y * Vector2.up* 1.5f  );
            Debug.Log(ray2D.collider);
            if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                 onHorse.SetActive(false);
                 outHorse.SetActive(true);
                  audioSource.clip = _horseWalking;
                }

            }
            }
        
           else if (Walking.DirectionBullet == 3) {
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x,transform.position.y - 1, transform.position.z ), hunter.transform.localScale.y * Vector2.down * 1.5f  );
            Debug.Log(ray2D.collider);
               if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                onHorse.SetActive(false);
                outHorse.SetActive(true);
                 audioSource.clip = _horseWalking;
                   }
                }
           }
             if(Walking.DirectionBullet == 5) {
       
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x + 1,transform.position.y + 1, transform.position.z ), transform.localScale * new Vector2(1,1)*  1.5f  );
            Debug.Log(ray2D.collider);
            if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                 onHorse.SetActive(false);
                 outHorse.SetActive(true);
                  audioSource.clip = _horseWalking;
                }

            }
            }
        
           else if (Walking.DirectionBullet == 6) {
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x + 1,transform.position.y - 1, transform.position.z ), hunter.transform.localScale * new Vector2(1,-1) * 1.5f  );
            Debug.Log(ray2D.collider);
               if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                onHorse.SetActive(false);
                outHorse.SetActive(true);
                 audioSource.clip = _horseWalking;
                   }
                }
           }
           if(Walking.DirectionBullet == 7) {
       
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x - 1,transform.position.y - 1, transform.position.z ), transform.localScale * new Vector2(-1,-1)*  1.5f  );
            Debug.Log(ray2D.collider);
            if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                 onHorse.SetActive(false);
                 outHorse.SetActive(true);
                  audioSource.clip = _horseWalking;
                }

            }
            }
        
           else if (Walking.DirectionBullet == 8) {
            RaycastHit2D ray2D = Physics2D.Raycast(new Vector3(transform.position.x - 1,transform.position.y + 1, transform.position.z ), hunter.transform.localScale * new Vector2(-1,1) * 1.5f  );
            Debug.Log(ray2D.collider);
               if(ray2D.collider.tag == "Horse") {
                if(!OnHourse) {
                Destroy(ray2D.collider.gameObject);
                hunter.speed *= 2.5f;
                OnHourse = true;
                boxSize.size = new Vector2(boxSize.size.x  ,3.35f);
                hunterHorse.SetActive(true);
                onHorse.SetActive(false);
                outHorse.SetActive(true);
                 audioSource.clip = _horseWalking;
                   }
                }
           }
          

        
        
        
          
 
        
    }
       public void lowSpeed() {
       
      
        if(OnHourse){
            Instantiate(JustHorse ,hunter.transform.position,Quaternion.identity);
            OnHourse = false;
            hunter.speed /= 2.5f;
            boxSize.size = new Vector2(boxSize.size.x  ,1.42f);
            hunter.transform.position = new Vector3(hunter.transform.position.x + 1, hunter.transform.position.y, hunter.transform.position.z);
            outHorse.SetActive(false);
            onHorse.SetActive(true);
            hunterHorse.SetActive(false);
             audioSource.clip = _hunterWalking;
           

        
        
        }
        
       
        
    }
        void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position,transform.position + transform.localScale.x * Vector3.right * 5);
    }
}
