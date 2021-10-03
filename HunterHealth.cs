using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HunterHealth : MonoBehaviour
{
    private Slider[] slider;
    private Hunter hunter;
    
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponentsInChildren<Slider>();
         hunter = FindObjectOfType<Hunter>();
        slider[0].maxValue = hunter.MaxHealth;
        slider[1].maxValue = hunter.MaxHealth;
        
        Enemy.takeHealth += HealthDetection;
    }

    public void HealthDetection(float a) {
        slider[0].value = hunter.Health;
        slider[1].value = hunter.Health;
    }
  
}
