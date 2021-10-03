using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;
using UnityEngine.Events;
using System.IO;
using UnityEngine.UI;




public class Hunter : MonoBehaviour
{
    Vector3 direction;
    //!Stage
    public float speed = 1;
    private float _health = 100;
    public float Health {get{ return _health;} set { _health = value;} }
    
    private float _maxHealth = 100;
    public float MaxHealth {get{ return _health;} set { _health = value;} }
    public bool isFight;
    [HideInInspector]
    public bool OnHourse;

    // Todo: Shooting;
    private byte bullets = 255;
    public byte Bullets {get{return bullets;} set {bullets = value;}}
    private byte bulletsInMagazin = 6;
    public byte BulletsInMagazin{get{return bulletsInMagazin;}}
    private byte magazin = 6;
    public float timeForReload;
    private float timerForReloadCopy;
    public bool reload = false;
    private GameObject bullet;
    [SerializeField] Transform shootPosition;
    private int money;
    public int Money{get{return money;} set {money = value;}}
    // Todo Actions
    public static UnityAction wastPuli;
    public static UnityAction minusBulletsInCommon;
    public static UnityAction plusReloadInMagazin;

    //!Saving

    SaveData data = new SaveData();
    private string path;
  
    // Todo Estetika
    AudioSource source;
    Animator _animator;
    Animation _anim;
    Rigidbody2D rigidbody2D;
    [SerializeField] AudioClip Zatjag;
    [SerializeField] AudioClip Vidoh;
    [SerializeField] AudioClip Shooting;
    [SerializeField] AudioClip reloading;
   
    Quaternion rot;
    //todo: Horse


  
  

    private CharState State {
        get { return (CharState)_animator.GetInteger("State");}
        set { _animator.SetInteger("State",(int)value); }

    }
    private void Awake() {
        bullet = (GameObject)Resources.Load("BulletForRevolver");
        wastPuli += PuliCount;
        wastPuli?.Invoke();
        minusBulletsInCommon += reloadBulletMinus;
        plusReloadInMagazin +=  reloadBulletsPlus;
     
        
      
        
      

    }
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _anim = GetComponent<Animation>();
      
      
        #if UNITY_ANDROID && !UNITY_EDITOR
    path = Path.Combine(Application.persistentDataPath, "Save.json");
#else
    path = Path.Combine(Application.dataPath, "Save.json");
#endif
        if(File.Exists(path)) {
            money = data.Money;
            bullets = data.Bullets;
            Health = data.Health;
        }
        timerForReloadCopy = timeForReload;
    }

    // Update is called once per frame
    void Update()
    {
        
        var inputDevice = InputManager.ActiveDevice;
        
        if(inputDevice.IsActive & inputDevice.LeftStick) {
            Walking.Walk(inputDevice, this);
            if(isFight) {
                State = CharState.walk;
            }else {
                State = CharState.walkWithout;
            }
            
            inputDevice.ClearInputState();
        }else if( inputDevice.Action1.WasPressed & !reload) {
            if(bulletsInMagazin > 0) {
                
                Shoot();
                
            } else {
                StartCoroutine(Reload());
            }
            

        }
        else {
            if(isFight) {

            State = CharState.idle;

            } else {

            State = CharState.idleWithout;
            }
        }
       
        
             
        
       

     
    

    }
    public IEnumerator Reload() {
            reload = true;
            source.PlayOneShot(reloading);
           yield return new WaitForSeconds(timeForReload);
            minusBulletsInCommon.Invoke();
            plusReloadInMagazin.Invoke();
            reload = false;
            yield return null;
    }
    
   

    public void MusicForWalking() {
        source.PlayOneShot(source.clip);
    }
    public void MusicForZatjag() {
        source.PlayOneShot(Zatjag);
    }
     public void MusicForVidoh() {
        source.PlayOneShot(Vidoh);
    }
    public void MusicForShooting() {
        source.PlayOneShot(Shooting);
    }
    
  
    public  void Shoot() {
        if(isFight) {
        State = CharState.shoot;
        wastPuli.Invoke();
        Instantiate(bullet, shootPosition.transform.position,Quaternion.identity);
        }
        
    }
    public void PuliCount() {
        bulletsInMagazin--;
    }
    public void reloadBulletMinus() {
        bullets -= magazin;
    }
    public void reloadBulletsPlus() {
        bulletsInMagazin += magazin;
    }

  
      
    
   
    public enum CharState {
        idle,
        walk,
        shoot,
        walkWithout,
        idleWithout
       
    }
    
}
