using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletsInMagazin : MonoBehaviour
{
    [SerializeField]
    private Hunter hunter;
    private Text _text;

    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        _text.text = hunter.BulletsInMagazin.ToString();
        Hunter.wastPuli += showMagazinBullet;
        Hunter.plusReloadInMagazin += showMagazinBullet;
    }

    public void showMagazinBullet() => _text.text = hunter.BulletsInMagazin.ToString();
    
}
