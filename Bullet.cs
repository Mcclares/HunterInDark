using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;
    public float speed;
    private SpriteRenderer _sprite;
    [SerializeField] Sprite _bulletHorizontal;
    [SerializeField] Sprite _bulletInAngle;
    

   
    
    
    // Start is called before the first frame update
    void Start()
    { 
        
        _sprite = GetComponent<SpriteRenderer>();
        
        switch(Walking.DirectionBullet) {
            case (1):
            direction = Vector2.right;
            _sprite.sprite = _bulletHorizontal;
            _sprite.flipX = false;
            break;
            case (2):
             direction = Vector2.left;
             
             _sprite.sprite = _bulletHorizontal;
             _sprite.flipX = true;
             
             break;
            case (3) :
            direction = Vector2.down;
            _sprite.flipY = true;
            break;
            case(4) :
            direction = Vector2.up;
            _sprite.flipY = false;
            break;
            case(5) :
            direction = new Vector2(0.5f,0.5f);
            _sprite.sprite = _bulletInAngle;
            break;
            case(6) :
            direction = new Vector2(0.5f,-0.5f);
            _sprite.sprite = _bulletInAngle;
            _sprite.flipY = true;
            break;
            case(7) :
            direction = new Vector2(-0.5f,-0.5f);
            _sprite.sprite = _bulletInAngle;
            _sprite.flipY = true;
            _sprite.flipX = true;
            break;
            default :
            direction = new Vector2(-0.5f,0.5f);
            _sprite.sprite = _bulletInAngle;
             _sprite.flipX = true;
            break;
        }
        
        Destroy(gameObject,3f);
        
    }
     private void Awake() {
         
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag != "Hunter") 
        Destroy(gameObject);
    }
}
