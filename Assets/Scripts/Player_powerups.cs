using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_powerups : MonoBehaviour
{
    private int _axolote_mod;

    public int axolote_mod
    {
        get{return _axolote_mod;}
        set{_axolote_mod = value;}
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "axolote"){
            axolote_mod = other.gameObject.GetComponent<axolote>().axolote_mod;
        }
    }

}
