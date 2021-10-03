using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField]
    private AudioClip _clip;
    [SerializeField]
    private AudioClip walkingInLabirint;

    private bool isPlaying;
    
 
    // Start is called before the first frame update
    void Start()
    {   
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = _clip;
    }

    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D other) {
       if(other.tag == "Hunter") {
           if(!isPlaying) {
           _audioSource.Play();
           isPlaying = true ;
           }
           else {
            _audioSource.Pause();
            isPlaying = false;
           }
           other.GetComponent<AudioSource>().clip = walkingInLabirint;
       }
   }
     
   
}
