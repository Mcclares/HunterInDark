using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCount : MonoBehaviour
{
    Text _text;
    [SerializeField]
    Hunter hunter;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        _text.text = hunter.Bullets.ToString();
        Hunter.minusBulletsInCommon += ShowPuli;
    }

    public void ShowPuli() => _text.text = hunter.Bullets.ToString();

    
}
