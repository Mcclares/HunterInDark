using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownScript : MonoBehaviour
{
    private AudioSource _source;
    [SerializeField]
    Hunter hunter;
    
    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        _source.Play();
        hunter.isFight = false;

    }
    private void OnTriggerExit2D(Collider2D other) {
        _source.Stop();
        hunter.isFight = true;
    }
}
