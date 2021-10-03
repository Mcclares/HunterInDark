using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBuy : MonoBehaviour
{
    [SerializeField] 
    private GameObject _contractOfBying;
    private Building _building;     // Start is called before the first frame update
    void Start()
    {
        _building = GetComponentInChildren<Building>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Hunter") {
            if(!_building.isBought) {
                _contractOfBying.SetActive(true);
            }
            
        }
    }
}
